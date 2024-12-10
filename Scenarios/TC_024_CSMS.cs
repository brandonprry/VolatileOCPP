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
        ws.OnMessage += (sender, e) =>
       {
           JArray a = JArray.Parse(e.Data);
           JObject? j = a[2] as JObject;

           if (j == null)
               return;

           if (i == 1)
           {
               i++;
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/BootNotificationResponse.json")))
                   throw new Exception("Invalid response");

               if (j["status"] == null ||
                   j["status"].Value<string>() != "Accepted")
                   throw new Exception("Invalid response");
           }
           else if (i == 2)
           {
               i++;
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");
           }
           else if (i == 3)
           {
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/HeartbeatResponse.json")))
                   throw new Exception("Invalid response");
           }
       };
    
        ws.Send("[2,\"9b25cbb0-c016-41e7-baa0-e796a9565c11\",\"StatusNotification\",{\"connectorId\":1,\"errorCode\":\"NoError\",\"status\":\"Preparing\"}]");
        Thread.Sleep(1000);
        
        ws.Send("[2,\"9b25cbb0-c016-41e7-baa0-e796a9565c11\",\"StatusNotification\",{\"connectorId\":1,\"errorCode\":\"ConnectorLockFailure\",\"status\":\"Faulted\"}]");
        Thread.Sleep(1000);
        
        return false;
    }
}
