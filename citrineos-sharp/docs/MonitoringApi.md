# ocpp.citrineos.Api.MonitoringApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataMonitoringSystemConfigGet**](MonitoringApi.md#datamonitoringsystemconfigget) | **GET** /data/monitoring/systemConfig | 
[**DataMonitoringSystemConfigPut**](MonitoringApi.md#datamonitoringsystemconfigput) | **PUT** /data/monitoring/systemConfig | 
[**OcppMonitoringClearVariableMonitoringPost**](MonitoringApi.md#ocppmonitoringclearvariablemonitoringpost) | **POST** /ocpp/monitoring/clearVariableMonitoring | 
[**OcppMonitoringGetVariablesPost**](MonitoringApi.md#ocppmonitoringgetvariablespost) | **POST** /ocpp/monitoring/getVariables | 
[**OcppMonitoringSetMonitoringBasePost**](MonitoringApi.md#ocppmonitoringsetmonitoringbasepost) | **POST** /ocpp/monitoring/setMonitoringBase | 
[**OcppMonitoringSetMonitoringLevelPost**](MonitoringApi.md#ocppmonitoringsetmonitoringlevelpost) | **POST** /ocpp/monitoring/setMonitoringLevel | 
[**OcppMonitoringSetVariableMonitoringPost**](MonitoringApi.md#ocppmonitoringsetvariablemonitoringpost) | **POST** /ocpp/monitoring/setVariableMonitoring | 
[**OcppMonitoringSetVariablesPost**](MonitoringApi.md#ocppmonitoringsetvariablespost) | **POST** /ocpp/monitoring/setVariables | 

<a name="datamonitoringsystemconfigget"></a>
# **DataMonitoringSystemConfigGet**
> void DataMonitoringSystemConfigGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class DataMonitoringSystemConfigGetExample
    {
        public void main()
        {
            var apiInstance = new MonitoringApi();

            try
            {
                apiInstance.DataMonitoringSystemConfigGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoringApi.DataMonitoringSystemConfigGet: " + e.Message );
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
<a name="datamonitoringsystemconfigput"></a>
# **DataMonitoringSystemConfigPut**
> void DataMonitoringSystemConfigPut ()



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class DataMonitoringSystemConfigPutExample
    {
        public void main()
        {
            var apiInstance = new MonitoringApi();

            try
            {
                apiInstance.DataMonitoringSystemConfigPut();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoringApi.DataMonitoringSystemConfigPut: " + e.Message );
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
<a name="ocppmonitoringclearvariablemonitoringpost"></a>
# **OcppMonitoringClearVariableMonitoringPost**
> void OcppMonitoringClearVariableMonitoringPost (MonitoringClearVariableMonitoringBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppMonitoringClearVariableMonitoringPostExample
    {
        public void main()
        {
            var apiInstance = new MonitoringApi();
            var body = new MonitoringClearVariableMonitoringBody(); // MonitoringClearVariableMonitoringBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppMonitoringClearVariableMonitoringPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoringApi.OcppMonitoringClearVariableMonitoringPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MonitoringClearVariableMonitoringBody**](MonitoringClearVariableMonitoringBody.md)|  | 
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
<a name="ocppmonitoringgetvariablespost"></a>
# **OcppMonitoringGetVariablesPost**
> void OcppMonitoringGetVariablesPost (MonitoringGetVariablesBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppMonitoringGetVariablesPostExample
    {
        public void main()
        {
            var apiInstance = new MonitoringApi();
            var body = new MonitoringGetVariablesBody(); // MonitoringGetVariablesBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppMonitoringGetVariablesPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoringApi.OcppMonitoringGetVariablesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MonitoringGetVariablesBody**](MonitoringGetVariablesBody.md)|  | 
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
<a name="ocppmonitoringsetmonitoringbasepost"></a>
# **OcppMonitoringSetMonitoringBasePost**
> void OcppMonitoringSetMonitoringBasePost (MonitoringSetMonitoringBaseBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppMonitoringSetMonitoringBasePostExample
    {
        public void main()
        {
            var apiInstance = new MonitoringApi();
            var body = new MonitoringSetMonitoringBaseBody(); // MonitoringSetMonitoringBaseBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppMonitoringSetMonitoringBasePost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoringApi.OcppMonitoringSetMonitoringBasePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MonitoringSetMonitoringBaseBody**](MonitoringSetMonitoringBaseBody.md)|  | 
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
<a name="ocppmonitoringsetmonitoringlevelpost"></a>
# **OcppMonitoringSetMonitoringLevelPost**
> void OcppMonitoringSetMonitoringLevelPost (MonitoringSetMonitoringLevelBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppMonitoringSetMonitoringLevelPostExample
    {
        public void main()
        {
            var apiInstance = new MonitoringApi();
            var body = new MonitoringSetMonitoringLevelBody(); // MonitoringSetMonitoringLevelBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppMonitoringSetMonitoringLevelPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoringApi.OcppMonitoringSetMonitoringLevelPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MonitoringSetMonitoringLevelBody**](MonitoringSetMonitoringLevelBody.md)|  | 
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
<a name="ocppmonitoringsetvariablemonitoringpost"></a>
# **OcppMonitoringSetVariableMonitoringPost**
> void OcppMonitoringSetVariableMonitoringPost (MonitoringSetVariableMonitoringBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppMonitoringSetVariableMonitoringPostExample
    {
        public void main()
        {
            var apiInstance = new MonitoringApi();
            var body = new MonitoringSetVariableMonitoringBody(); // MonitoringSetVariableMonitoringBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppMonitoringSetVariableMonitoringPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoringApi.OcppMonitoringSetVariableMonitoringPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MonitoringSetVariableMonitoringBody**](MonitoringSetVariableMonitoringBody.md)|  | 
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
<a name="ocppmonitoringsetvariablespost"></a>
# **OcppMonitoringSetVariablesPost**
> void OcppMonitoringSetVariablesPost (MonitoringSetVariablesBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppMonitoringSetVariablesPostExample
    {
        public void main()
        {
            var apiInstance = new MonitoringApi();
            var body = new MonitoringSetVariablesBody(); // MonitoringSetVariablesBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppMonitoringSetVariablesPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoringApi.OcppMonitoringSetVariablesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MonitoringSetVariablesBody**](MonitoringSetVariablesBody.md)|  | 
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
