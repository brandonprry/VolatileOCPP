// See https://aka.ms/new-console-template for more information
using System;
using WebSocketSharp;

public class Program
{
    public static void Main(string[] args)
    {
        using (var ws = new WebSocket ("ws://Brandons-MBP.attlocal.net:8080")) {
        ws.OnMessage += (sender, e) =>
                          Console.WriteLine ("Laputa says: " + e.Data);

        ws.Connect ();
        ws.Send ("henlo");
        Console.ReadKey (true);    
        }
    }
}