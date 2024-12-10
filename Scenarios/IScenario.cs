using System;

namespace ocpp.Scenarios;

public interface IScenario
{
    public bool RunScenario(string url, string protocol);

    public bool DependsOn(string method);

    public string[] Dependencies { get; }

}
