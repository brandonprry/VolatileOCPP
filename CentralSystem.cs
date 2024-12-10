using System;
using ocpp.Scenarios;

namespace ocpp;

public class CentralSystem : System
{
    List<IScenario> _scenarios;
    public CentralSystem(string url, string protocol)
    : base(url, protocol)
    {
        _scenarios = new List<IScenario>();

        _scenarios.Add(new TC_001_CSMS());
        _scenarios.Add(new TC_003_CSMS());
        _scenarios.Add(new TC_004_1_CSMS());
        _scenarios.Add(new TC_064_CSMS());
    }
   

    public List<IScenario> Scenarios { get { return _scenarios; }}

    public void RunScenarios()
    {
        foreach (IScenario s in _scenarios)
        {
            s.RunScenario(URL, Protocol);
        }
    }

}
