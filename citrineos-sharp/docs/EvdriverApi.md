# ocpp.citrineos.Api.EvdriverApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataEvdriverSystemConfigGet**](EvdriverApi.md#dataevdriversystemconfigget) | **GET** /data/evdriver/systemConfig | 
[**DataEvdriverSystemConfigPut**](EvdriverApi.md#dataevdriversystemconfigput) | **PUT** /data/evdriver/systemConfig | 
[**OcppEvdriverCancelReservationPost**](EvdriverApi.md#ocppevdrivercancelreservationpost) | **POST** /ocpp/evdriver/cancelReservation | 
[**OcppEvdriverClearCachePost**](EvdriverApi.md#ocppevdriverclearcachepost) | **POST** /ocpp/evdriver/clearCache | 
[**OcppEvdriverGetLocalListVersionPost**](EvdriverApi.md#ocppevdrivergetlocallistversionpost) | **POST** /ocpp/evdriver/getLocalListVersion | 
[**OcppEvdriverRequestStartTransactionPost**](EvdriverApi.md#ocppevdriverrequeststarttransactionpost) | **POST** /ocpp/evdriver/requestStartTransaction | 
[**OcppEvdriverRequestStopTransactionPost**](EvdriverApi.md#ocppevdriverrequeststoptransactionpost) | **POST** /ocpp/evdriver/requestStopTransaction | 
[**OcppEvdriverReserveNowPost**](EvdriverApi.md#ocppevdriverreservenowpost) | **POST** /ocpp/evdriver/reserveNow | 
[**OcppEvdriverSendLocalListPost**](EvdriverApi.md#ocppevdriversendlocallistpost) | **POST** /ocpp/evdriver/sendLocalList | 
[**OcppEvdriverUnlockConnectorPost**](EvdriverApi.md#ocppevdriverunlockconnectorpost) | **POST** /ocpp/evdriver/unlockConnector | 

<a name="dataevdriversystemconfigget"></a>
# **DataEvdriverSystemConfigGet**
> void DataEvdriverSystemConfigGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class DataEvdriverSystemConfigGetExample
    {
        public void main()
        {
            var apiInstance = new EvdriverApi();

            try
            {
                apiInstance.DataEvdriverSystemConfigGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvdriverApi.DataEvdriverSystemConfigGet: " + e.Message );
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
<a name="dataevdriversystemconfigput"></a>
# **DataEvdriverSystemConfigPut**
> void DataEvdriverSystemConfigPut ()



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class DataEvdriverSystemConfigPutExample
    {
        public void main()
        {
            var apiInstance = new EvdriverApi();

            try
            {
                apiInstance.DataEvdriverSystemConfigPut();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvdriverApi.DataEvdriverSystemConfigPut: " + e.Message );
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
<a name="ocppevdrivercancelreservationpost"></a>
# **OcppEvdriverCancelReservationPost**
> void OcppEvdriverCancelReservationPost (EvdriverCancelReservationBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppEvdriverCancelReservationPostExample
    {
        public void main()
        {
            var apiInstance = new EvdriverApi();
            var body = new EvdriverCancelReservationBody(); // EvdriverCancelReservationBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppEvdriverCancelReservationPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvdriverApi.OcppEvdriverCancelReservationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EvdriverCancelReservationBody**](EvdriverCancelReservationBody.md)|  | 
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
<a name="ocppevdriverclearcachepost"></a>
# **OcppEvdriverClearCachePost**
> void OcppEvdriverClearCachePost (string identifier, string tenantId, EvdriverClearCacheBody body = null, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppEvdriverClearCachePostExample
    {
        public void main()
        {
            var apiInstance = new EvdriverApi();
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var body = new EvdriverClearCacheBody(); // EvdriverClearCacheBody |  (optional) 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppEvdriverClearCachePost(identifier, tenantId, body, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvdriverApi.OcppEvdriverClearCachePost: " + e.Message );
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
 **body** | [**EvdriverClearCacheBody**](EvdriverClearCacheBody.md)|  | [optional] 
 **callbackUrl** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ocppevdrivergetlocallistversionpost"></a>
# **OcppEvdriverGetLocalListVersionPost**
> void OcppEvdriverGetLocalListVersionPost (string identifier, string tenantId, EvdriverGetLocalListVersionBody body = null, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppEvdriverGetLocalListVersionPostExample
    {
        public void main()
        {
            var apiInstance = new EvdriverApi();
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var body = new EvdriverGetLocalListVersionBody(); // EvdriverGetLocalListVersionBody |  (optional) 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppEvdriverGetLocalListVersionPost(identifier, tenantId, body, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvdriverApi.OcppEvdriverGetLocalListVersionPost: " + e.Message );
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
 **body** | [**EvdriverGetLocalListVersionBody**](EvdriverGetLocalListVersionBody.md)|  | [optional] 
 **callbackUrl** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ocppevdriverrequeststarttransactionpost"></a>
# **OcppEvdriverRequestStartTransactionPost**
> void OcppEvdriverRequestStartTransactionPost (EvdriverRequestStartTransactionBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppEvdriverRequestStartTransactionPostExample
    {
        public void main()
        {
            var apiInstance = new EvdriverApi();
            var body = new EvdriverRequestStartTransactionBody(); // EvdriverRequestStartTransactionBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppEvdriverRequestStartTransactionPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvdriverApi.OcppEvdriverRequestStartTransactionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EvdriverRequestStartTransactionBody**](EvdriverRequestStartTransactionBody.md)|  | 
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
<a name="ocppevdriverrequeststoptransactionpost"></a>
# **OcppEvdriverRequestStopTransactionPost**
> void OcppEvdriverRequestStopTransactionPost (EvdriverRequestStopTransactionBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppEvdriverRequestStopTransactionPostExample
    {
        public void main()
        {
            var apiInstance = new EvdriverApi();
            var body = new EvdriverRequestStopTransactionBody(); // EvdriverRequestStopTransactionBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppEvdriverRequestStopTransactionPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvdriverApi.OcppEvdriverRequestStopTransactionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EvdriverRequestStopTransactionBody**](EvdriverRequestStopTransactionBody.md)|  | 
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
<a name="ocppevdriverreservenowpost"></a>
# **OcppEvdriverReserveNowPost**
> void OcppEvdriverReserveNowPost (EvdriverReserveNowBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppEvdriverReserveNowPostExample
    {
        public void main()
        {
            var apiInstance = new EvdriverApi();
            var body = new EvdriverReserveNowBody(); // EvdriverReserveNowBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppEvdriverReserveNowPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvdriverApi.OcppEvdriverReserveNowPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EvdriverReserveNowBody**](EvdriverReserveNowBody.md)|  | 
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
<a name="ocppevdriversendlocallistpost"></a>
# **OcppEvdriverSendLocalListPost**
> void OcppEvdriverSendLocalListPost (EvdriverSendLocalListBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppEvdriverSendLocalListPostExample
    {
        public void main()
        {
            var apiInstance = new EvdriverApi();
            var body = new EvdriverSendLocalListBody(); // EvdriverSendLocalListBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppEvdriverSendLocalListPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvdriverApi.OcppEvdriverSendLocalListPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EvdriverSendLocalListBody**](EvdriverSendLocalListBody.md)|  | 
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
<a name="ocppevdriverunlockconnectorpost"></a>
# **OcppEvdriverUnlockConnectorPost**
> void OcppEvdriverUnlockConnectorPost (EvdriverUnlockConnectorBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppEvdriverUnlockConnectorPostExample
    {
        public void main()
        {
            var apiInstance = new EvdriverApi();
            var body = new EvdriverUnlockConnectorBody(); // EvdriverUnlockConnectorBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppEvdriverUnlockConnectorPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvdriverApi.OcppEvdriverUnlockConnectorPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EvdriverUnlockConnectorBody**](EvdriverUnlockConnectorBody.md)|  | 
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
