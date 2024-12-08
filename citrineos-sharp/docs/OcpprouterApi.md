# IO.Swagger.Api.OcpprouterApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataOcpprouterSystemConfigGet**](OcpprouterApi.md#dataocpproutersystemconfigget) | **GET** /data/ocpprouter/systemConfig | 
[**DataOcpprouterSystemConfigPut**](OcpprouterApi.md#dataocpproutersystemconfigput) | **PUT** /data/ocpprouter/systemConfig | 

<a name="dataocpproutersystemconfigget"></a>
# **DataOcpprouterSystemConfigGet**
> void DataOcpprouterSystemConfigGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataOcpprouterSystemConfigGetExample
    {
        public void main()
        {
            var apiInstance = new OcpprouterApi();

            try
            {
                apiInstance.DataOcpprouterSystemConfigGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OcpprouterApi.DataOcpprouterSystemConfigGet: " + e.Message );
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
<a name="dataocpproutersystemconfigput"></a>
# **DataOcpprouterSystemConfigPut**
> void DataOcpprouterSystemConfigPut ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataOcpprouterSystemConfigPutExample
    {
        public void main()
        {
            var apiInstance = new OcpprouterApi();

            try
            {
                apiInstance.DataOcpprouterSystemConfigPut();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OcpprouterApi.DataOcpprouterSystemConfigPut: " + e.Message );
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
