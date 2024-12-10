using System;
using WebSocketSharp;
using Newtonsoft.Json.Linq;

namespace ocpp.Scenarios;

public class TC_003_CSMS : IScenario
{
    public bool RunScenario(string url, string protocol)
    {
         using (var ws = new WebSocket(url, protocol))
        {
            ws.Connect();

             int i = 1;
             ws.OnMessage += (sender, e) =>
            {
                
                JArray a = JArray.Parse(e.Data);
                JObject j = a[2] as JObject;
                if (i == 1)
                {
                    if (!Utility.ValidateJSON(j, System.IO.File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                        throw new Exception("Invalid response");

                    i++;
                }
                else if (i ==2)
                {       
                    if (!Utility.ValidateJSON(j, System.IO.File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/AuthorizeResponse.json")))
                        throw new Exception("Invalid repsonse");

                    i++;
                }
                else if (i ==3)
                {       
                    if (!Utility.ValidateJSON(j, System.IO.File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StartTransactionResponse.json")))
                        throw new Exception("Invalid repsonse");

                    i++;
                }
                else if (i == 4)
                {                   
                    if (!Utility.ValidateJSON(j, System.IO.File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                        throw new Exception("Invalid response");
                }
            };

            ws.Send("[2,\"9b25cbb0-c016-41e7-baa0-e796a9565c11\",\"StatusNotification\",{\"connectorId\":1,\"errorCode\":\"NoError\",\"status\":\"Preparing\"}]");
Thread.Sleep(1000);
            ws.Send("[2,\"8d59bc8c-9884-4d64-82b5-3819d0c58b8a\",\"Authorize\",{\"idTag\":\"Authorize\"}]");
Thread.Sleep(1000);
            ws.Send("[2,\"dddb2599-d678-4ff8-bf38-a230390a1200\",\"StartTransaction\",{\"connectorId\":1,\"idTag\":\"some id\",\"meterStart\":42,\"timestamp\":\"2017-10-27T19:10:11Z\"}]");
Thread.Sleep(1000);
            ws.Send("[2,\"9b25cbb0-c016-41e7-baa0-e796a9565c11\",\"StatusNotification\",{\"connectorId\":1,\"errorCode\":\"NoError\",\"status\":\"Charging\"}]");
Thread.Sleep(1000);


        }
        return false;
    }
}
