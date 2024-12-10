using System;
using ocpp.Scenarios;
using WebSocketSharp;

namespace ocpp;

public class Charger : System
{
    public Charger(string url, string protocol) : base(url, protocol)
    {
        ConnectorID = "1";
    }

    public Charger(WebSocket ws) : base(ws)
    {
        ConnectorID = "1";
    }

    public string ConnectorID { get; set; }

    public void Simulate()
    {
        SendAuthorize(IDTag, true);

        SendStatusNotification("1", "NoError", "Available");

        SendStatusNotification("1", "NoError", "Preparing");

        int charge = new Random().Next(5, 30);
        SendStartTransaction(meterStart: charge.ToString(), connectorId: ConnectorID, idTag: IDTag, timestamp: DateTime.UtcNow.ToString("s") + "Z");

        SendStatusNotification("1", "NoError", "Charging");

        int max = new Random().Next(50, 100);
        while (charge < max)
        {
            Console.WriteLine("Charger " + IDTag + " connector " + ConnectorID + " is charging at " + charge + "%");
            charge += 1;
            Thread.Sleep(1000);
        }

        SendStatusNotification("1", "NoError", "Finishing");

        SendStopTransaction(CurrentTransactionID, meterStop: "99", idTag: IDTag, timestamp: DateTime.UtcNow.ToString("s") + "Z");

        SendStatusNotification("1", "NoError", "Available");
    }

    public IScenario[] GetScenarios()
    {
        return
        [

        ];
    }

    public void RunScenarios()
    {
        if (UnsupportedMethods == null)
            GetMethods();

        foreach (IScenario s in GetScenarios())
        {
            bool bad = false;
            foreach (string method in s.Dependencies)
            {
                if (!SupportedMethods.Contains(method))
                {
                    Console.WriteLine("Scenario requires " + method + " but server does not implement it.");
                    bad = true;
                }
            }

            if (bad)
            {
                Console.WriteLine("Skipping incompatible test " + s.GetType().ToString());
                continue;
            }

            Console.WriteLine("Running scenario: " + s.GetType().ToString());

            var task = Task.Run(() => s.RunScenario(URL, Protocol));
            if (task.Wait(TimeSpan.FromSeconds(120)))
            {
                if (task.Result)
                {
                    Console.WriteLine("\t-- PASSED!");
                }
                else
                {
                    Console.WriteLine("\t-- FAILED!");
                }
            }
            else
            {
                Console.WriteLine("\t-- FAILED!");
            }
        }
    }
}
