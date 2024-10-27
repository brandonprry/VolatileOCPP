// See https://aka.ms/new-console-template for more information
using System;
using WebSocketSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        using (var ws = new WebSocket("ws://localhost:8180/steve/websocket/CentralSystemService/1", "ocpp1.6"))
        {
            ws.OnMessage += (sender, e) =>
                            Console.WriteLine("Laputa says: " + e.Data);

            ws.Connect();
            Guid uuid = Guid.NewGuid();
            ws.Send("[2, \"" + uuid.ToString() + "\", \"Heartbeat\", {}]");
            Thread.Sleep(5);
        }

        string[] rpcMethods = ["Authorize",
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
"UpdateFirmware"];

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


        Dictionary<string,string> impl = new Dictionary<string, string>();
        foreach (string method in rpcMethods)
        {
            using (var ws = new WebSocket("ws://localhost:8180/steve/websocket/CentralSystemService/1", "ocpp1.6"))
            {
                ws.OnMessage += (sender, e) =>
                {
                    JToken[] ret = JArray.Parse(e.Data).ToArray<JToken>();
                    string? tmp;
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
                    }

                    Console.WriteLine("Laputa says: " + method);
                };

                ws.Connect();
                Guid uuid = Guid.NewGuid();
                ws.Send("[2, \"" + uuid.ToString() + "\", \"" + method + "\", {}]");
                Thread.Sleep(5);
            }
        }

        Thread.Sleep(500);

    }
}
