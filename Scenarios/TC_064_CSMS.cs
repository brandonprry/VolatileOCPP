using System;
using WebSocketSharp;
using Newtonsoft.Json.Linq;

namespace ocpp.Scenarios;

public class TC_064_CSMS : IScenario
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

           if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/DataTransferResponse.json")))
               throw new Exception("Invalid response");

           if (j["status"] == null ||
               (j["status"].Value<string>() != "Accepted" &&
               j["status"].Value<string>() != "Rejected" &&
               j["status"].Value<string>() != "UnknownMessageId" &&
               j["status"].Value<string>() != "UnknownVendorId"))
               
                    throw new Exception("Invalid response");

            if ( j["status"].Value<string>() == "Accepted")
            Console.WriteLine("WARNING: DataTransfer Response ACCEPTED");
       };

        ws.Send(" [2, \"29e7a835-6ff6-4cf8-90e6-5d51182f8fde\", \"DataTransfer\", {\"vendorId\": \"Radboud\", \"messageId\": \"No-Idea\", \"data\": \"There should be some data here\"}]");
        Thread.Sleep(1000);




        return false;
    }

}