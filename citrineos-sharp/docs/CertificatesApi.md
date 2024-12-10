# IO.Swagger.Api.CertificatesApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataCertificatesSystemConfigGet**](CertificatesApi.md#datacertificatessystemconfigget) | **GET** /data/certificates/systemConfig | 
[**DataCertificatesSystemConfigPut**](CertificatesApi.md#datacertificatessystemconfigput) | **PUT** /data/certificates/systemConfig | 
[**OcppCertificatesCertificateSignedPost**](CertificatesApi.md#ocppcertificatescertificatesignedpost) | **POST** /ocpp/certificates/certificateSigned | 
[**OcppCertificatesDeleteCertificatePost**](CertificatesApi.md#ocppcertificatesdeletecertificatepost) | **POST** /ocpp/certificates/deleteCertificate | 
[**OcppCertificatesGetInstalledCertificateIdsPost**](CertificatesApi.md#ocppcertificatesgetinstalledcertificateidspost) | **POST** /ocpp/certificates/getInstalledCertificateIds | 
[**OcppCertificatesInstallCertificatePost**](CertificatesApi.md#ocppcertificatesinstallcertificatepost) | **POST** /ocpp/certificates/installCertificate | 

<a name="datacertificatessystemconfigget"></a>
# **DataCertificatesSystemConfigGet**
> void DataCertificatesSystemConfigGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataCertificatesSystemConfigGetExample
    {
        public void main()
        {
            var apiInstance = new CertificatesApi();

            try
            {
                apiInstance.DataCertificatesSystemConfigGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CertificatesApi.DataCertificatesSystemConfigGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="datacertificatessystemconfigput"></a>
# **DataCertificatesSystemConfigPut**
> void DataCertificatesSystemConfigPut ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataCertificatesSystemConfigPutExample
    {
        public void main()
        {
            var apiInstance = new CertificatesApi();

            try
            {
                apiInstance.DataCertificatesSystemConfigPut();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CertificatesApi.DataCertificatesSystemConfigPut: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ocppcertificatescertificatesignedpost"></a>
# **OcppCertificatesCertificateSignedPost**
> void OcppCertificatesCertificateSignedPost (CertificatesCertificateSignedBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OcppCertificatesCertificateSignedPostExample
    {
        public void main()
        {
            var apiInstance = new CertificatesApi();
            var body = new CertificatesCertificateSignedBody(); // CertificatesCertificateSignedBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppCertificatesCertificateSignedPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CertificatesApi.OcppCertificatesCertificateSignedPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CertificatesCertificateSignedBody**](CertificatesCertificateSignedBody.md)|  | 
 **identifier** | **string**|  | 
 **tenantId** | **string**|  | 
 **callbackUrl** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ocppcertificatesdeletecertificatepost"></a>
# **OcppCertificatesDeleteCertificatePost**
> void OcppCertificatesDeleteCertificatePost (CertificatesDeleteCertificateBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OcppCertificatesDeleteCertificatePostExample
    {
        public void main()
        {
            var apiInstance = new CertificatesApi();
            var body = new CertificatesDeleteCertificateBody(); // CertificatesDeleteCertificateBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppCertificatesDeleteCertificatePost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CertificatesApi.OcppCertificatesDeleteCertificatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CertificatesDeleteCertificateBody**](CertificatesDeleteCertificateBody.md)|  | 
 **identifier** | **string**|  | 
 **tenantId** | **string**|  | 
 **callbackUrl** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ocppcertificatesgetinstalledcertificateidspost"></a>
# **OcppCertificatesGetInstalledCertificateIdsPost**
> void OcppCertificatesGetInstalledCertificateIdsPost (string identifier, string tenantId, CertificatesGetInstalledCertificateIdsBody body = null, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OcppCertificatesGetInstalledCertificateIdsPostExample
    {
        public void main()
        {
            var apiInstance = new CertificatesApi();
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var body = new CertificatesGetInstalledCertificateIdsBody(); // CertificatesGetInstalledCertificateIdsBody |  (optional) 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppCertificatesGetInstalledCertificateIdsPost(identifier, tenantId, body, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CertificatesApi.OcppCertificatesGetInstalledCertificateIdsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**|  | 
 **tenantId** | **string**|  | 
 **body** | [**CertificatesGetInstalledCertificateIdsBody**](CertificatesGetInstalledCertificateIdsBody.md)|  | [optional] 
 **callbackUrl** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ocppcertificatesinstallcertificatepost"></a>
# **OcppCertificatesInstallCertificatePost**
> void OcppCertificatesInstallCertificatePost (CertificatesInstallCertificateBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OcppCertificatesInstallCertificatePostExample
    {
        public void main()
        {
            var apiInstance = new CertificatesApi();
            var body = new CertificatesInstallCertificateBody(); // CertificatesInstallCertificateBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppCertificatesInstallCertificatePost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CertificatesApi.OcppCertificatesInstallCertificatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CertificatesInstallCertificateBody**](CertificatesInstallCertificateBody.md)|  | 
 **identifier** | **string**|  | 
 **tenantId** | **string**|  | 
 **callbackUrl** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
