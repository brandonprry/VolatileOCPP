using System;
using WebSocketSharp;
using Newtonsoft.Json.Linq;
using ocpp.Scenarios;

namespace ocpp;

public abstract class System
{
    public System()
    {
    }

    public System(WebSocket ws)
    {
        _url = ws.Url.ToString();

        Socket = ws;       
    }


    public System(string url, string protocol)
    {
        if (!url.StartsWith("wss://"))
            Console.WriteLine("WARNING: Insecure plaintext communication");

        _url = url;
        _protocol = protocol;

        WebSocket ws = new WebSocket(url, protocol);
        ws.WaitTime = new TimeSpan(0, 0, 60);

        ws.OnError += (sender, e) =>
        {
            Console.WriteLine("Error");
            return;
        };

        //ws.OnMessage += (sender, e) =>
        //{
        //    Console.WriteLine("Laputa says: " + e.Data);
        //};

        ws.Connect();
       //ws.

        Socket = ws;

        
    }

    string _url = string.Empty;
    string _protocol = string.Empty;
    public string[]? SupportedMethods { get; set; }

    public string[]? UnsupportedMethods { get; set; }

    public string URL { get { return _url; } }

    public string Protocol { get { return _protocol; } }

    public WebSocket Socket { get; protected set; }

    public void GetMethods()
    {
        string[] rpcMethods = Utility.Methods;

        string[] validResponses = [
"NotImplemented",
"NotSupported",
"InternalError",
"ProtocolError",
"SecurityError",
"FormationViolation",
"PropertyConstraintViolation",
"OccurenceConstraintViolation",
"TypeConstraintViolation",
"GenericError"
];

        List<string> less = new List<string>();
        List<string> more = new List<string>();
        foreach (string method in rpcMethods)
        {

            Socket = new WebSocket(_url, _protocol);
            Socket.Connect();

            Socket.OnMessage += (sender, e) =>
            {
                JToken[] ret = JArray.Parse(e.Data).ToArray<JToken>();

                string? tmp = string.Empty;
                JObject? obj;

                if (ret[2].Type == JTokenType.String)
                {
                    tmp = ret[2].Value<string>();

                    if (!validResponses.Contains(tmp))
                        throw new Exception(tmp);

                    if (tmp == "NotImplemented" || tmp == "NotSupported")
                    {
                        less.Add(method);
                    }
                    else
                    {
                        if (tmp == "InternalError")
                        {
                            more.Add(method);
                            Console.WriteLine("Supports method: " + method);
                        }
                    }
                }
                else
                {
                    obj = ret[2] as JObject;
                    more.Add(method);
                    Console.WriteLine("Supports method: " + method);
                }

                //Console.WriteLine("Laputa says: " + method);
            };

            Guid uuid = Guid.NewGuid();
            Socket.Send("[2, \"" + uuid.ToString() + "\", \"" + method + "\", {}]");
            Thread.Sleep(1000);


            this.SupportedMethods = more.ToArray();
            this.UnsupportedMethods = less.ToArray();
            //Console.WriteLine("Done");
        }
    }
}