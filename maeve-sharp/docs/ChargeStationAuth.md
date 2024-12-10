# IO.Swagger.Model.ChargeStationAuth
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SecurityProfile** | **int?** | The security profile to use for the charge station: * &#x60;0&#x60; - unsecured transport with basic auth * &#x60;1&#x60; - TLS with basic auth * &#x60;2&#x60; - TLS with client certificate  | 
**Base64SHA256Password** | **string** | The base64 encoded, SHA-256 hash of the charge station password | [optional] 
**InvalidUsernameAllowed** | **bool?** | If set to true then an invalid username will not prevent the charge station connecting | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

