# ocpp.citrineos.Model.EvdriverRequestStartTransactionBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomData** | [**CustomDataType**](CustomDataType.md) |  | [optional] 
**EvseId** | **int?** | Number of the EVSE on which to start the transaction. EvseId SHALL be &amp;gt; 0   | [optional] 
**GroupIdToken** | [**IdTokenType**](IdTokenType.md) |  | [optional] 
**IdToken** | [**IdTokenType**](IdTokenType.md) |  | 
**RemoteStartId** | **int?** | Id given by the server to this start request. The Charging Station might return this in the &amp;lt;&amp;lt;transactioneventrequest, TransactionEventRequest&amp;gt;&amp;gt;, letting the server know which transaction was started for this request. Use to start a transaction.   | 
**ChargingProfile** | [**ChargingProfileType**](ChargingProfileType.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

