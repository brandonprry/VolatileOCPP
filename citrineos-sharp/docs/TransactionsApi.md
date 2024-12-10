# IO.Swagger.Api.TransactionsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataTransactionsSystemConfigGet**](TransactionsApi.md#datatransactionssystemconfigget) | **GET** /data/transactions/systemConfig | 
[**DataTransactionsSystemConfigPut**](TransactionsApi.md#datatransactionssystemconfigput) | **PUT** /data/transactions/systemConfig | 
[**OcppTransactionsCostUpdatedPost**](TransactionsApi.md#ocpptransactionscostupdatedpost) | **POST** /ocpp/transactions/costUpdated | 
[**OcppTransactionsGetTransactionStatusPost**](TransactionsApi.md#ocpptransactionsgettransactionstatuspost) | **POST** /ocpp/transactions/getTransactionStatus | 

<a name="datatransactionssystemconfigget"></a>
# **DataTransactionsSystemConfigGet**
> void DataTransactionsSystemConfigGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataTransactionsSystemConfigGetExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();

            try
            {
                apiInstance.DataTransactionsSystemConfigGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.DataTransactionsSystemConfigGet: " + e.Message );
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
<a name="datatransactionssystemconfigput"></a>
# **DataTransactionsSystemConfigPut**
> void DataTransactionsSystemConfigPut ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DataTransactionsSystemConfigPutExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();

            try
            {
                apiInstance.DataTransactionsSystemConfigPut();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.DataTransactionsSystemConfigPut: " + e.Message );
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
<a name="ocpptransactionscostupdatedpost"></a>
# **OcppTransactionsCostUpdatedPost**
> void OcppTransactionsCostUpdatedPost (TransactionsCostUpdatedBody body, string identifier, string tenantId, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OcppTransactionsCostUpdatedPostExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();
            var body = new TransactionsCostUpdatedBody(); // TransactionsCostUpdatedBody | 
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppTransactionsCostUpdatedPost(body, identifier, tenantId, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.OcppTransactionsCostUpdatedPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionsCostUpdatedBody**](TransactionsCostUpdatedBody.md)|  | 
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
<a name="ocpptransactionsgettransactionstatuspost"></a>
# **OcppTransactionsGetTransactionStatusPost**
> void OcppTransactionsGetTransactionStatusPost (string identifier, string tenantId, TransactionsGetTransactionStatusBody body = null, string callbackUrl = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OcppTransactionsGetTransactionStatusPostExample
    {
        public void main()
        {
            var apiInstance = new TransactionsApi();
            var identifier = identifier_example;  // string | 
            var tenantId = tenantId_example;  // string | 
            var body = new TransactionsGetTransactionStatusBody(); // TransactionsGetTransactionStatusBody |  (optional) 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 

            try
            {
                apiInstance.OcppTransactionsGetTransactionStatusPost(identifier, tenantId, body, callbackUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.OcppTransactionsGetTransactionStatusPost: " + e.Message );
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
 **body** | [**TransactionsGetTransactionStatusBody**](TransactionsGetTransactionStatusBody.md)|  | [optional] 
 **callbackUrl** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
