using System;
using ocpp.Scenarios;

namespace ocpp;

public class CentralSystem : System
{
    public CentralSystem(string url, string protocol)
    : base(url, protocol)
    {
        Scenarios =
        [
            new TC_001_CSMS(),
            new TC_003_CSMS(),
            new TC_004_1_CSMS(),
            new TC_004_2_CSMS(),
            new TC_064_CSMS(),
        ];
    }
   
    public void RunScenarios()
    {
        if (UnsupportedMethods == null)
            GetMethods();
        
        foreach (IScenario s in Scenarios)
        {
            foreach(string method in s.Dependencies)
                if (!SupportedMethods.Contains(method))
                    continue;
    
            s.RunScenario(URL, Protocol);
        }
    }

}
