# IO.Swagger.Model.Token
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountryCode** | **string** | The country code of the issuing eMSP | 
**PartyId** | **string** | The party id of the issuing eMSP | 
**Type** | **string** | The type of token | 
**Uid** | **string** | The unique token id | 
**ContractId** | **string** | The contract ID (eMAID) associated with the token (with optional component separators) | 
**VisualNumber** | **string** | The visual/readable number/identification printed on an RFID card | [optional] 
**Issuer** | **string** | Issuing company, most of the times the name of the company printed on the RFID card, not necessarily the eMSP | 
**GroupId** | **string** | This id groups a couple of tokens to make two or more tokens work as one | [optional] 
**Valid** | **bool?** | Is this token valid | 
**LanguageCode** | **string** | The preferred language to use encoded as ISO 639-1 language code | [optional] 
**CacheMode** | **string** | Indicates what type of token caching is allowed | 
**LastUpdated** | **DateTime?** | The date the record was last updated (ignored on create/update) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

