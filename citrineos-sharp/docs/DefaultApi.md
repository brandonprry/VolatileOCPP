# IO.Swagger.Api.DefaultApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataCertificatesCertificateChainPost**](DefaultApi.md#datacertificatescertificatechainpost) | **POST** /data/certificates/certificateChain | 
[**DataCertificatesRootCertificatePut**](DefaultApi.md#datacertificatesrootcertificateput) | **PUT** /data/certificates/rootCertificate | 
[**DataCertificatesTlsCertificatesPut**](DefaultApi.md#datacertificatestlscertificatesput) | **PUT** /data/certificates/tlsCertificates | 
[**DataConfigurationBootDelete**](DefaultApi.md#dataconfigurationbootdelete) | **DELETE** /data/configuration/boot | 
[**DataConfigurationBootGet**](DefaultApi.md#dataconfigurationbootget) | **GET** /data/configuration/boot | 
[**DataConfigurationBootPut**](DefaultApi.md#dataconfigurationbootput) | **PUT** /data/configuration/boot | 
[**DataConfigurationPasswordPost**](DefaultApi.md#dataconfigurationpasswordpost) | **POST** /data/configuration/password | 
[**DataEvdriverAuthorizationDelete**](DefaultApi.md#dataevdriverauthorizationdelete) | **DELETE** /data/evdriver/authorization | 
[**DataEvdriverAuthorizationGet**](DefaultApi.md#dataevdriverauthorizationget) | **GET** /data/evdriver/authorization | 
[**DataEvdriverAuthorizationPut**](DefaultApi.md#dataevdriverauthorizationput) | **PUT** /data/evdriver/authorization | 
[**DataEvdriverAuthorizationRestrictionsPut**](DefaultApi.md#dataevdriverauthorizationrestrictionsput) | **PUT** /data/evdriver/authorizationRestrictions | 
[**DataEvdriverLocalListVersionGet**](DefaultApi.md#dataevdriverlocallistversionget) | **GET** /data/evdriver/localListVersion | 
[**DataMonitoringVariableAttributeDelete**](DefaultApi.md#datamonitoringvariableattributedelete) | **DELETE** /data/monitoring/variableAttribute | 
[**DataMonitoringVariableAttributeGet**](DefaultApi.md#datamonitoringvariableattributeget) | **GET** /data/monitoring/variableAttribute | 
[**DataMonitoringVariableAttributePut**](DefaultApi.md#datamonitoringvariableattributeput) | **PUT** /data/monitoring/variableAttribute | 
[**DataOcpprouterSubscriptionDelete**](DefaultApi.md#dataocpproutersubscriptiondelete) | **DELETE** /data/ocpprouter/subscription | 
[**DataOcpprouterSubscriptionGet**](DefaultApi.md#dataocpproutersubscriptionget) | **GET** /data/ocpprouter/subscription | 
[**DataOcpprouterSubscriptionPost**](DefaultApi.md#dataocpproutersubscriptionpost) | **POST** /data/ocpprouter/subscription | 
[**DataTransactionsTariffDelete**](DefaultApi.md#datatransactionstariffdelete) | **DELETE** /data/transactions/tariff | 
[**DataTransactionsTariffGet**](DefaultApi.md#datatransactionstariffget) | **GET** /data/transactions/tariff | 
[**DataTransactionsTariffPut**](DefaultApi.md#datatransactionstariffput) | **PUT** /data/transactions/tariff | 
[**DataTransactionsTransactionGet**](DefaultApi.md#datatransactionstransactionget) | **GET** /data/transactions/transaction | 

<a name="datacertificatescertificatechainpost"></a>
# **DataCertificatesCertificateChainPost**
> void DataCertificatesCertificateChainPost (CertificatesCertificateChainBody body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataCertificatesCertificateChainPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new CertificatesCertificateChainBody(); // CertificatesCertificateChainBody | 

            try
            {
                apiInstance.DataCertificatesCertificateChainPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataCertificatesCertificateChainPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CertificatesCertificateChainBody**](CertificatesCertificateChainBody.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="datacertificatesrootcertificateput"></a>
# **DataCertificatesRootCertificatePut**
> void DataCertificatesRootCertificatePut (CertificatesRootCertificateBody body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataCertificatesRootCertificatePutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new CertificatesRootCertificateBody(); // CertificatesRootCertificateBody | 

            try
            {
                apiInstance.DataCertificatesRootCertificatePut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataCertificatesRootCertificatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CertificatesRootCertificateBody**](CertificatesRootCertificateBody.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="datacertificatestlscertificatesput"></a>
# **DataCertificatesTlsCertificatesPut**
> void DataCertificatesTlsCertificatesPut (CertificatesTlsCertificatesBody body, string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataCertificatesTlsCertificatesPutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new CertificatesTlsCertificatesBody(); // CertificatesTlsCertificatesBody | 
            var id = id_example;  // string | 

            try
            {
                apiInstance.DataCertificatesTlsCertificatesPut(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataCertificatesTlsCertificatesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CertificatesTlsCertificatesBody**](CertificatesTlsCertificatesBody.md)|  | 
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="dataconfigurationbootdelete"></a>
# **DataConfigurationBootDelete**
> void DataConfigurationBootDelete (string stationId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataConfigurationBootDeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationId = stationId_example;  // string | 

            try
            {
                apiInstance.DataConfigurationBootDelete(stationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataConfigurationBootDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="dataconfigurationbootget"></a>
# **DataConfigurationBootGet**
> void DataConfigurationBootGet (string stationId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataConfigurationBootGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationId = stationId_example;  // string | 

            try
            {
                apiInstance.DataConfigurationBootGet(stationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataConfigurationBootGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="dataconfigurationbootput"></a>
# **DataConfigurationBootPut**
> void DataConfigurationBootPut (ConfigurationBootBody body, string stationId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataConfigurationBootPutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new ConfigurationBootBody(); // ConfigurationBootBody | Boot configuration used to determine boot process for a charging station
            var stationId = stationId_example;  // string | 

            try
            {
                apiInstance.DataConfigurationBootPut(body, stationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataConfigurationBootPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConfigurationBootBody**](ConfigurationBootBody.md)| Boot configuration used to determine boot process for a charging station | 
 **stationId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="dataconfigurationpasswordpost"></a>
# **DataConfigurationPasswordPost**
> void DataConfigurationPasswordPost (ConfigurationPasswordBody body, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataConfigurationPasswordPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new ConfigurationPasswordBody(); // ConfigurationPasswordBody | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.DataConfigurationPasswordPost(body, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataConfigurationPasswordPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConfigurationPasswordBody**](ConfigurationPasswordBody.md)|  | 
 **callbackUrl** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="dataevdriverauthorizationdelete"></a>
# **DataEvdriverAuthorizationDelete**
> void DataEvdriverAuthorizationDelete (string idToken, string type)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataEvdriverAuthorizationDeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var idToken = idToken_example;  // string | 
            var type = type_example;  // string | 

            try
            {
                apiInstance.DataEvdriverAuthorizationDelete(idToken, type);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataEvdriverAuthorizationDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idToken** | **string**|  | 
 **type** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="dataevdriverauthorizationget"></a>
# **DataEvdriverAuthorizationGet**
> void DataEvdriverAuthorizationGet (string idToken, string type)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataEvdriverAuthorizationGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var idToken = idToken_example;  // string | 
            var type = type_example;  // string | 

            try
            {
                apiInstance.DataEvdriverAuthorizationGet(idToken, type);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataEvdriverAuthorizationGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idToken** | **string**|  | 
 **type** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="dataevdriverauthorizationput"></a>
# **DataEvdriverAuthorizationPut**
> void DataEvdriverAuthorizationPut (EvdriverAuthorizationBody body, string idToken, string type)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataEvdriverAuthorizationPutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new EvdriverAuthorizationBody(); // EvdriverAuthorizationBody | 
            var idToken = idToken_example;  // string | 
            var type = type_example;  // string | 

            try
            {
                apiInstance.DataEvdriverAuthorizationPut(body, idToken, type);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataEvdriverAuthorizationPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EvdriverAuthorizationBody**](EvdriverAuthorizationBody.md)|  | 
 **idToken** | **string**|  | 
 **type** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="dataevdriverauthorizationrestrictionsput"></a>
# **DataEvdriverAuthorizationRestrictionsPut**
> void DataEvdriverAuthorizationRestrictionsPut (string idToken, string type, EvdriverAuthorizationRestrictionsBody body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataEvdriverAuthorizationRestrictionsPutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var idToken = idToken_example;  // string | 
            var type = type_example;  // string | 
            var body = new EvdriverAuthorizationRestrictionsBody(); // EvdriverAuthorizationRestrictionsBody |  (optional) 

            try
            {
                apiInstance.DataEvdriverAuthorizationRestrictionsPut(idToken, type, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataEvdriverAuthorizationRestrictionsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idToken** | **string**|  | 
 **type** | **string**|  | 
 **body** | [**EvdriverAuthorizationRestrictionsBody**](EvdriverAuthorizationRestrictionsBody.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="dataevdriverlocallistversionget"></a>
# **DataEvdriverLocalListVersionGet**
> void DataEvdriverLocalListVersionGet (string stationId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataEvdriverLocalListVersionGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationId = stationId_example;  // string | 

            try
            {
                apiInstance.DataEvdriverLocalListVersionGet(stationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataEvdriverLocalListVersionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="datamonitoringvariableattributedelete"></a>
# **DataMonitoringVariableAttributeDelete**
> void DataMonitoringVariableAttributeDelete (string stationId, string type = null, string value = null, string status = null, decimal? componentEvseId = null, decimal? componentEvseConnectorId = null, string componentName = null, string componentInstance = null, string variableName = null, string variableInstance = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataMonitoringVariableAttributeDeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationId = stationId_example;  // string | 
            var type = type_example;  // string |  (optional) 
            var value = value_example;  // string |  (optional) 
            var status = status_example;  // string |  (optional) 
            var componentEvseId = 1.2;  // decimal? |  (optional) 
            var componentEvseConnectorId = 1.2;  // decimal? |  (optional) 
            var componentName = componentName_example;  // string |  (optional) 
            var componentInstance = componentInstance_example;  // string |  (optional) 
            var variableName = variableName_example;  // string |  (optional) 
            var variableInstance = variableInstance_example;  // string |  (optional) 

            try
            {
                apiInstance.DataMonitoringVariableAttributeDelete(stationId, type, value, status, componentEvseId, componentEvseConnectorId, componentName, componentInstance, variableName, variableInstance);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataMonitoringVariableAttributeDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **string**|  | 
 **type** | **string**|  | [optional] 
 **value** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **componentEvseId** | **decimal?**|  | [optional] 
 **componentEvseConnectorId** | **decimal?**|  | [optional] 
 **componentName** | **string**|  | [optional] 
 **componentInstance** | **string**|  | [optional] 
 **variableName** | **string**|  | [optional] 
 **variableInstance** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="datamonitoringvariableattributeget"></a>
# **DataMonitoringVariableAttributeGet**
> void DataMonitoringVariableAttributeGet (string stationId, string type = null, string value = null, string status = null, decimal? componentEvseId = null, decimal? componentEvseConnectorId = null, string componentName = null, string componentInstance = null, string variableName = null, string variableInstance = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataMonitoringVariableAttributeGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationId = stationId_example;  // string | 
            var type = type_example;  // string |  (optional) 
            var value = value_example;  // string |  (optional) 
            var status = status_example;  // string |  (optional) 
            var componentEvseId = 1.2;  // decimal? |  (optional) 
            var componentEvseConnectorId = 1.2;  // decimal? |  (optional) 
            var componentName = componentName_example;  // string |  (optional) 
            var componentInstance = componentInstance_example;  // string |  (optional) 
            var variableName = variableName_example;  // string |  (optional) 
            var variableInstance = variableInstance_example;  // string |  (optional) 

            try
            {
                apiInstance.DataMonitoringVariableAttributeGet(stationId, type, value, status, componentEvseId, componentEvseConnectorId, componentName, componentInstance, variableName, variableInstance);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataMonitoringVariableAttributeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **string**|  | 
 **type** | **string**|  | [optional] 
 **value** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **componentEvseId** | **decimal?**|  | [optional] 
 **componentEvseConnectorId** | **decimal?**|  | [optional] 
 **componentName** | **string**|  | [optional] 
 **componentInstance** | **string**|  | [optional] 
 **variableName** | **string**|  | [optional] 
 **variableInstance** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="datamonitoringvariableattributeput"></a>
# **DataMonitoringVariableAttributePut**
> void DataMonitoringVariableAttributePut (MonitoringVariableAttributeBody body, string stationId, bool? setOnCharger = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataMonitoringVariableAttributePutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new MonitoringVariableAttributeBody(); // MonitoringVariableAttributeBody | 
            var stationId = stationId_example;  // string | 
            var setOnCharger = true;  // bool? |  (optional) 

            try
            {
                apiInstance.DataMonitoringVariableAttributePut(body, stationId, setOnCharger);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataMonitoringVariableAttributePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MonitoringVariableAttributeBody**](MonitoringVariableAttributeBody.md)|  | 
 **stationId** | **string**|  | 
 **setOnCharger** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="dataocpproutersubscriptiondelete"></a>
# **DataOcpprouterSubscriptionDelete**
> void DataOcpprouterSubscriptionDelete (decimal? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataOcpprouterSubscriptionDeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = 1.2;  // decimal? | 

            try
            {
                apiInstance.DataOcpprouterSubscriptionDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataOcpprouterSubscriptionDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="dataocpproutersubscriptionget"></a>
# **DataOcpprouterSubscriptionGet**
> void DataOcpprouterSubscriptionGet (string stationId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataOcpprouterSubscriptionGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationId = stationId_example;  // string | 

            try
            {
                apiInstance.DataOcpprouterSubscriptionGet(stationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataOcpprouterSubscriptionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="dataocpproutersubscriptionpost"></a>
# **DataOcpprouterSubscriptionPost**
> void DataOcpprouterSubscriptionPost (OcpprouterSubscriptionBody body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataOcpprouterSubscriptionPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new OcpprouterSubscriptionBody(); // OcpprouterSubscriptionBody | 

            try
            {
                apiInstance.DataOcpprouterSubscriptionPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataOcpprouterSubscriptionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OcpprouterSubscriptionBody**](OcpprouterSubscriptionBody.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="datatransactionstariffdelete"></a>
# **DataTransactionsTariffDelete**
> void DataTransactionsTariffDelete (string id = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataTransactionsTariffDeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = id_example;  // string |  (optional) 

            try
            {
                apiInstance.DataTransactionsTariffDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataTransactionsTariffDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="datatransactionstariffget"></a>
# **DataTransactionsTariffGet**
> void DataTransactionsTariffGet (string id = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataTransactionsTariffGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = id_example;  // string |  (optional) 

            try
            {
                apiInstance.DataTransactionsTariffGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataTransactionsTariffGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="datatransactionstariffput"></a>
# **DataTransactionsTariffPut**
> void DataTransactionsTariffPut (TransactionsTariffBody body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataTransactionsTariffPutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new TransactionsTariffBody(); // TransactionsTariffBody | 

            try
            {
                apiInstance.DataTransactionsTariffPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataTransactionsTariffPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionsTariffBody**](TransactionsTariffBody.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="datatransactionstransactionget"></a>
# **DataTransactionsTransactionGet**
> void DataTransactionsTransactionGet (string stationId, string transactionId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataTransactionsTransactionGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var stationId = stationId_example;  // string | 
            var transactionId = transactionId_example;  // string | 

            try
            {
                apiInstance.DataTransactionsTransactionGet(stationId, transactionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DataTransactionsTransactionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **string**|  | 
 **transactionId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
