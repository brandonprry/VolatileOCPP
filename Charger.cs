using System;
using WebSocketSharp;

namespace ocpp;

public class Charger : System
{
    public Charger(string url, string protocol) : base()
    {
        WebSocket ws = new WebSocket(url, protocol);
        ws.Connect();

        Socket = ws;
    }

    public Charger(WebSocket ws) : base(ws)
    {
        this.Socket = ws;
    }

    internal void SendBootNotification(string chargePointVendor ="volatileocpp Vendor", string chargePointModel="volatileocpp Model")
    {
        Socket.Send("[2,\"852a4cb2-0e20-46f8-bc29-c5ab3cb182c7\",\"BootNotification\",{\"chargePointVendor\":\""+chargePointVendor+"\",\"chargePointModel\":\""+chargePointModel+"\"}]");
    }

    internal void SendStatusNotification(string connectorId = "0", string errorCode = "NoError", string status = "Available")
    {
        Socket.Send("[2,\"9b25cbb0-c016-41e7-baa0-e796a9565c11\",\"StatusNotification\",{\"connectorId\":\""+connectorId+"\",\"errorCode\":\""+errorCode+"\",\"status\":\""+status+"\"}]");
    }

    internal void SendHeartbeat()
    {
        Socket.Send("[2, \"a187bcd6-4042-4a82-b6d4-b4c55d2f2c8b\", \"Heartbeat\", {}]");
    }

    internal void SendAuthorize(string idTag = "volatileocpp")
    {
        Socket.Send("[2,\"8d59bc8c-9884-4d64-82b5-3819d0c58b8a\",\"Authorize\",{\"idTag\":\""+idTag+"\"}]");   
    }

    internal void SendStartTransaction(string connectorId = "1", string idTag = "volatileocpp", string meterStart = "42", string timestamp = "2017-10-27T19:10:11Z")
    {
        Socket.Send("[2,\"dddb2599-d678-4ff8-bf38-a230390a1200\",\"StartTransaction\",{\"connectorId\":\""+connectorId+"\",\"idTag\":\""+idTag+"\",\"meterStart\":\""+meterStart+"\",\"timestamp\":\""+timestamp+"\"}]");
    }

    internal void SendStopTransaction(string transid, string idTag = "volatileocpp", string meterStart = "42", string timestamp = "2024-10-27T19:10:11Z", string reason = "Other")
    {
        Socket.Send("[2,\"dddb2599-d678-4ff8-bf38-a230390a1200\",\"StopTransaction\",{\"reason\":\""+reason+"\",\"transactionId\":\"" + transid + "\",\"idTag\":\""+idTag+"\",\"meterStart\":\""+meterStart+"\",\"timestamp\":\""+timestamp+"\"}]");
        
    }

    internal void SendRemoteStartTransaction(string connectorId = "1", string idTag = "volatileocpp")
    {
        Socket.Send("[2, \"a187bcd6-4042-4a82-b6d4-b4c55d2f2caa\", \"RemoteStartTransaction\", {\"connectorId\": \""+connectorId+"\", \"idTag\": \""+idTag+"\"}],");
    }

    internal void SendDataTransfer(string vendorId = "volatileocpp", string messageId = "MessageID", string data = "Data")
    {
                Socket.Send(" [2, \"29e7a835-6ff6-4cf8-90e6-5d51182f8fde\", \"DataTransfer\", {\"vendorId\": \""+vendorId+"\", \"messageId\": \""+messageId+"\", \"data\": \""+data+"\"}]");

    }
}
