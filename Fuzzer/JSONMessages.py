#!/usr/bin/env python2

messages = [
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2c8b", "Heartbeat", {}],
    [2,"852a4cb2-0e20-46f8-bc29-c5ab3cb182c7","BootNotification",{"chargePointVendor":"Radboud","chargePointModel":"Fuzzer"}],
    [2,"8d59bc8c-9884-4d64-82b5-3819d0c58b8a","Authorize",{"idTag":"Authorize"}],
    [2,"dddb2599-d678-4ff8-bf38-a230390a1200","StartTransaction",{"connectorId":42,"idTag":"some id","meterStart":42,"timestamp":"2017-10-27T19:10:11Z"}],
    [2,"9b25cbb0-c016-41e7-baa0-e796a9565c11","StatusNotification",{"connectorId":42,"errorCode":"NoError","status":"Available"}],
    [2,"29e7a835-6ff6-4cf8-90e6-5d51182f8fdb","StopTransaction",{"idTag":"some id", "meterStop":41,"timestamp":"2017-10-27T19:10:11Z","transactionId":42}],
    [2, "29e7a835-6ff6-4cf8-90e6-5d51182f8fde", "DataTransfer", {"vendorId": "Radboud", "messageId": "No-Idea", "data": "There should be some data here"}],
    [2, "29e7a835-6ff6-4cf8-90e6-5d51182f8fdf", "DiagnosticsStatusNotification", {"status": "Uploading"}],
    [2, "29e7a835-6ff6-4cf8-90e6-5d51182f8bea", "FirmwareStatusNotification", {"status": "DownloadFailed"}],
    [2, "29e7a835-6ff6-4cf8-90e6-5d51182f8beb", "GetCompositeSchedule", {"connectorId": 42, "duration": 1337, "chargingRateUnit": "W"}],
    [2, "29e7a835-6ff6-4cf8-90e6-5d51182f8bec", "GetConfiguration", {"key": ["keykeykey"]}],
    [2, "29e7a835-6ff6-4cf8-90e6-5d51182f8bed", "GetDiagnostics", {"location": "http://example.com/ocpp", "retries": 5, "retryInterval": 30, "startTime": "2012-10-27T19:10:11Z", "stopTime": "2017-10-27T19:10:11Z"}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2bee", "GetLocalListVersion", {}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2bef", "MeterValues", {"connectorId": 42, "transactionId": 123456, "meterValue": [{"timestamp": "2017-10-27T19:10:11Z", "sampledValue": [{"value": "xxx", "context": "Trigger", "format": "SignedData", "measurand": "Power.Active.Export", "phase": "L1", "location":"Cable", "unit": "kWh"}]}]}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2caa", "RemoteStartTransaction", {"connectorId": 42, "idTag": "tagtag"}], #chargingProfile parameter skipped
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2cab", "RemoteStopTransaction", {"transactionId": 123456}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2cac", "ReserveNow", {"connectorId": 42, "expiryDate": "2017-10-27T19:10:11Z", "idTag": "tagtag", "reservationId": 89}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2cad", "Reset", {"type": "Hard"}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2cae", "SendLocalList", {"listVersion": 2, "localAuthorizationList": [{"idTag": "tagtag", "idTagInfo": {"status":"Accepted"}}], "updateType": "Full"}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2caf", "SetChargingProfile", {"connectorId":42, "csChargingProfiles": {"chargingProfileId":888,"transactionId":78, "stackLevel":1, "chargingProfilePurpose":"TxProfile", "chargingProfileKind": "Absolute", "recurrencyKind":"Weekly", "validFrom":"2017-10-27T19:10:11Z", "validTo":"2017-10-27T19:10:11Z", "chargingSchedule":{"duration":10, "chargingRateUnit":"W", "chargingSchedulePeriod":[{"startPeriod":100, "limit": 0.1}]}}}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2cba", "TriggerMessage", {"requestedMessage": "Heartbeat", "connectorId": 42}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2cbb", "UnlockConnector", {"connectorId":42}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2bee", "UpdateFirmware", {"location": "http://example.com/ocpp", "retries":5, "retrieveDate":"2017-10-27T19:10:11Z","retryInterval":30}],
]