# IO.Swagger.Model.CertificatesCertificateSignedBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomData** | [**CustomDataType**](CustomDataType.md) |  | [optional] 
**CertificateChain** | **string** | The signed PEM encoded X.509 certificate. This can also contain the necessary sub CA certificates. In that case, the order of the bundle should follow the certificate chain, starting from the leaf certificate.    The Configuration Variable &amp;lt;&amp;lt;configkey-max-certificate-chain-size,MaxCertificateChainSize&amp;gt;&amp;gt; can be used to limit the maximum size of this field.   | 
**CertificateType** | [**CertificateSigningUseEnumType**](CertificateSigningUseEnumType.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

