using System;
using WebSocketSharp;
using Newtonsoft.Json.Linq;
using ocpp.Scenarios;

namespace ocpp;

public abstract class System
{
    public System(string url, string protocol, bool check = false)
    {
        _url = url;
        _protocol = protocol;

        if (check)
        {
            using (var ws = new WebSocket(url, protocol))
            {
                ws.WaitTime = new TimeSpan(0, 0, 60);

                ws.OnError += (sender, e) =>
                {
                    Console.WriteLine("Error");
                    return;
                };

                ws.OnMessage += (sender, e) =>
                {
                    Console.WriteLine("Laputa says: " + e.Data);
                };

                ws.Connect();
                Guid uuid = Guid.NewGuid();

                try
                {
                    ws.Send("[2, \"" + uuid.ToString() + "\", \"Heartbeat\", {}]");
                    Thread.Sleep(1000);
                }
                catch
                {
                    Console.WriteLine("Error");
                    return;
                }

            }
        }
    }

    string _url = string.Empty;
    string _protocol = string.Empty;

    public List<IScenario> Scenarios { get; protected set; }
    public string[]? SupportedMethods { get; set; }

    public string[]? UnsupportedMethods { get; set; }

    public string URL { get { return _url; } }

    public string Protocol { get { return _protocol; } }

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
            using (var ws = new WebSocket(_url, _protocol))
            {
                ws.OnMessage += (sender, e) =>
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

                ws.Connect();
                Guid uuid = Guid.NewGuid();
                ws.Send("[2, \"" + uuid.ToString() + "\", \"" + method + "\", {}]");
                Thread.Sleep(1000);
            }
        }

        this.SupportedMethods = more.ToArray();
        this.UnsupportedMethods = less.ToArray();
        Console.WriteLine("Done");
    }
}
