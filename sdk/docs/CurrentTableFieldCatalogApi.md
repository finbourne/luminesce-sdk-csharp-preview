# Finbourne.Luminesce.Sdk.Api.CurrentTableFieldCatalogApi

All URIs are relative to *https://www.lusid.com/honeycomb*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCatalog**](CurrentTableFieldCatalogApi.md#getcatalog) | **GET** /api/Catalog | GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
[**GetFields**](CurrentTableFieldCatalogApi.md#getfields) | **GET** /api/Catalog/fields | GetFields: Shows Table level information on Providers that are currently running that you have access to (in Json format)
[**GetProviders**](CurrentTableFieldCatalogApi.md#getproviders) | **GET** /api/Catalog/providers | GetProviders: Shows Table level information on Providers that are currently running that you have access to (in Json format)


<a name="getcatalog"></a>
# **GetCatalog**
> string GetCatalog (string freeTextSearch = null, bool? jsonProper = null, bool? useCache = null)

GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)

 Returns the User's full version of the catalog (Providers and their fields)  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CurrentTableFieldCatalogApi(config);
            var freeTextSearch = freeTextSearch_example;  // string | Limit the catalog to only things in some way dealing with the passed in text string (optional) 
            var jsonProper = true;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)
            var useCache = true;  // bool? | Should the available cache be used? false is effectively to pick up a change in the catalog (optional)  (default to false)

            try
            {
                // GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
                string result = apiInstance.GetCatalog(freeTextSearch, jsonProper, useCache);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrentTableFieldCatalogApi.GetCatalog: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **freeTextSearch** | **string**| Limit the catalog to only things in some way dealing with the passed in text string | [optional] 
 **jsonProper** | **bool?**| Should this be text/json (not json-encoded-as-a-string) | [optional] [default to false]
 **useCache** | **bool?**| Should the available cache be used? false is effectively to pick up a change in the catalog | [optional] [default to false]

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfields"></a>
# **GetFields**
> string GetFields (string tableLike = null)

GetFields: Shows Table level information on Providers that are currently running that you have access to (in Json format)

 Returns the User's full version of the catalog but only the field/parameter-level information  (as well as the TableName they refer to, of course) for tables matching the `tableLike` (manually include wildcards if desired).  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CurrentTableFieldCatalogApi(config);
            var tableLike = tableLike_example;  // string |  (optional)  (default to "%")

            try
            {
                // GetFields: Shows Table level information on Providers that are currently running that you have access to (in Json format)
                string result = apiInstance.GetFields(tableLike);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrentTableFieldCatalogApi.GetFields: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableLike** | **string**|  | [optional] [default to &quot;%&quot;]

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproviders"></a>
# **GetProviders**
> string GetProviders (string freeTextSearch = null, bool? useCache = null)

GetProviders: Shows Table level information on Providers that are currently running that you have access to (in Json format)

 Returns the User's full version of the catalog but only the table/provider-level information  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CurrentTableFieldCatalogApi(config);
            var freeTextSearch = freeTextSearch_example;  // string | Limit the catalog to only things in some way dealing with the passed in text string (optional) 
            var useCache = true;  // bool? | Should the available cache be used? false is effectively to pick up a change in the catalog (optional)  (default to true)

            try
            {
                // GetProviders: Shows Table level information on Providers that are currently running that you have access to (in Json format)
                string result = apiInstance.GetProviders(freeTextSearch, useCache);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrentTableFieldCatalogApi.GetProviders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **freeTextSearch** | **string**| Limit the catalog to only things in some way dealing with the passed in text string | [optional] 
 **useCache** | **bool?**| Should the available cache be used? false is effectively to pick up a change in the catalog | [optional] [default to true]

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

