// See https://aka.ms/new-console-template for more information
using System;
using WebSocketSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ocpp.Scenarios;

public class Program
{
    public static void Main(string[] args)
    {
        string url = "ws://localhost:8180/steve/websocket/CentralSystemService/1";
        string protocol = "ocpp1.6";

        IScenario test = new TC_001_CSMS();
        test.RunScenario(url, protocol);

        test = new TC_003_CSMS();
        test.RunScenario(url, protocol);


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
            }
            catch
            {
                Console.WriteLine("Error");
                return;
            }

        }

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

        Dictionary<string, string> impl = new Dictionary<string, string>();
        List<string> more = new List<string>();
        foreach (string method in rpcMethods)
        {
            using (var ws = new WebSocket(url, protocol))
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

                        impl[method] = tmp;
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

 


        Console.WriteLine("Done.");
    }
}
