using System;
using WebSocketSharp;
using Newtonsoft.Json.Linq;

namespace ocpp.Scenarios;

public class TC_003_CSMS : IScenario
{

    bool passed = false;
    bool step1 = false, step2 = false, step3 = false, step4 = false;
    public string[] Dependencies { get { return ["StartTransaction", "StatusNotification", "Authorize"]; } }

    public bool DependsOn(string method)
    {
        return Dependencies.Contains(method);
    }
    public void OnMessage(object sender, MessageEventArgs e)
    {
        JArray a = JArray.Parse(e.Data);
        JObject? j = a[2] as JObject;

        if (j == null)
            return;

        if (!step1)
        {

            if (!Utility.ValidateJSON(j, File.ReadAllText(Utility.ProjectDirectory + "/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                throw new Exception("Invalid response");

            step1 = true;
        }
        else if (!step2)
        {

            if (!Utility.ValidateJSON(j, File.ReadAllText(Utility.ProjectDirectory + "/v1.6_schemas/schemas/AuthorizeResponse.json")))
                throw new Exception("Invalid response");

            if (j["idTagInfo"] == null ||
                j["idTagInfo"]["status"] == null ||
                j["idTagInfo"]["status"].Value<string>() != "Accepted")
                throw new Exception("Invalid response");

            step2 = true;
        }
        else if (!step3)
        {

            if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StartTransactionResponse.json")))
                throw new Exception("Invalid response");

            if (j["idTagInfo"] == null ||
                j["idTagInfo"]["status"] == null ||
                j["idTagInfo"]["status"].Value<string>() != "Accepted")
                throw new Exception("Invalid response");

            step3 = true;
        }
        else if (!step4)
        {
            if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                throw new Exception("Invalid response");

            step4 = true;
            passed = true;
        }
    }

    public bool RunScenario(string url, string protocol)
    {
        using var ws = new WebSocket(url, protocol);

        ws.Connect();

        return RunScenario(ws);

    }
    public bool RunScenario(WebSocket ws)
    {
        Charger charger = new Charger(ws);

        ws.OnMessage += OnMessage;

        charger.SendStatusNotification(0, "NoError", "Preparing");

        while (!step1)
            Thread.Sleep(1000);

        charger.SendAuthorize();

        while (!step2)
            Thread.Sleep(1000);

        charger.SendStartTransaction();

        while (!step3)
            Thread.Sleep(1000);

        charger.SendStatusNotification(0, "NoError", "Charging");

        while (!step4)
            Thread.Sleep(1000);

        ws.OnMessage -= OnMessage;

        return passed;
    }
}
