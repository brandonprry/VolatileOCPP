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

        int i = 1;
        bool passed = false;
        Charger charger = new Charger(ws);
        ws.OnMessage += (sender, e) =>
       {
           JArray a = JArray.Parse(e.Data);
           JObject? j = a[2] as JObject;

           if (j == null)
               return;

           if (i == 1)
           {
               i++;
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");
           }
           else if (i == 2)
           {
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");
                
                passed = true;
           }
       };
    
        charger.SendStatusNotification(status: "Preparing");
        Thread.Sleep(1000);
        
        charger.SendStatusNotification(errorCode: "ConnectorLockFault", status: "Faulted");
        Thread.Sleep(1000);
        
        return passed;
    }
}
