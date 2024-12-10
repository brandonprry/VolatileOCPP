using System;
using WebSocketSharp;

namespace ocpp.Scenarios;

public class TC_001_CS : IScenario
{
    public bool RunScenario(string url, string protocol)
    {
         using (var ws = new WebSocket(url, protocol))
        {
             ws.OnMessage += (sender, e) =>
            {};

        }
        return false;
    }
}
