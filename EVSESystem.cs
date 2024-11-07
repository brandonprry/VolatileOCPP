using WebSocketSharp;
using Newtonsoft.Json.Linq;
using ocpp.Scenarios;

namespace ocpp;

public abstract class EVSESystem
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
            "FormatViolation",
            "PropertyConstraintViolation",
            "OccurenceConstraintViolation",
            "TypeConstraintViolation",
            "GenericError"
    ];

    List<string> less = new List<string>();
    List<string> more = new List<string>();
    string currentMethod = string.Empty;

    public EVSESystem()
    {
    }

    public EVSESystem(WebSocket ws)
    {
        _url = ws.Url.ToString();

        Socket = ws;
    }

    public EVSESystem(string url, string protocol, string username = null, string password = null)
    {
        if (!url.StartsWith("wss://"))
            Console.WriteLine("WARNING: Insecure plaintext communication");

        _url = url;
        _protocol = protocol;

        WebSocket ws = new WebSocket(url, protocol);
       
        if (username != null)
            ws.SetCredentials(username, password, true);

        ws.SetProxy("http://127.0.0.1:8080", null, null);

        ws.OnError += (sender, e) =>
        {
            Console.WriteLine("Error");
        };

        ws.Connect();
        

        Socket = ws;
    }

    public string CurrentTransactionID { get; private set; }

    public string CurrentAuthorizationStatus { get; private set; }

    public string IDTag { get; set; }

    public string[]? SupportedMethods { get; set; }

    public string[]? UnsupportedMethods { get; set; }

    public string URL { get { return _url; } }

    public int HeartbeatInterval { get; set; }

    public string Protocol { get { return _protocol; } }

    public WebSocket Socket { get; protected set; }

        public void GetBootNotificationResult(object sender, MessageEventArgs e)
    {
        JArray a = JArray.Parse(e.Data);
        JObject? j = a[2] as JObject;

        if (!Utility.ValidateJSON(j, File.ReadAllText(Utility.ProjectDirectory + "/v1.6_schemas/schemas/BootNotificationResponse.json")))
            throw new Exception("Invalid response");
        
        if (j["idTagInfo"] != null && j["idTagInfo"]["status"] != null && j["idTagInfo"]["status"].Value<string >() != "Accepted")
            throw new Exception("Invalid response");

        if (j["idTagInfo"] != null && j["idTagInfo"]["status"] != null)
            HeartbeatInterval = j["idTagInfo"]["interval"].Value<int>();

    }

    public void SendBootNotification(string chargePointVendor = "volatileocpp Vendor", string chargePointModel = "volatileocpp Model")
    {
        Socket.OnMessage += GetBootNotificationResult;
        Socket.Send("[2,\""+Guid.NewGuid().ToString()+"\",\"BootNotification\",{\"chargePointVendor\":\"" + chargePointVendor + "\",\"chargePointModel\":\"" + chargePointModel + "\"}]");
        Thread.Sleep(1000);
        Socket.OnMessage -= GetBootNotificationResult;
    }
    public void GetStatusNotificationResult(object sender, MessageEventArgs e)
    {
        JArray a = JArray.Parse(e.Data);
        JObject? j = a[2] as JObject;

        if (!Utility.ValidateJSON(j, File.ReadAllText(Utility.ProjectDirectory + "/v1.6_schemas/schemas/StatusNotificationResponse.json")))
            throw new Exception("Invalid response");
    }
    public void SendStatusNotification(int connectorId = 0, string errorCode = "NoError", string status = "Available")
    {
        Socket.OnMessage += GetStatusNotificationResult;
        Socket.Send("[2,\""+Guid.NewGuid().ToString()+"\",\"StatusNotification\",{\"connectorId\":" + connectorId + ",\"errorCode\":\"" + errorCode + "\",\"status\":\"" + status + "\"}]");
        Thread.Sleep(1000);
        Socket.OnMessage -= GetStatusNotificationResult;
    }

    public void GetHeartbeatResult(object sender, MessageEventArgs e)
    {
        JArray a = JArray.Parse(e.Data);
        JObject? j = a[2] as JObject;

        if (!Utility.ValidateJSON(j, File.ReadAllText(Utility.ProjectDirectory + "/v1.6_schemas/schemas/HeartbeatResponse.json")))
            throw new Exception("Invalid response");
    }

    public void SendHeartbeat()
    {
        Socket.OnMessage += GetHeartbeatResult;
        Socket.Send("[2, \""+Guid.NewGuid().ToString()+"\", \"Heartbeat\", {}]");
        Thread.Sleep(1000);
        Socket.OnMessage -= GetHeartbeatResult;
    }

    public void GetAuthorizeResult(object sender, MessageEventArgs e)
    {
        JArray a = JArray.Parse(e.Data);
        JObject? j = a[2] as JObject;

        if (!Utility.ValidateJSON(j, File.ReadAllText(Utility.ProjectDirectory + "/v1.6_schemas/schemas/AuthorizeResponse.json")))
            throw new Exception("Invalid response");

        if (j["idTagInfo"] != null && j["idTagInfo"]["status"] != null)
            CurrentAuthorizationStatus = j["idTagInfo"]["status"].Value<string>();

    }

    public void SendAuthorize(string idTag = "volatileocpp", bool verify = false)
    {
        CurrentAuthorizationStatus = "Waiting";
        IDTag = idTag;

        Socket.OnMessage += GetAuthorizeResult;
        Socket.Send("[2,\""+Guid.NewGuid().ToString()+"\",\"Authorize\",{\"idTag\":\"" + idTag + "\"}]");
        Thread.Sleep(1000);

        if (verify)
        {
            while (CurrentAuthorizationStatus != "Accepted")
            {
                Console.WriteLine("ID Tag " + IDTag + " is not authorized. Currenly the credentials are " + CurrentAuthorizationStatus);
                Thread.Sleep(1000);

                Socket.Send("[2,\""+Guid.NewGuid().ToString()+"\",\"Authorize\",{\"idTag\":\"" + idTag + "\"}]");
            }
        }

        Socket.OnMessage -= GetAuthorizeResult;

    }

    public void GetStartTransactionResult(object sender, MessageEventArgs e)
    {
        JArray a = JArray.Parse(e.Data);
        JObject? j = a[2] as JObject;

        if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StartTransactionResponse.json")))
            throw new Exception("Invalid response");

        if (j["idTagInfo"] == null ||
            j["idTagInfo"]["status"] == null ||
            j["idTagInfo"]["status"].Value<string>() != "Accepted")
            throw new Exception("Invalid response");

        CurrentTransactionID = j["transactionId"].Value<string>();

    }
    public void SendStartTransaction(int connectorId = 1, string idTag = "volatileocpp", string meterStart = "42", string timestamp = "2017-10-27T19:10:11Z")
    {
        Socket.OnMessage += GetStartTransactionResult;
        Socket.Send("[2,\""+Guid.NewGuid().ToString()+"\",\"StartTransaction\",{\"connectorId\":" + connectorId + ",\"idTag\":\"" + idTag + "\",\"meterStart\":\"" + meterStart + "\",\"timestamp\":\"" + timestamp + "\"}]");
        Thread.Sleep(1000);
        Socket.OnMessage -= GetStartTransactionResult;
    }

    public void GetStopTransactionResult(object sender, MessageEventArgs e)
    {
        JArray a = JArray.Parse(e.Data);
        JObject? j = a[2] as JObject;

        if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/StopTransactionResponse.json")))
            throw new Exception("Invalid response");


    }

    public void SendStopTransaction(string transid, string idTag = "volatileocpp", string meterStop = "42", string timestamp = "2024-10-27T19:10:11Z", string reason = "Other")
    {
        Socket.OnMessage += GetStopTransactionResult;
        Socket.Send("[2,\""+Guid.NewGuid().ToString()+"\",\"StopTransaction\",{\"reason\":\"" + reason + "\",\"transactionId\":\"" + transid + "\",\"idTag\":\"" + idTag + "\",\"meterStop\":\"" + meterStop + "\",\"timestamp\":\"" + timestamp + "\"}]");
        Thread.Sleep(1000);
        Socket.OnMessage -= GetStopTransactionResult;
    }

    public void SendRemoteStartTransaction(int connectorId = 0, string idTag = "volatileocpp")
    {
        Socket.Send("[2, \""+Guid.NewGuid().ToString()+"\", \"RemoteStartTransaction\", {\"connectorId\": " + connectorId + ", \"idTag\": \"" + idTag + "\"}],");
    }

    public void SendDataTransfer(string vendorId = "volatileocpp", string messageId = "MessageID", string data = "Data")
    {
        Socket.Send(" [2, \""+Guid.NewGuid().ToString()+"\", \"DataTransfer\", {\"vendorId\": \"" + vendorId + "\", \"messageId\": \"" + messageId + "\", \"data\": \"" + data + "\"}]");
    }

    public void GetSendMeterValuesResult(object sender, MessageEventArgs e)
    {
        JArray a = JArray.Parse(e.Data);
        JObject? j = a[2] as JObject;

        if (!Utility.ValidateJSON(j, File.ReadAllText("/Users/bperry/projects/ocpp/v1.6_schemas/schemas/MeterValuesResponse.json")))
            throw new Exception("Invalid response");


    }
    public void SendMeterValues(int connectorId = 0, string transactionId = "1", string timestamp = "2024-10-27T19:10:11Z", string value ="42", string context = "Sample.Periodic", string measurand = "Energy.Active.Import.Register", string unit = "kWh")
    {
        Socket.OnMessage += GetSendMeterValuesResult;
        Socket.Send("    [2, \""+Guid.NewGuid().ToString()+"\", \"MeterValues\", {\"connectorId\":"+connectorId+", \"transactionId\": \""+transactionId+"\", \"meterValue\": [{\"timestamp\": \""+timestamp+"\", \"sampledValue\": [{\"value\": \""+value+"\", \"context\": \""+context+"\", \"format\": \"Raw\", \"measurand\": \""+measurand+"\", \"phase\": \"L1\", \"location\":\"Outlet\", \"unit\": \""+unit+"\"}]}]}],");
        Thread.Sleep(1000);
        Socket.OnMessage -= GetSendMeterValuesResult;
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
                if (tmp == "InternalError" || tmp == "FormatViolation")
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