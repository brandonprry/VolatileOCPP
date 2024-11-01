using System;
using WebSocketSharp.Server;
using ocpp.Scenarios;
using WebSocketSharp;
using System.Threading.Tasks;


namespace ocpp;

public class CentralSystem : System
{
    WebSocketServer? server = null;
    public CentralSystem(int port) : base()
    {
        server = new WebSocketServer(port);
        server.AddWebSocketService<CSMSSimulator>("/ocpp_csms_simulator");
        server.Start();
    }

    public CentralSystem(WebSocket ws) : base(ws)
    {

    }

    public CentralSystem(string url, string protocol)
    : base(url, protocol)
    {

    }

    public IScenario[] GetScenarios()
    {
        return
        [
            new TC_001_CSMS(),
            new TC_003_CSMS(),
            new TC_004_1_CSMS(),
            new TC_004_2_CSMS(),
            new TC_005_1_CSMS(),
            new TC_007_CSMS(),
            new TC_010_CSMS(),
            new TC_023_1_CSMS(),
            new TC_023_2_CSMS(),
            new TC_023_3_CSMS(),
            new TC_024_CSMS(),
            new TC_032_1_CSMS(),
            new TC_037_1_CSMS(),
            new TC_037_3_CSMS(),
            new TC_039_CSMS(),
            new TC_064_CSMS(),
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
