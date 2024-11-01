using System;
using WebSocketSharp;
using Newtonsoft.Json.Linq;
using ocpp.Scenarios;

namespace ocpp;

public abstract class System
{
    string _url = string.Empty;
    string _protocol = string.Empty;
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
    string currentMethod = string.Empty;
    
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
        };

        ws.Connect();

        Socket = ws;
    }

    public string[]? SupportedMethods { get; set; }

    public string[]? UnsupportedMethods { get; set; }

    public string URL { get { return _url; } }

    public string Protocol { get { return _protocol; } }

    public WebSocket Socket { get; protected set; }

    public void SendBootNotification(string chargePointVendor = "volatileocpp Vendor", string chargePointModel = "volatileocpp Model")
    {
        Socket.Send("[2,\"852a4cb2-0e20-46f8-bc29-c5ab3cb182c7\",\"BootNotification\",{\"chargePointVendor\":\"" + chargePointVendor + "\",\"chargePointModel\":\"" + chargePointModel + "\"}]");
    }

    public void SendStatusNotification(string connectorId = "0", string errorCode = "NoError", string status = "Available")
    {
        Socket.Send("[2,\"9b25cbb0-c016-41e7-baa0-e796a9565c11\",\"StatusNotification\",{\"connectorId\":\"" + connectorId + "\",\"errorCode\":\"" + errorCode + "\",\"status\":\"" + status + "\"}]");
    }

    public void SendHeartbeat()
    {
        Socket.Send("[2, \"a187bcd6-4042-4a82-b6d4-b4c55d2f2c8b\", \"Heartbeat\", {}]");
    }

    public void SendAuthorize(string idTag = "volatileocpp")
    {
        Socket.Send("[2,\"8d59bc8c-9884-4d64-82b5-3819d0c58b8a\",\"Authorize\",{\"idTag\":\"" + idTag + "\"}]");
    }

    public void SendStartTransaction(string connectorId = "1", string idTag = "volatileocpp", string meterStart = "42", string timestamp = "2017-10-27T19:10:11Z")
    {
        Socket.Send("[2,\"dddb2599-d678-4ff8-bf38-a230390a1200\",\"StartTransaction\",{\"connectorId\":\"" + connectorId + "\",\"idTag\":\"" + idTag + "\",\"meterStart\":\"" + meterStart + "\",\"timestamp\":\"" + timestamp + "\"}]");
    }

    public void SendStopTransaction(string transid, string idTag = "volatileocpp", string meterStart = "42", string timestamp = "2024-10-27T19:10:11Z", string reason = "Other")
    {
        Socket.Send("[2,\"dddb2599-d678-4ff8-bf38-a230390a1200\",\"StopTransaction\",{\"reason\":\"" + reason + "\",\"transactionId\":\"" + transid + "\",\"idTag\":\"" + idTag + "\",\"meterStart\":\"" + meterStart + "\",\"timestamp\":\"" + timestamp + "\"}]");
    }

    public void SendRemoteStartTransaction(string connectorId = "1", string idTag = "volatileocpp")
    {
        Socket.Send("[2, \"a187bcd6-4042-4a82-b6d4-b4c55d2f2caa\", \"RemoteStartTransaction\", {\"connectorId\": \"" + connectorId + "\", \"idTag\": \"" + idTag + "\"}],");
    }

    public void SendDataTransfer(string vendorId = "volatileocpp", string messageId = "MessageID", string data = "Data")
    {
        Socket.Send(" [2, \"29e7a835-6ff6-4cf8-90e6-5d51182f8fde\", \"DataTransfer\", {\"vendorId\": \"" + vendorId + "\", \"messageId\": \"" + messageId + "\", \"data\": \"" + data + "\"}]");
    }

    public void ParseImplementedMethods(object sender, MessageEventArgs e)
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
                less.Add(currentMethod);
            }
            else
            {
                if (tmp == "InternalError")
                {
                    more.Add(currentMethod);
                    Console.WriteLine("Supports method: " + currentMethod);
                }
            }
        }
        else
        {
            obj = ret[2] as JObject;
            more.Add(currentMethod);
            Console.WriteLine("Supports method: " + currentMethod);
        }
    }
    public void GetMethods()
    {
        Socket.OnMessage += ParseImplementedMethods;

        foreach (string method in rpcMethods)
        {
            currentMethod = method;
            Guid uuid = Guid.NewGuid();
            Socket.Send("[2, \"" + uuid.ToString() + "\", \"" + method + "\", {}]");
            Thread.Sleep(1000);
        }

        this.SupportedMethods = more.ToArray();
        this.UnsupportedMethods = less.ToArray();

        Socket.OnMessage -= ParseImplementedMethods;
    }
}