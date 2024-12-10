using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace ocpp;

public static class Utility
{

    public static string ProjectDirectory { get {
        return Environment.CurrentDirectory;
    }}
    public static string[] Methods
    {
        get
        {
            return [
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
"RemoteStartTransaction",
"RemoteStopTransaction",
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
"StartTransaction",
"StopTransaction",
"TransactionEvent",
"TriggerMessage",
"UnlockConnector",
"UnpublishFirmware",
"UpdateFirmware"
       ];
        }
    }

    public static bool ValidateJSON(JObject json, string schema)
    {
        JSchema s = JSchema.Parse(schema);
        return json.IsValid(s);
    }
}
