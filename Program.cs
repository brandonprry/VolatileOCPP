// See https://aka.ms/new-console-template for more information
using System;
using WebSocketSharp;
using Newtonsoft.Json;

public class Program
{
    public static void Main(string[] args)
    {
        using (var ws = new WebSocket ("ws://localhost:8180/steve/websocket/CentralSystemService/1", "ocpp1.6")) {
            ws.OnMessage += (sender, e) =>
                            Console.WriteLine ("Laputa says: " + e.Data);

            ws.Connect ();
            ws.Send ("[2, \"a187bcd6-4042-4a82-b6d4-b4c14025d2f2c8b\", \"Heartbeat\", {}]");
            Thread.Sleep(5);
        }
    }
}