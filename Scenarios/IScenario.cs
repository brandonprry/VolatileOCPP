using System;
using System.Runtime.Serialization;
using WebSocketSharp;

namespace ocpp.Scenarios;

public interface IScenario
{
    public bool RunScenario(string url, string protocol);

    public bool RunScenario(WebSocket ws);

    public bool DependsOn(string method);

    public string[] Dependencies { get; }

   public void OnMessage (object sender, MessageEventArgs e);

}
