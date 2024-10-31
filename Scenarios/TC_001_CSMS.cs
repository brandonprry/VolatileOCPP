using System;
using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace ocpp.Scenarios;

public class TC_001_CSMS : IScenario
{
    public string[] Dependencies { get { return ["BootNotification", "StatusNotification", "Heartbeat"];}}

    public bool DependsOn(string method)
    {
        return Dependencies.Contains(method);
    }

    public bool RunScenario(string url, string protocol)
    {
        using var ws = new WebSocket(url, protocol);
        ws.Connect();
        
        Charger charger = new Charger(ws);

        bool passed = false;
        bool step1 = false, step2 = false, step3 = false;
        ws.OnMessage += (sender, e) =>
       {
           JArray a = JArray.Parse(e.Data);
           JObject? j = a[2] as JObject;

           if (j == null)
               return;

           if (step1 == false)
           {
             
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/BootNotificationResponse.json")))
                   throw new Exception("Invalid response");

               if (j["status"] == null ||
                   j["status"].Value<string>() != "Accepted")
                   throw new Exception("Invalid response");

                step1 = true;
           }
           else if (step2 == false)
           {
               
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");

                step2 = true;
           }
           else if (step3 == false)
           {
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/HeartbeatResponse.json")))
                   throw new Exception("Invalid response");

                passed = true;
                step3 = true;
           }
       };

        charger.SendBootNotification();
        
        while (step1 == false)
            Thread.Sleep(1000);

        charger.SendStatusNotification();
        
        while (step2 == false)
            Thread.Sleep(1000);
        
        charger.SendHeartbeat();
        
        while (step3 == false)
            Thread.Sleep(1000);

        return passed;
    }
}
