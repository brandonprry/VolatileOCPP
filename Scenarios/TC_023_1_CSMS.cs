using System;
using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace ocpp.Scenarios;

public class TC_023_1_CSMS : IScenario
{
    public string[] Dependencies { get { return ["Authorize"]; } }

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

           if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/AuthorizeResponse.json")))
               throw new Exception("Invalid response");

           if (j["idTagInfo"]["status"] == null ||
               j["idTagInfo"]["status"].Value<string>() != "Invalid")
               throw new Exception("Invalid response");

           passed = true;
       };

        charger.SendAuthorize("NotARealID");
        Thread.Sleep(1000);

        return passed;
    }
}
