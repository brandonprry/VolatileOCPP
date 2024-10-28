using System;
using WebSocketSharp;
using Newtonsoft.Json.Linq;

namespace ocpp.Scenarios;

public class TC_004_1_CSMS
: IScenario
{
    public bool RunScenario(string url, string protocol)
    {

        using var ws = new WebSocket(url, protocol);
        ws.Connect();

        int i = 1;
        ws.OnMessage += (sender, e) =>
       {
           JArray a = JArray.Parse(e.Data);
           JObject? j = a[2] as JObject;

           if (j == null)
               return;

           if (i == 1)
           {
               i++;

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

           }
           else if (i == 3)
           {

           }
       };

        ws.Send("  [2,\"9b25cbb0-c016-41e7-baa0-e796a9565c11\",\"StatusNotification\",{\"connectorId\":1,\"errorCode\":\"NoError\",\"status\":\"Preparing\"}]");
        Thread.Sleep(1000);

        ws.Send("[2,\"dddb2599-d678-4ff8-bf38-a230390a1200\",\"StartTransaction\",{\"connectorId\":1,\"idTag\":\"volatileocpp\",\"meterStart\":42,\"timestamp\":\"2024-10-27T19:10:11Z\"}]");
        Thread.Sleep(1000);

        ws.Send("  [2,\"9b25cbb0-c016-41e7-baa0-e796a9565c11\",\"StatusNotification\",{\"connectorId\":1,\"errorCode\":\"NoError\",\"status\":\"Charging\"}]");
        Thread.Sleep(1000);



        return false;
    }

}
