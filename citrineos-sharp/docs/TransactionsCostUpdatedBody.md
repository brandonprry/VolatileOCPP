# ocpp.citrineos.Model.TransactionsCostUpdatedBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomData** | [**CustomDataType**](CustomDataType.md) |  | [optional] 
**TotalCost** | [**decimal?**](BigDecimal.md) | Current total cost, based on the information known by the CSMS, of the transaction including taxes. In the currency configured with the configuration Variable: [&amp;lt;&amp;lt;configkey-currency, Currency&amp;gt;&amp;gt;]     | 
**TransactionId** | **string** | Transaction Id of the transaction the current cost are asked for.     | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

