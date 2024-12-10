using System;
using WebSocketSharp;
using Newtonsoft.Json.Linq;

namespace ocpp.Scenarios;

public class TC_005_1_CSMS : IScenario
{
    public string[] Dependencies { get { return ["StatusNotification", "StopTransaction", "StartTransaction"]; } }

    public bool DependsOn(string method)
    {
        return Dependencies.Contains(method);
    }
    public bool RunScenario(string url, string protocol)
    {

        using var ws = new WebSocket(url, protocol);
        ws.Connect();

        Charger charger = new Charger(ws);
        int i = 1;
        int transid = 0;
        bool passed = false;
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
               i++;

               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StartTransactionResponse.json")))
                   throw new Exception("Invalid response");

               if (j["idTagInfo"]["status"] == null || j["idTagInfo"]["status"].Value<string>() != "Accepted")
               {
                   Console.WriteLine("Expected Accepted response, got " + j["idTagInfo"]["status"].Value<string>());
                   throw new Exception("Invalid response");
               }
               transid = j["transactionId"].Value<int>();

           }
           else if (i == 3)
           {
               i++;
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");
           }
           else if (i == 4)
           {
               i++;
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");
           }
           else if (i == 5)
           {
               i++;
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StopTransactionResponse.json")))
                   throw new Exception("Invalid response");
           }
           else if (i == 6)
           {
               i++;
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");
           }
           else if (i == 7)
           {
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");

                passed = true;
           }
       };

        charger.SendStatusNotification(status: "Preparing");
        Thread.Sleep(1000);

        charger.SendStartTransaction();
        Thread.Sleep(1000);

        charger.SendStatusNotification(status: "Charging");
        Thread.Sleep(1000);

        charger.SendStatusNotification(status: "SuspendedEV");
        Thread.Sleep(1000);

        charger.SendStopTransaction(transid.ToString());
        Thread.Sleep(1000);

        charger.SendStatusNotification(status: "Finishing");
        Thread.Sleep(1000);

        charger.SendStatusNotification();
        Thread.Sleep(1000);

        return passed;
    }
}