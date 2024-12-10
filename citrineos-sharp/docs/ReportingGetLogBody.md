# ocpp.citrineos.Model.ReportingGetLogBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomData** | [**CustomDataType**](CustomDataType.md) |  | [optional] 
**Log** | [**LogParametersType**](LogParametersType.md) |  | 
**LogType** | [**LogEnumType**](LogEnumType.md) |  | 
**RequestId** | **int?** | The Id of this request   | 
**Retries** | **int?** | This specifies how many times the Charging Station must try to upload the log before giving up. If this field is not present, it is left to Charging Station to decide how many times it wants to retry.   | [optional] 
**RetryInterval** | **int?** | The interval in seconds after which a retry may be attempted. If this field is not present, it is left to Charging Station to decide how long to wait between attempts.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

