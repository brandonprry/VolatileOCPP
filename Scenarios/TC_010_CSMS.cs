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
        int i = 1;
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
            } else if (i == 2)
            {
                i++;
                if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/RemoteStartTransactionResponse.json")))
                   throw new Exception("Invalid response");
            } else if (i == 3)
            {
                i++;
                if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/AuthorizeResponse.json")))
                   throw new Exception("Invalid response");
            } else if (i == 4)
            {
                i++;
                if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StartTransactionResponse.json")))
                   throw new Exception("Invalid response");
            } else if (i == 5)
            {
                i++;
                if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");

                passed = true;
            }
       };

        charger.SendStatusNotification(status: "Preparing");
        Thread.Sleep(1000);

        charger.SendRemoteStartTransaction();
        Thread.Sleep(1000);

        charger.SendAuthorize();
        Thread.Sleep(1000);

        charger.SendStartTransaction();
        Thread.Sleep(1000);

        charger.SendStatusNotification(status: "Charging");
        Thread.Sleep(1000);

       return passed;
    }
}