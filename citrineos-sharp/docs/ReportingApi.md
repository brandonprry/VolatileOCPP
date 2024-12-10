# IO.Swagger.Api.ReportingApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataReportingSystemConfigGet**](ReportingApi.md#datareportingsystemconfigget) | **GET** /data/reporting/systemConfig | 
[**DataReportingSystemConfigPut**](ReportingApi.md#datareportingsystemconfigput) | **PUT** /data/reporting/systemConfig | 
[**OcppReportingCustomerInformationPost**](ReportingApi.md#ocppreportingcustomerinformationpost) | **POST** /ocpp/reporting/customerInformation | 
[**OcppReportingGetBaseReportPost**](ReportingApi.md#ocppreportinggetbasereportpost) | **POST** /ocpp/reporting/getBaseReport | 
[**OcppReportingGetLogPost**](ReportingApi.md#ocppreportinggetlogpost) | **POST** /ocpp/reporting/getLog | 
[**OcppReportingGetMonitoringReportPost**](ReportingApi.md#ocppreportinggetmonitoringreportpost) | **POST** /ocpp/reporting/getMonitoringReport | 
[**OcppReportingGetReportPost**](ReportingApi.md#ocppreportinggetreportpost) | **POST** /ocpp/reporting/getReport | 

<a name="datareportingsystemconfigget"></a>
# **DataReportingSystemConfigGet**
> void DataReportingSystemConfigGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataReportingSystemConfigGetExample
    {
        public void main()
        {
            var apiInstance = new ReportingApi();

            try
            {
                apiInstance.DataReportingSystemConfigGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingApi.DataReportingSystemConfigGet: " + e.Message );
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
<a name="datareportingsystemconfigput"></a>
# **DataReportingSystemConfigPut**
> void DataReportingSystemConfigPut ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataReportingSystemConfigPutExample
    {
        public void main()
        {
            var apiInstance = new ReportingApi();

            try
            {
                apiInstance.DataReportingSystemConfigPut();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingApi.DataReportingSystemConfigPut: " + e.Message );
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
<a name="ocppreportingcustomerinformationpost"></a>
# **OcppReportingCustomerInformationPost**
> void OcppReportingCustomerInformationPost (ReportingCustomerInformationBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OcppReportingCustomerInformationPostExample
    {
        public void main()
        {
            var apiInstance = new ReportingApi();
            var body = new ReportingCustomerInformationBody(); // ReportingCustomerInformationBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppReportingCustomerInformationPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingApi.OcppReportingCustomerInformationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportingCustomerInformationBody**](ReportingCustomerInformationBody.md)|  | 
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
<a name="ocppreportinggetbasereportpost"></a>
# **OcppReportingGetBaseReportPost**
> void OcppReportingGetBaseReportPost (ReportingGetBaseReportBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OcppReportingGetBaseReportPostExample
    {
        public void main()
        {
            var apiInstance = new ReportingApi();
            var body = new ReportingGetBaseReportBody(); // ReportingGetBaseReportBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppReportingGetBaseReportPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingApi.OcppReportingGetBaseReportPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportingGetBaseReportBody**](ReportingGetBaseReportBody.md)|  | 
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
<a name="ocppreportinggetlogpost"></a>
# **OcppReportingGetLogPost**
> void OcppReportingGetLogPost (ReportingGetLogBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OcppReportingGetLogPostExample
    {
        public void main()
        {
            var apiInstance = new ReportingApi();
            var body = new ReportingGetLogBody(); // ReportingGetLogBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppReportingGetLogPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingApi.OcppReportingGetLogPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportingGetLogBody**](ReportingGetLogBody.md)|  | 
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
<a name="ocppreportinggetmonitoringreportpost"></a>
# **OcppReportingGetMonitoringReportPost**
> void OcppReportingGetMonitoringReportPost (ReportingGetMonitoringReportBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OcppReportingGetMonitoringReportPostExample
    {
        public void main()
        {
            var apiInstance = new ReportingApi();
            var body = new ReportingGetMonitoringReportBody(); // ReportingGetMonitoringReportBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppReportingGetMonitoringReportPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingApi.OcppReportingGetMonitoringReportPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportingGetMonitoringReportBody**](ReportingGetMonitoringReportBody.md)|  | 
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
<a name="ocppreportinggetreportpost"></a>
# **OcppReportingGetReportPost**
> void OcppReportingGetReportPost (ReportingGetReportBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OcppReportingGetReportPostExample
    {
        public void main()
        {
            var apiInstance = new ReportingApi();
            var body = new ReportingGetReportBody(); // ReportingGetReportBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppReportingGetReportPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingApi.OcppReportingGetReportPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportingGetReportBody**](ReportingGetReportBody.md)|  | 
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
