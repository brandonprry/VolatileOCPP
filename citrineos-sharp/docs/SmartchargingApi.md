# ocpp.citrineos.Api.SmartchargingApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataSmartchargingSystemConfigGet**](SmartchargingApi.md#datasmartchargingsystemconfigget) | **GET** /data/smartcharging/systemConfig | 
[**DataSmartchargingSystemConfigPut**](SmartchargingApi.md#datasmartchargingsystemconfigput) | **PUT** /data/smartcharging/systemConfig | 
[**OcppSmartchargingClearChargingProfilePost**](SmartchargingApi.md#ocppsmartchargingclearchargingprofilepost) | **POST** /ocpp/smartcharging/clearChargingProfile | 
[**OcppSmartchargingClearedChargingLimitPost**](SmartchargingApi.md#ocppsmartchargingclearedcharginglimitpost) | **POST** /ocpp/smartcharging/clearedChargingLimit | 
[**OcppSmartchargingGetChargingProfilesPost**](SmartchargingApi.md#ocppsmartcharginggetchargingprofilespost) | **POST** /ocpp/smartcharging/getChargingProfiles | 
[**OcppSmartchargingGetCompositeSchedulePost**](SmartchargingApi.md#ocppsmartcharginggetcompositeschedulepost) | **POST** /ocpp/smartcharging/getCompositeSchedule | 
[**OcppSmartchargingSetChargingProfilePost**](SmartchargingApi.md#ocppsmartchargingsetchargingprofilepost) | **POST** /ocpp/smartcharging/setChargingProfile | 

<a name="datasmartchargingsystemconfigget"></a>
# **DataSmartchargingSystemConfigGet**
> void DataSmartchargingSystemConfigGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class DataSmartchargingSystemConfigGetExample
    {
        public void main()
        {
            var apiInstance = new SmartchargingApi();

            try
            {
                apiInstance.DataSmartchargingSystemConfigGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmartchargingApi.DataSmartchargingSystemConfigGet: " + e.Message );
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
<a name="datasmartchargingsystemconfigput"></a>
# **DataSmartchargingSystemConfigPut**
> void DataSmartchargingSystemConfigPut ()



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class DataSmartchargingSystemConfigPutExample
    {
        public void main()
        {
            var apiInstance = new SmartchargingApi();

            try
            {
                apiInstance.DataSmartchargingSystemConfigPut();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmartchargingApi.DataSmartchargingSystemConfigPut: " + e.Message );
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
<a name="ocppsmartchargingclearchargingprofilepost"></a>
# **OcppSmartchargingClearChargingProfilePost**
> void OcppSmartchargingClearChargingProfilePost (string identifier, string tenantId, SmartchargingClearChargingProfileBody body = null, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppSmartchargingClearChargingProfilePostExample
    {
        public void main()
        {
            var apiInstance = new SmartchargingApi();
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var body = new SmartchargingClearChargingProfileBody(); // SmartchargingClearChargingProfileBody |  (optional) 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppSmartchargingClearChargingProfilePost(identifier, tenantId, body, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmartchargingApi.OcppSmartchargingClearChargingProfilePost: " + e.Message );
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
 **body** | [**SmartchargingClearChargingProfileBody**](SmartchargingClearChargingProfileBody.md)|  | [optional] 
 **callbackUrl** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ocppsmartchargingclearedcharginglimitpost"></a>
# **OcppSmartchargingClearedChargingLimitPost**
> void OcppSmartchargingClearedChargingLimitPost (SmartchargingClearedChargingLimitBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppSmartchargingClearedChargingLimitPostExample
    {
        public void main()
        {
            var apiInstance = new SmartchargingApi();
            var body = new SmartchargingClearedChargingLimitBody(); // SmartchargingClearedChargingLimitBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppSmartchargingClearedChargingLimitPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmartchargingApi.OcppSmartchargingClearedChargingLimitPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SmartchargingClearedChargingLimitBody**](SmartchargingClearedChargingLimitBody.md)|  | 
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
<a name="ocppsmartcharginggetchargingprofilespost"></a>
# **OcppSmartchargingGetChargingProfilesPost**
> void OcppSmartchargingGetChargingProfilesPost (SmartchargingGetChargingProfilesBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppSmartchargingGetChargingProfilesPostExample
    {
        public void main()
        {
            var apiInstance = new SmartchargingApi();
            var body = new SmartchargingGetChargingProfilesBody(); // SmartchargingGetChargingProfilesBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppSmartchargingGetChargingProfilesPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmartchargingApi.OcppSmartchargingGetChargingProfilesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SmartchargingGetChargingProfilesBody**](SmartchargingGetChargingProfilesBody.md)|  | 
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
<a name="ocppsmartcharginggetcompositeschedulepost"></a>
# **OcppSmartchargingGetCompositeSchedulePost**
> void OcppSmartchargingGetCompositeSchedulePost (SmartchargingGetCompositeScheduleBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppSmartchargingGetCompositeSchedulePostExample
    {
        public void main()
        {
            var apiInstance = new SmartchargingApi();
            var body = new SmartchargingGetCompositeScheduleBody(); // SmartchargingGetCompositeScheduleBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppSmartchargingGetCompositeSchedulePost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmartchargingApi.OcppSmartchargingGetCompositeSchedulePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SmartchargingGetCompositeScheduleBody**](SmartchargingGetCompositeScheduleBody.md)|  | 
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
<a name="ocppsmartchargingsetchargingprofilepost"></a>
# **OcppSmartchargingSetChargingProfilePost**
> void OcppSmartchargingSetChargingProfilePost (SmartchargingSetChargingProfileBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppSmartchargingSetChargingProfilePostExample
    {
        public void main()
        {
            var apiInstance = new SmartchargingApi();
            var body = new SmartchargingSetChargingProfileBody(); // SmartchargingSetChargingProfileBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppSmartchargingSetChargingProfilePost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmartchargingApi.OcppSmartchargingSetChargingProfilePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SmartchargingSetChargingProfileBody**](SmartchargingSetChargingProfileBody.md)|  | 
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
