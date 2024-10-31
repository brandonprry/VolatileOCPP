using System;
using WebSocketSharp;
using Newtonsoft.Json.Linq;


namespace ocpp.Scenarios;

public class TC_039_CSMS : IScenario
{
    public string[] Dependencies { get { return ["StartTransaction", "StopTransaction"]; } }

    public bool DependsOn(string method)
    {
        return Dependencies.Contains(method);
    }
    public bool RunScenario(string url, string protocol)
    {

        using var ws = new WebSocket(url, protocol);
        ws.Connect();

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
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StartTransactionResponse.json")))
                   throw new Exception("Invalid response");

               if (j["idTagInfo"] == null ||
                   j["idTagInfo"]["status"] == null ||
                   j["idTagInfo"]["status"].Value<string>() != "Accepted")
                   throw new Exception("Invalid response");

               transid = j["transactionId"].Value<int>();
           }
           else if (i == 2)
           {
               i++;
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StopTransactionResponse.json")))
                   throw new Exception("Invalid response");

               passed = true;
           }
       };

        ws.Send("[2,\"dddb2599-d678-4ff8-bf38-a230390a1200\",\"StartTransaction\",{\"connectorId\":1,\"idTag\":\"volatileocpp\",\"meterStart\":42,\"timestamp\":\"2017-10-27T19:10:11Z\"}]");
        Thread.Sleep(1000);

        ws.Send("[2,\"29e7a835-6ff6-4cf8-90e6-5d51182f8fdb\",\"StopTransaction\",{\"idTag\":\"volatileocpp\", \"reason\":\"Local\", \"meterStop\":\"41\",\"timestamp\":\"2017-10-27T19:10:11Z\",\"transactionId\":\"" + transid + "\"}]");
        Thread.Sleep(1000);

        return passed;
    }
}