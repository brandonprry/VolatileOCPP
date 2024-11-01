using System;
using WebSocketSharp;
using Newtonsoft.Json.Linq;


namespace ocpp.Scenarios;

public class TC_037_1_CSMS : IScenario
{
    bool step1 = false, step2 = false;
    bool passed = false;
    public string[] Dependencies { get { return ["StatusNotification", "StartTransaction"]; } }

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
            if (!Utility.ValidateJSON(j, File.ReadAllText(Utility.ProjectDirectory + "/v1.6_schemas/schemas/StartTransactionResponse.json")))
                throw new Exception("Invalid response");

            if (j["idTagInfo"] == null ||
                j["idTagInfo"]["status"] == null ||
                j["idTagInfo"]["status"].Value<string>() != "Accepted")
                throw new Exception("Invalid response");

            step1 = true;
        }
        else if (!step2)
        {
            if (!Utility.ValidateJSON(j, File.ReadAllText(Utility.ProjectDirectory + "/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                throw new Exception("Invalid response");

            step2 = true;
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

        charger.SendStartTransaction();

        while (!step1)
            Thread.Sleep(1000);

        charger.SendStatusNotification(status: "Charging");

        while (!step2)
            Thread.Sleep(1000);

        ws.OnMessage -= OnMessage;
        return passed;
    }
}