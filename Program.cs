// See https://aka.ms/new-console-template for more information
using System;
using WebSocketSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ocpp.Scenarios;
using ocpp;

public class Program
{
    public static void Main(string[] args)
    {
        string url = "ws://localhost:8180/steve/websocket/CentralSystemService/1";
        string protocol = "ocpp1.6";

        CentralSystem s = new CentralSystem(url, protocol);

        //s.GetMethods();
        s.RunScenarios();

        Console.WriteLine("Done.");
    }
}
