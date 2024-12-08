# IO.Swagger.Model.Registration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Token** | **string** | The token to use for communicating with the eMSP (CREDENTIALS_TOKEN_A). | 
**Url** | **string** | The URL of the eMSP versions endpoint. If provided the CSMS will act as the sender of the versions request. | [optional] 
**Status** | **string** | The status of the registration request. If the request is marked as &#x60;REGISTERED&#x60; then the token will be allowed to be used to access all endpoints avoiding the need for the OCPI registration process. If the request is marked as  &#x60;PENDING&#x60; then the token will only be allowed to access the &#x60;/ocpi/versions&#x60;, &#x60;/ocpi/2.2&#x60; and &#x60;/ocpi/2.2/credentials&#x60; endpoints.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

