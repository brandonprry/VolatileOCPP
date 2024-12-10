using System;
using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace ocpp.Scenarios;

public class TC_024_CSMS : IScenario
{
    public string[] Dependencies { get { return ["StatusNotification"];}}

    public bool DependsOn(string method)
    {
        return Dependencies.Contains(method);
    }

    public bool RunScenario(string url, string protocol)
    {
        using var ws = new WebSocket(url, protocol);
        ws.Connect();

        
        bool passed = false;
        Charger charger = new Charger(ws);
        bool step1 = false, step2 = false;
        ws.OnMessage += (sender, e) =>
       {
           JArray a = JArray.Parse(e.Data);
           JObject? j = a[2] as JObject;

           if (j == null)
               return;

           if (!step1)
           {
               
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");
                
                step1 = true;
           }
           else if (!step2)
           {
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");
                
                step2 = true;
                passed = true;
           }
       };
    
        charger.SendStatusNotification(status: "Preparing");

        while (!step1)
        Thread.Sleep(1000);
        
        charger.SendStatusNotification(errorCode: "ConnectorLockFault", status: "Faulted");

        while (!step2)
        Thread.Sleep(1000);
        
        return passed;
    }
}
