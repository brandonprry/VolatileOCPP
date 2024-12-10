# IO.Swagger.Model.ConfigurationPublishFirmwareBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomData** | [**CustomDataType**](CustomDataType.md) |  | [optional] 
**Location** | **string** | This contains a string containing a URI pointing to a  location from which to retrieve the firmware.   | 
**Retries** | **int?** | This specifies how many times Charging Station must try  to download the firmware before giving up. If this field is not  present, it is left to Charging Station to decide how many times it wants to retry.   | [optional] 
**Checksum** | **string** | The MD5 checksum over the entire firmware file as a hexadecimal string of length 32.    | 
**RequestId** | **int?** | The Id of the request.   | 
**RetryInterval** | **int?** | The interval in seconds  after which a retry may be  attempted. If this field is not  present, it is left to Charging  Station to decide how long to wait  between attempts.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

