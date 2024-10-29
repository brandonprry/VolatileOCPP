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

        ws.Send("[2,\"852a4cb2-0e20-46f8-bc29-c5ab3cb182c7\",\"BootNotification\",{\"chargePointVendor\":\"volatileocpp\",\"chargePointModel\":\"Charging System\"}]");
        Thread.Sleep(1000);

        ws.Send("[2,\"9b25cbb0-c016-41e7-baa0-e796a9565c11\",\"StatusNotification\",{\"connectorId\":1,\"errorCode\":\"NoError\",\"status\":\"Available\"}]");
        Thread.Sleep(1000);
        
        ws.Send("[2, \"a187bcd6-4042-4a82-b6d4-b4c55d2f2c8b\", \"Heartbeat\", {}]");
        Thread.Sleep(1000);

        return false;
    }
}
