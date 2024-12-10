using System;
using WebSocketSharp;
using Newtonsoft.Json.Linq;

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
    public string[]? SupportedMethods { get; set; }

    public string[]? UnsupportedMethods { get; set; }

    public string URL { get { return _url; } }

    public string Protocol { get { return _protocol; } }

    public void GetMethods()
    {
        string[] rpcMethods = [
       "Authorize",
"BootNotification",
"CancelReservation",
"CertificateSigned",
"ChangeAvailability",
"ClearCache",
"ClearChargingProfile",
"ClearDisplayMessage",
"ClearVariableMonitoring",
"ClearedChargingLimit",
"CostUpdated",
"CustomerInformation",
"DataTransfer",
"DeleteCertificate",
"FirmwareStatusNotification",
"Get15118EVCertificate",
"GetBaseReport",
"GetCertificateStatus",
"GetChargingProfiles",
"GetCompositeSchedule",
"GetDisplayMessages",
"GetInstalledCertificateIds",
"GetLocalListVersion",
"GetLog",
"GetMonitoringReport",
"GetReport",
"GetTransactionStatus",
"GetVariables",
"Heartbeat",
"InstallCertificate",
"LogStatusNotification",
"MeterValues",
"NotifyChargingLimit",
"NotifyCustomerInformation",
"NotifyDisplayMessages",
"NotifyEVChargingNeeds",
"NotifyEVChargingSchedule",
"NotifyEvent",
"NotifyMonitoringReport",
"NotifyReport",
"PublishFirmware",
"PublishFirmwareStatusNotification",
"ReportChargingProfiles",
"RequestStartTransaction",
"RequestStopTransaction",
"ReservationStatusUpdate",
"ReserveNow",
"Reset",
"SecurityEventNotification",
"SendLocalList",
"SetChargingProfile",
"SetDisplayMessage",
"SetMonitoringBase",
"SetMonitoringLevel",
"SetNetworkProfile",
"SetVariableMonitoring",
"SetVariables",
"SignCertificate",
"StatusNotification",
"TransactionEvent",
"TriggerMessage",
"UnlockConnector",
"UnpublishFirmware",
"UpdateFirmware"
       ];

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
                    string tmp;
                    JObject? obj;

                    try
                    {
                        tmp = ret[2].Value<string>();

                        if (!validResponses.Contains(tmp))
                            throw new Exception(tmp);

                        less.Add(method);
                    }
                    catch
                    {
                        obj = ret[2] as JObject;
                        more.Add(method);
                    }

                    Console.WriteLine("Laputa says: " + method);
                };

                ws.Connect();
                Guid uuid = Guid.NewGuid();
                ws.Send("[2, \"" + uuid.ToString() + "\", \"" + method + "\", {}]");
                Thread.Sleep(1000);
            }
        }

        this.SupportedMethods = more.ToArray();
        this.UnsupportedMethods = less.ToArray();
        Console.WriteLine ("Done");
    }
}
