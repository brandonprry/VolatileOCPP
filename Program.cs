// See https://aka.ms/new-console-template for more information
using System;
using System.Net;
using ocpp;

public class Program
{
    public static void Main(string[] args)
    {
        ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        
        string url = "ws://localhost:8081/";
        string protocol = "ocpp2.0.1";

        CentralSystem s = new CentralSystem(9090, false);
        
        while (true)
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
        }

       /* List<Task> tasks = new List<Task>();
        for (int i = 1; i< 11; i++)
        {
            Charger c = new Charger(url, protocol);
            c.ConnectorID = i.ToString();
            c.IDTag = "volatileocpp";
            tasks.Add(Task.Run(c.Simulate));
        }

        foreach (Task t in tasks)
            t.Wait();*/

        //CentralSystem s = new CentralSystem(url, protocol);

        //s.RunScenarios();

        Console.WriteLine("Done.");
    }
}
