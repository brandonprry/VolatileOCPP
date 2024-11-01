using System;
using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace ocpp.Scenarios;

public class TC_023_3_CSMS : IScenario
{
    bool step1 = false;
    bool passed = false;
    public string[] Dependencies { get { return ["Authorize"]; } }

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

        if (!Utility.ValidateJSON(j, File.ReadAllText(Utility.ProjectDirectory + "/v1.6_schemas/schemas/AuthorizeResponse.json")))
            throw new Exception("Invalid response");

        if (j["idTagInfo"]["status"] == null ||
            j["idTagInfo"]["status"].Value<string>() != "Blocked")
            throw new Exception("Invalid response");

        step1 = true;
        passed = true;

    }

        public bool RunScenario(string url, string protocol)
    {
        using var ws = new WebSocket(url, protocol);
        ws.Connect();
        return RunScenario(ws);
    }
    public bool RunScenario(WebSocket ws)
    {
        Console.WriteLine("\nConfigure the volatileocpp ID Tag to be blocked then press enter.");
        Console.ReadLine();


        Charger charger = new Charger(ws);
        ws.OnMessage += OnMessage;

        charger.SendAuthorize();

        while (!step1)
            Thread.Sleep(1000);

        ws.OnMessage -= OnMessage;
        return passed;
    }
}
