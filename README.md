# VolatileOCPP

https://ocpp.us

## Running CSMS scenarios

```
string url = "ws://localhost:8180/steve/websocket/CentralSystemService/1";
string protocol = "ocpp1.6";
CentralSystem s = new CentralSystem(url, protocol);
s.RunScenarios();
```

Scenarios can be run against the SteVe OCPP Server implementation as a testbed. Create a ChargeBox ID and OCPP TD tag "volatileocpp".

Scenario implementations are built based directly on the CompliancyTestTool PDF included within the repository. Not every scenario is implemented. Many will be implemented in time. Some will be implemented when software/hardware that implements it gets tested.

https://github.com/steve-community/steve

Issues found and reported so far:

https://github.com/steve-community/steve/issues/1609

Unless your CS or CSMS implements every OCPP method, then not every scenario will apply to your implementation. Those scenarios will be skipped during execution. Most implementations will be a subset of the full OCPP specification.

If you need help verifying your OCPP implementation, email bperry@atx.services to see how we can help.

```
Supports method: Authorize
Supports method: BootNotification
Supports method: DataTransfer
Supports method: FirmwareStatusNotification
Supports method: Heartbeat
Supports method: MeterValues
Supports method: StatusNotification
Supports method: StartTransaction
Supports method: StopTransaction
Done

Running scenario: ocpp.Scenarios.TC_001_CSMS    -- PASSED!
Running scenario: ocpp.Scenarios.TC_003_CSMS    -- PASSED!
Running scenario: ocpp.Scenarios.TC_004_1_CSMS  -- PASSED!
Running scenario: ocpp.Scenarios.TC_004_2_CSMS  -- PASSED!
Running scenario: ocpp.Scenarios.TC_005_1_CSMS  -- PASSED!
Running scenario: ocpp.Scenarios.TC_007_CSMS    -- PASSED!
Skipping incompatible test ocpp.Scenarios.TC_010_CSMS
Running scenario: ocpp.Scenarios.TC_023_1_CSMS  -- PASSED!
Running scenario: ocpp.Scenarios.TC_023_2_CSMS
Configure the volatileocpp ID Tag to be expired then press enter.

        -- PASSED!
Running scenario: ocpp.Scenarios.TC_023_3_CSMS
Configure the volatileocpp ID Tag to be blocked then press enter.

        -- PASSED!
Running scenario: ocpp.Scenarios.TC_024_CSMS    -- PASSED!
Running scenario: ocpp.Scenarios.TC_064_CSMS
WARNING: DataTransfer Response ACCEPTED
        -- PASSED!
```

A failed result might look like this.

```
Supports method: Authorize
Supports method: BootNotification
Supports method: DataTransfer
Supports method: FirmwareStatusNotification
Supports method: Heartbeat
Supports method: MeterValues
Supports method: StatusNotification
Supports method: StartTransaction
Supports method: StopTransaction
Done

Running scenario: ocpp.Scenarios.TC_001_CSMS    -- PASSED!
Running scenario: ocpp.Scenarios.TC_003_CSMS    -- PASSED!
Running scenario: ocpp.Scenarios.TC_004_1_CSMS  -- PASSED!
Running scenario: ocpp.Scenarios.TC_004_2_CSMS  -- PASSED!
Running scenario: ocpp.Scenarios.TC_005_1_CSMS  -- PASSED!
Running scenario: ocpp.Scenarios.TC_007_CSMS    -- PASSED!
Skipping incompatible test ocpp.Scenarios.TC_010_CSMS
Running scenario: ocpp.Scenarios.TC_023_1_CSMS  -- PASSED!
Running scenario: ocpp.Scenarios.TC_023_2_CSMS
Configure the volatileocpp ID Tag to be expired then press enter.

10/29/2024 9:12:13 PM|Error|WebSocket.messagec|System.Exception: Invalid response
                               at ocpp.Scenarios.TC_023_2_CSMS.<>c__DisplayClass3_0.<RunScenario>b__0(Object sender, MessageEventArgs e) in /Users/bperry/projects/ocpp/Scenarios/TC_023_2_CSMS.cs:line 39
                               at WebSocketSharp.WebSocket.messagec(MessageEventArgs e)
        -- FAILED!
Running scenario: ocpp.Scenarios.TC_023_3_CSMS
Configure the volatileocpp ID Tag to be blocked then press enter.

10/29/2024 9:12:17 PM|Error|WebSocket.messagec|System.Exception: Invalid response
                               at ocpp.Scenarios.TC_023_3_CSMS.<>c__DisplayClass3_0.<RunScenario>b__0(Object sender, MessageEventArgs e) in /Users/bperry/projects/ocpp/Scenarios/TC_023_3_CSMS.cs:line 39
                               at WebSocketSharp.WebSocket.messagec(MessageEventArgs e)
        -- FAILED!
Running scenario: ocpp.Scenarios.TC_024_CSMS    -- PASSED!
Running scenario: ocpp.Scenarios.TC_064_CSMS
WARNING: DataTransfer Response ACCEPTED
        -- PASSED!
```

## Simulating Chargers for your CSMS

Some basic charger simulations can be performed.

```
string url = "ws://localhost:8180/steve/websocket/CentralSystemService/1";
string protocol = "ocpp1.6";

List<Task> tasks = new List<Task>();
for (int i = 1; i< 11; i++)
{
    Charger c = new Charger(url, protocol);
    c.ConnectorID = i.ToString();
    c.IDTag = "volatileocpp";
    tasks.Add(Task.Run(c.Simulate));
}

foreach (Task t in tasks)
    t.Wait();
```

![image](https://github.com/user-attachments/assets/9fed843c-df94-4b5e-9de3-e64612f88b75)

![image](https://github.com/user-attachments/assets/3bac011f-0720-4e4d-9868-c4b5ecb3a4ce)

