using System;
using WebSocketSharp;
using Newtonsoft.Json.Linq;

namespace ocpp.Scenarios;

public class TC_064_CSMS : IScenario
{
    public string[] Dependencies { get { return ["DataTransfer"]; } }

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

           if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/DataTransferResponse.json")))
               throw new Exception("Invalid response");

           if (j["status"] == null ||
               (j["status"].Value<string>() != "Accepted" &&
               j["status"].Value<string>() != "Rejected" &&
               j["status"].Value<string>() != "UnknownMessageId" &&
               j["status"].Value<string>() != "UnknownVendorId"))

               throw new Exception("Invalid response");

           if (j["status"].Value<string>() == "Accepted")
               Console.WriteLine("\nWARNING: DataTransfer Response ACCEPTED");

           passed = true;
       };

        charger.SendDataTransfer();
        Thread.Sleep(1000);


        return passed;
    }

}
