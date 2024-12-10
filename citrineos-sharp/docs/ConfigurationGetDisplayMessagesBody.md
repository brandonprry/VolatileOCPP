# ocpp.citrineos.Model.ConfigurationGetDisplayMessagesBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomData** | [**CustomDataType**](CustomDataType.md) |  | [optional] 
**Id** | **List&lt;int?&gt;** | If provided the Charging Station shall return Display Messages of the given ids. This field SHALL NOT contain more ids than set in &amp;lt;&amp;lt;configkey-number-of-display-messages,NumberOfDisplayMessages.maxLimit&amp;gt;&amp;gt;     | [optional] 
**RequestId** | **int?** | The Id of this request.   | 
**Priority** | [**MessagePriorityEnumType**](MessagePriorityEnumType.md) |  | [optional] 
**State** | [**MessageStateEnumType**](MessageStateEnumType.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

