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

        
        bool passed = false;
        bool step1 = false;
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

            step1 = true;
           passed = true;
       };

        charger.SendAuthorize("NotARealID");

        while (!step1)
        Thread.Sleep(1000);

        return passed;
    }
}
