using System;
using WebSocketSharp;
using Newtonsoft.Json.Linq;


namespace ocpp.Scenarios;

public class TC_010_CSMS : IScenario
{
    public string[] Dependencies { get { return ["StatusNotification", "StopTransaction", "Authorize", "RemoteStartTransaction"];}}

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
        bool step1 = false, step2 = false, step3 = false, step4 = false, step5 = false;
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
            } else if (!step2)
            {
                
                if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/RemoteStartTransactionResponse.json")))
                   throw new Exception("Invalid response");

                step2 = true;
            } else if (!step3)
            {
                
                if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/AuthorizeResponse.json")))
                   throw new Exception("Invalid response");

                step3 = true;
            } else if (!step4)
            {
                
                if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StartTransactionResponse.json")))
                   throw new Exception("Invalid response");

                step4 = true;
            } else if (!step5)
            {
                
                if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");

                step5 = true;
                passed = true;
            }
       };

        charger.SendStatusNotification(status: "Preparing");

        while (!step1)
        Thread.Sleep(1000);

        charger.SendRemoteStartTransaction();

        while (!step2)
        Thread.Sleep(1000);

        charger.SendAuthorize();

        while (!step3)
        Thread.Sleep(1000);

        charger.SendStartTransaction();

        while (!step4)
        Thread.Sleep(1000);

        charger.SendStatusNotification(status: "Charging");

        while (!step5)
        Thread.Sleep(1000);

       return passed;
    }
}