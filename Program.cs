// See https://aka.ms/new-console-template for more information
using System;
using WebSocketSharp;
using Newtonsoft.Json;

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

            foreach (string method in rpcMethods)
            {
                ws.Send("[2, \"" + uuid.ToString() + "\", \"" + method + "\", {}]");
            }

            Thread.Sleep(500);

        }
    }
}