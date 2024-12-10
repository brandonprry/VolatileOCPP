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
        
        int transid = 0;
        bool passed = false;
        bool step1 = false, step2 = false, step3 = false, step4 = false, step5 = false, step6 = false, step7 = false;
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
               

               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StartTransactionResponse.json")))
                   throw new Exception("Invalid response");

               if (j["idTagInfo"]["status"] == null || j["idTagInfo"]["status"].Value<string>() != "Accepted")
               {
                   Console.WriteLine("Expected Accepted response, got " + j["idTagInfo"]["status"].Value<string>());
                   throw new Exception("Invalid response");
               }
               transid = j["transactionId"].Value<int>();

               step2 = true;

           }
           else if (!step3)
           {

               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");
                
                step3 = true;
           }
           else if (!step4)
           {
               
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");
                
                step4 = true;
           }
           else if (!step5)
           {
               
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StopTransactionResponse.json")))
                   throw new Exception("Invalid response");
                
                step5 = true;
           }
           else if (!step6)
           {
               
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");

                step6 = true;
           }
           else if (!step7)
           {
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");

                step7 = true;
                passed = true;
           }
       };

        charger.SendStatusNotification(status: "Preparing");

        while (!step1)
        Thread.Sleep(1000);

        charger.SendStartTransaction();

        while (!step2)
        Thread.Sleep(1000);

        charger.SendStatusNotification(status: "Charging");

        while (!step3)
        Thread.Sleep(1000);

        charger.SendStatusNotification(status: "SuspendedEV");

        while (!step4)
        Thread.Sleep(1000);

        charger.SendStopTransaction(transid.ToString());

        while (!step5)
        Thread.Sleep(1000);

        charger.SendStatusNotification(status: "Finishing");

        while (!step6)
        Thread.Sleep(1000);

        charger.SendStatusNotification();

        while (!step7)
        Thread.Sleep(1000);

        return passed;
    }
}