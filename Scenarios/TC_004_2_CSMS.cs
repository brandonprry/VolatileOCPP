using System;

using WebSocketSharp;
using Newtonsoft.Json.Linq;

namespace ocpp.Scenarios;

public class TC_004_2_CSMS 
: IScenario
{
        public string[] Dependencies { get { return ["Authorize", "StatusNotification"];}}

    public bool DependsOn(string method)
    {
        return Dependencies.Contains(method);
    }
    public bool RunScenario(string url, string protocol)
    {
        using var ws = new WebSocket(url, protocol);
        ws.Connect();

        int i = 1;
        bool timedOut = false;
        ws.OnMessage += (sender, e) =>
       {
           JArray a = JArray.Parse(e.Data);
           JObject? j = a[2] as JObject;

           if (j == null)
               return;  

               if (i == 1)
               {
                i++;
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/AuthorizeResponse.json")))
                   throw new Exception("Invalid response");

               if (j["idTagInfo"] == null ||
                   j["idTagInfo"]["status"] == null ||
                   j["idTagInfo"]["status"].Value<string>() != "Accepted")
                   throw new Exception("Invalid response");
               }
               else if (i == 2)
               {
               
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");
               }
               else if (i == 3)
               {
                
               if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StatusNotificationResponse.json")))
                   throw new Exception("Invalid response");
               }
       };


        ws.Send("[2,\"8d59bc8c-9884-4d64-82b5-3819d0c58b8a\",\"Authorize\",{\"idTag\":\"volatileocpp\"}]");
        Thread.Sleep(1000);

        
        ws.Send("  [2,\"9b25cbb0-c016-41e7-baa0-e796a9565c11\",\"StatusNotification\",{\"connectorId\":1,\"errorCode\":\"NoError\",\"status\":\"Preparing\"}]");
        Thread.Sleep(1000);

        Thread.Sleep(1000*60); //timeout?

        ws.Send("  [2,\"9b25cbb0-c016-41e7-baa0-e796a9565c11\",\"StatusNotification\",{\"connectorId\":1,\"errorCode\":\"NoError\",\"status\":\"Available\"}]");
        Thread.Sleep(1000);

        return false;
    }

    


}
