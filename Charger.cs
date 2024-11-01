using System;
using ocpp.Scenarios;
using WebSocketSharp;

namespace ocpp;

public class Charger : System
{
    public Charger(string url, string protocol) : base(url, protocol)
    {
    }

    public Charger(WebSocket ws) : base(ws)
    {
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
