# Finbourne.Luminesce.Sdk.Api.CurrentTableFieldCatalogApi

All URIs are relative to *https://www.lusid.com/honeycomb*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCatalog**](CurrentTableFieldCatalogApi.md#getcatalog) | **GET** /api/Catalog | [EXPERIMENTAL] GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)


<a name="getcatalog"></a>
# **GetCatalog**
> string GetCatalog (string freeTextSearch = null, bool? jsonProper = null)

[EXPERIMENTAL] GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)

 The following HoneycombSql is executed to return this information:  ```sql select     coalesce(f.TableName, r.Name) as TableName,     coalesce(f.FieldName, 'N/A') as FieldName,     f.DataType,     f.FieldType,     f.IsPrimaryKey,     f.IsMain,     case          when f.TableName is not null              then f.Description         else             r.Name || ' returns a different set of columns depending on use.'         end as Description,     f.ParamDefaultValue,     f.TableParamColumns,     min(r.Description) as ProviderDescription from     Sys.Registration r     left outer join Sys.Field f         on r.Name = f.TableName where     r.Type in ('DirectProvider', 'DataProvider')     and      r.ShowAll = false group by     1, 2, 3, 4, 5, 6, 8, 9 order by     1, 5 desc, 6 desc, 2     ```  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 

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

            try
            {
                // [EXPERIMENTAL] GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
                string result = apiInstance.GetCatalog(freeTextSearch, jsonProper);
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

