# ocpp.citrineos.Model.ReportingCustomerInformationBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomData** | [**CustomDataType**](CustomDataType.md) |  | [optional] 
**CustomerCertificate** | [**CertificateHashDataType**](CertificateHashDataType.md) |  | [optional] 
**IdToken** | [**IdTokenType**](IdTokenType.md) |  | [optional] 
**RequestId** | **int?** | The Id of the request.     | 
**Report** | **bool?** | Flag indicating whether the Charging Station should return NotifyCustomerInformationRequest messages containing information about the customer referred to.   | 
**Clear** | **bool?** | Flag indicating whether the Charging Station should clear all information about the customer referred to.   | 
**CustomerIdentifier** | **string** | A (e.g. vendor specific) identifier of the customer this request refers to. This field contains a custom identifier other than IdToken and Certificate.  One of the possible identifiers (customerIdentifier, customerIdToken or customerCertificate) should be in the request message.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

