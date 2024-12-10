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
            new TC_005_1_CSMS(),
            new TC_007_CSMS(),
            new TC_010_CSMS(),
            new TC_023_1_CSMS(),
            new TC_023_2_CSMS(),
            new TC_023_3_CSMS(),
            new TC_024_CSMS(),
            new TC_064_CSMS(),
        ];
    }
   
    public void RunScenarios()
    {
        if (UnsupportedMethods == null)
            GetMethods();
        
        foreach (IScenario s in Scenarios)
        {
            bool bad = false;
            foreach(string method in s.Dependencies)
                if (!SupportedMethods.Contains(method))
                    bad = true;
            
            if (bad){
                Console.WriteLine("Skipping incompatible test " + s.GetType().ToString());
                continue;
            }
                
            Console.Write("Running scenario: " + s.GetType().ToString());
            
             if (s.RunScenario(URL, Protocol)){
               Console.WriteLine("\t-- PASSED!");
            }
            else {
                Console.WriteLine("\t-- FAILED!");
            }
        }
    }

}
