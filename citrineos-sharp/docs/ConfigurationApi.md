# ocpp.citrineos.Api.ConfigurationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataConfigurationSystemConfigGet**](ConfigurationApi.md#dataconfigurationsystemconfigget) | **GET** /data/configuration/systemConfig | 
[**DataConfigurationSystemConfigPut**](ConfigurationApi.md#dataconfigurationsystemconfigput) | **PUT** /data/configuration/systemConfig | 
[**OcppConfigurationChangeAvailabilityPost**](ConfigurationApi.md#ocppconfigurationchangeavailabilitypost) | **POST** /ocpp/configuration/changeAvailability | 
[**OcppConfigurationClearDisplayMessagePost**](ConfigurationApi.md#ocppconfigurationcleardisplaymessagepost) | **POST** /ocpp/configuration/clearDisplayMessage | 
[**OcppConfigurationGetDisplayMessagesPost**](ConfigurationApi.md#ocppconfigurationgetdisplaymessagespost) | **POST** /ocpp/configuration/getDisplayMessages | 
[**OcppConfigurationPublishFirmwarePost**](ConfigurationApi.md#ocppconfigurationpublishfirmwarepost) | **POST** /ocpp/configuration/publishFirmware | 
[**OcppConfigurationResetPost**](ConfigurationApi.md#ocppconfigurationresetpost) | **POST** /ocpp/configuration/reset | 
[**OcppConfigurationSetDisplayMessagePost**](ConfigurationApi.md#ocppconfigurationsetdisplaymessagepost) | **POST** /ocpp/configuration/setDisplayMessage | 
[**OcppConfigurationSetNetworkProfilePost**](ConfigurationApi.md#ocppconfigurationsetnetworkprofilepost) | **POST** /ocpp/configuration/setNetworkProfile | 
[**OcppConfigurationTriggerMessagePost**](ConfigurationApi.md#ocppconfigurationtriggermessagepost) | **POST** /ocpp/configuration/triggerMessage | 
[**OcppConfigurationUnpublishFirmwarePost**](ConfigurationApi.md#ocppconfigurationunpublishfirmwarepost) | **POST** /ocpp/configuration/unpublishFirmware | 
[**OcppConfigurationUpdateFirmwarePost**](ConfigurationApi.md#ocppconfigurationupdatefirmwarepost) | **POST** /ocpp/configuration/updateFirmware | 

<a name="dataconfigurationsystemconfigget"></a>
# **DataConfigurationSystemConfigGet**
> void DataConfigurationSystemConfigGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class DataConfigurationSystemConfigGetExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationApi();

            try
            {
                apiInstance.DataConfigurationSystemConfigGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.DataConfigurationSystemConfigGet: " + e.Message );
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
<a name="dataconfigurationsystemconfigput"></a>
# **DataConfigurationSystemConfigPut**
> void DataConfigurationSystemConfigPut ()



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class DataConfigurationSystemConfigPutExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationApi();

            try
            {
                apiInstance.DataConfigurationSystemConfigPut();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.DataConfigurationSystemConfigPut: " + e.Message );
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
<a name="ocppconfigurationchangeavailabilitypost"></a>
# **OcppConfigurationChangeAvailabilityPost**
> void OcppConfigurationChangeAvailabilityPost (ConfigurationChangeAvailabilityBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppConfigurationChangeAvailabilityPostExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationApi();
            var body = new ConfigurationChangeAvailabilityBody(); // ConfigurationChangeAvailabilityBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppConfigurationChangeAvailabilityPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.OcppConfigurationChangeAvailabilityPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConfigurationChangeAvailabilityBody**](ConfigurationChangeAvailabilityBody.md)|  | 
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
<a name="ocppconfigurationcleardisplaymessagepost"></a>
# **OcppConfigurationClearDisplayMessagePost**
> void OcppConfigurationClearDisplayMessagePost (ConfigurationClearDisplayMessageBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppConfigurationClearDisplayMessagePostExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationApi();
            var body = new ConfigurationClearDisplayMessageBody(); // ConfigurationClearDisplayMessageBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppConfigurationClearDisplayMessagePost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.OcppConfigurationClearDisplayMessagePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConfigurationClearDisplayMessageBody**](ConfigurationClearDisplayMessageBody.md)|  | 
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
<a name="ocppconfigurationgetdisplaymessagespost"></a>
# **OcppConfigurationGetDisplayMessagesPost**
> void OcppConfigurationGetDisplayMessagesPost (ConfigurationGetDisplayMessagesBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppConfigurationGetDisplayMessagesPostExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationApi();
            var body = new ConfigurationGetDisplayMessagesBody(); // ConfigurationGetDisplayMessagesBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppConfigurationGetDisplayMessagesPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.OcppConfigurationGetDisplayMessagesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConfigurationGetDisplayMessagesBody**](ConfigurationGetDisplayMessagesBody.md)|  | 
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
<a name="ocppconfigurationpublishfirmwarepost"></a>
# **OcppConfigurationPublishFirmwarePost**
> void OcppConfigurationPublishFirmwarePost (ConfigurationPublishFirmwareBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppConfigurationPublishFirmwarePostExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationApi();
            var body = new ConfigurationPublishFirmwareBody(); // ConfigurationPublishFirmwareBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppConfigurationPublishFirmwarePost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.OcppConfigurationPublishFirmwarePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConfigurationPublishFirmwareBody**](ConfigurationPublishFirmwareBody.md)|  | 
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
<a name="ocppconfigurationresetpost"></a>
# **OcppConfigurationResetPost**
> void OcppConfigurationResetPost (ConfigurationResetBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppConfigurationResetPostExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationApi();
            var body = new ConfigurationResetBody(); // ConfigurationResetBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppConfigurationResetPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.OcppConfigurationResetPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConfigurationResetBody**](ConfigurationResetBody.md)|  | 
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
<a name="ocppconfigurationsetdisplaymessagepost"></a>
# **OcppConfigurationSetDisplayMessagePost**
> void OcppConfigurationSetDisplayMessagePost (ConfigurationSetDisplayMessageBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppConfigurationSetDisplayMessagePostExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationApi();
            var body = new ConfigurationSetDisplayMessageBody(); // ConfigurationSetDisplayMessageBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppConfigurationSetDisplayMessagePost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.OcppConfigurationSetDisplayMessagePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConfigurationSetDisplayMessageBody**](ConfigurationSetDisplayMessageBody.md)|  | 
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
<a name="ocppconfigurationsetnetworkprofilepost"></a>
# **OcppConfigurationSetNetworkProfilePost**
> void OcppConfigurationSetNetworkProfilePost (ConfigurationSetNetworkProfileBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppConfigurationSetNetworkProfilePostExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationApi();
            var body = new ConfigurationSetNetworkProfileBody(); // ConfigurationSetNetworkProfileBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppConfigurationSetNetworkProfilePost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.OcppConfigurationSetNetworkProfilePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConfigurationSetNetworkProfileBody**](ConfigurationSetNetworkProfileBody.md)|  | 
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
<a name="ocppconfigurationtriggermessagepost"></a>
# **OcppConfigurationTriggerMessagePost**
> void OcppConfigurationTriggerMessagePost (ConfigurationTriggerMessageBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppConfigurationTriggerMessagePostExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationApi();
            var body = new ConfigurationTriggerMessageBody(); // ConfigurationTriggerMessageBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppConfigurationTriggerMessagePost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.OcppConfigurationTriggerMessagePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConfigurationTriggerMessageBody**](ConfigurationTriggerMessageBody.md)|  | 
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
<a name="ocppconfigurationunpublishfirmwarepost"></a>
# **OcppConfigurationUnpublishFirmwarePost**
> void OcppConfigurationUnpublishFirmwarePost (ConfigurationUnpublishFirmwareBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppConfigurationUnpublishFirmwarePostExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationApi();
            var body = new ConfigurationUnpublishFirmwareBody(); // ConfigurationUnpublishFirmwareBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppConfigurationUnpublishFirmwarePost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.OcppConfigurationUnpublishFirmwarePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConfigurationUnpublishFirmwareBody**](ConfigurationUnpublishFirmwareBody.md)|  | 
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
<a name="ocppconfigurationupdatefirmwarepost"></a>
# **OcppConfigurationUpdateFirmwarePost**
> void OcppConfigurationUpdateFirmwarePost (ConfigurationUpdateFirmwareBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ocpp.citrineos.Api;
using ocpp.citrineos.Client;
using ocpp.citrineos.Model;

namespace Example
{
    public class OcppConfigurationUpdateFirmwarePostExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationApi();
            var body = new ConfigurationUpdateFirmwareBody(); // ConfigurationUpdateFirmwareBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppConfigurationUpdateFirmwarePost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.OcppConfigurationUpdateFirmwarePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConfigurationUpdateFirmwareBody**](ConfigurationUpdateFirmwareBody.md)|  | 
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
