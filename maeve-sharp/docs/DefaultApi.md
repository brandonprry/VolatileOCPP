# IO.Swagger.Api.DefaultApi

All URIs are relative to *http://localhost:9410/api/v0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCertificate**](DefaultApi.md#deletecertificate) | **DELETE** /certificate/{certificateHash} | Delete a certificate
[**InstallChargeStationCertificates**](DefaultApi.md#installchargestationcertificates) | **POST** /cs/{csId}/certificates | Install certificates on the charge station
[**ListTokens**](DefaultApi.md#listtokens) | **GET** /token | List authorization tokens
[**LookupCertificate**](DefaultApi.md#lookupcertificate) | **GET** /certificate/{certificateHash} | Lookup a certificate
[**LookupChargeStationAuth**](DefaultApi.md#lookupchargestationauth) | **GET** /cs/{csId}/auth | Returns the authentication details
[**LookupToken**](DefaultApi.md#lookuptoken) | **GET** /token/{tokenUid} | Lookup an authorization token
[**ReconfigureChargeStation**](DefaultApi.md#reconfigurechargestation) | **POST** /cs/{csId}/reconfigure | Reconfigure the charge station
[**RegisterChargeStation**](DefaultApi.md#registerchargestation) | **POST** /cs/{csId} | Register a new charge station
[**RegisterLocation**](DefaultApi.md#registerlocation) | **POST** /location/{locationId} | Registers a location with the CSMS
[**RegisterParty**](DefaultApi.md#registerparty) | **POST** /register | Registers an OCPI party with the CSMS
[**SetToken**](DefaultApi.md#settoken) | **POST** /token | Create/update an authorization token
[**TriggerChargeStation**](DefaultApi.md#triggerchargestation) | **POST** /cs/{csId}/trigger | 
[**UploadCertificate**](DefaultApi.md#uploadcertificate) | **POST** /certificate | Upload a certificate

<a name="deletecertificate"></a>
# **DeleteCertificate**
> void DeleteCertificate (string certificateHash)

Delete a certificate

Deletes a client certificate that has been uploaded to the CSMS using a base64 encoded SHA-256 hash of the DER bytes. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCertificateExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var certificateHash = certificateHash_example;  // string | 

            try
            {
                // Delete a certificate
                apiInstance.DeleteCertificate(certificateHash);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteCertificate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certificateHash** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="installchargestationcertificates"></a>
# **InstallChargeStationCertificates**
> void InstallChargeStationCertificates (ChargeStationInstallCertificates body, string csId)

Install certificates on the charge station

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InstallChargeStationCertificatesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new ChargeStationInstallCertificates(); // ChargeStationInstallCertificates | 
            var csId = csId_example;  // string | The charge station identifier

            try
            {
                // Install certificates on the charge station
                apiInstance.InstallChargeStationCertificates(body, csId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.InstallChargeStationCertificates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ChargeStationInstallCertificates**](ChargeStationInstallCertificates.md)|  | 
 **csId** | **string**| The charge station identifier | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listtokens"></a>
# **ListTokens**
> List<Token> ListTokens (int? offset = null, int? limit = null)

List authorization tokens

Lists all tokens that can be used to authorize a charge 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListTokensExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var offset = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List authorization tokens
                List&lt;Token&gt; result = apiInstance.ListTokens(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListTokens: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**List<Token>**](Token.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="lookupcertificate"></a>
# **LookupCertificate**
> Certificate LookupCertificate (string certificateHash)

Lookup a certificate

Lookup a client certificate that has been uploaded to the CSMS using a base64 encoded SHA-256 hash of the DER bytes. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LookupCertificateExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var certificateHash = certificateHash_example;  // string | 

            try
            {
                // Lookup a certificate
                Certificate result = apiInstance.LookupCertificate(certificateHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.LookupCertificate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certificateHash** | **string**|  | 

### Return type

[**Certificate**](Certificate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="lookupchargestationauth"></a>
# **LookupChargeStationAuth**
> ChargeStationAuth LookupChargeStationAuth (string csId)

Returns the authentication details

Returns the details required by the CSMS gateway to determine how to authenticate the charge station 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LookupChargeStationAuthExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var csId = csId_example;  // string | The charge station identifier

            try
            {
                // Returns the authentication details
                ChargeStationAuth result = apiInstance.LookupChargeStationAuth(csId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.LookupChargeStationAuth: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **csId** | **string**| The charge station identifier | 

### Return type

[**ChargeStationAuth**](ChargeStationAuth.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="lookuptoken"></a>
# **LookupToken**
> Token LookupToken (string tokenUid)

Lookup an authorization token

Lookup a token that can be used to authorize a charge 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LookupTokenExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var tokenUid = tokenUid_example;  // string | 

            try
            {
                // Lookup an authorization token
                Token result = apiInstance.LookupToken(tokenUid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.LookupToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenUid** | **string**|  | 

### Return type

[**Token**](Token.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="reconfigurechargestation"></a>
# **ReconfigureChargeStation**
> void ReconfigureChargeStation (Dictionary<string, string> body, string csId)

Reconfigure the charge station

Supplies new configuration that should be applied to the charge station. This is not intended to be used as a general charge station provisioning mechanism, it is intended for one time changes required during testing. After reconfiguration, the charge station will be rebooted so the new configuration can take effect if instructed to. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReconfigureChargeStationExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new Dictionary<string, string>(); // Dictionary<string, string> | 
            var csId = csId_example;  // string | The charge station identifier

            try
            {
                // Reconfigure the charge station
                apiInstance.ReconfigureChargeStation(body, csId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ReconfigureChargeStation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dictionary&lt;string, string&gt;**](Dictionary&lt;string, string&gt;.md)|  | 
 **csId** | **string**| The charge station identifier | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registerchargestation"></a>
# **RegisterChargeStation**
> void RegisterChargeStation (ChargeStationAuth body, string csId)

Register a new charge station

Registers a new charge station. The system will assume that the charge station has not yet been provisioned and will place the charge station into a pending state so it can been configured when it sends a boot notification. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterChargeStationExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new ChargeStationAuth(); // ChargeStationAuth | 
            var csId = csId_example;  // string | The charge station identifier

            try
            {
                // Register a new charge station
                apiInstance.RegisterChargeStation(body, csId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RegisterChargeStation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ChargeStationAuth**](ChargeStationAuth.md)|  | 
 **csId** | **string**| The charge station identifier | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registerlocation"></a>
# **RegisterLocation**
> void RegisterLocation (Location body, string locationId)

Registers a location with the CSMS

Registers a location with the CSMS. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterLocationExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new Location(); // Location | 
            var locationId = locationId_example;  // string | The location identifier

            try
            {
                // Registers a location with the CSMS
                apiInstance.RegisterLocation(body, locationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RegisterLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Location**](Location.md)|  | 
 **locationId** | **string**| The location identifier | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registerparty"></a>
# **RegisterParty**
> void RegisterParty (Registration body)

Registers an OCPI party with the CSMS

Registers an OCPI party with the CSMS. Depending on the configuration provided the CSMS will either initiate a registration with the party or the party will wait for the party to initiate  a registration with the CSMS. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterPartyExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new Registration(); // Registration | 

            try
            {
                // Registers an OCPI party with the CSMS
                apiInstance.RegisterParty(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RegisterParty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Registration**](Registration.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="settoken"></a>
# **SetToken**
> void SetToken (Token body)

Create/update an authorization token

Creates or updates a token that can be used to authorize a charge 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetTokenExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new Token(); // Token | 

            try
            {
                // Create/update an authorization token
                apiInstance.SetToken(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SetToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Token**](Token.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="triggerchargestation"></a>
# **TriggerChargeStation**
> void TriggerChargeStation (ChargeStationTrigger body, string csId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TriggerChargeStationExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new ChargeStationTrigger(); // ChargeStationTrigger | 
            var csId = csId_example;  // string | The charge station identifier

            try
            {
                apiInstance.TriggerChargeStation(body, csId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.TriggerChargeStation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ChargeStationTrigger**](ChargeStationTrigger.md)|  | 
 **csId** | **string**| The charge station identifier | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="uploadcertificate"></a>
# **UploadCertificate**
> void UploadCertificate (Certificate body)

Upload a certificate

Uploads a client certificate to the CSMS. The CSMS can use the certificate to authenticate the charge station using mutual TLS when the TLS operations are being offloaded to a load-balancer. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadCertificateExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new Certificate(); // Certificate | 

            try
            {
                // Upload a certificate
                apiInstance.UploadCertificate(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UploadCertificate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Certificate**](Certificate.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
