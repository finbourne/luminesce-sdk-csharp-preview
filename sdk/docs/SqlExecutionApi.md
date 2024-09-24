# Finbourne.Luminesce.Sdk.Api.SqlExecutionApi

All URIs are relative to *https://www.lusid.com/honeycomb*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetByQueryCsv**](SqlExecutionApi.md#getbyquerycsv) | **GET** /api/Sql/csv/{query} | GetByQueryCsv: Executes Sql from the url returning CSV
[**GetByQueryExcel**](SqlExecutionApi.md#getbyqueryexcel) | **GET** /api/Sql/excel/{query} | GetByQueryExcel: Executes Sql from the url returning an Excel file
[**GetByQueryJson**](SqlExecutionApi.md#getbyqueryjson) | **GET** /api/Sql/json/{query} | GetByQueryJson: Executes Sql from the url returning JSON
[**GetByQueryParquet**](SqlExecutionApi.md#getbyqueryparquet) | **GET** /api/Sql/parquet/{query} | GetByQueryParquet: Executes Sql from the url returning a Parquet file
[**GetByQueryPipe**](SqlExecutionApi.md#getbyquerypipe) | **GET** /api/Sql/pipe/{query} | GetByQueryPipe: Executes Sql from the url returning pipe-delimited
[**GetByQuerySqlite**](SqlExecutionApi.md#getbyquerysqlite) | **GET** /api/Sql/sqlite/{query} | GetByQuerySqlite: Executes Sql from the url returning SqLite DB
[**GetByQueryXml**](SqlExecutionApi.md#getbyqueryxml) | **GET** /api/Sql/xml/{query} | GetByQueryXml: Executes Sql from the url returning XML
[**PutByQueryCsv**](SqlExecutionApi.md#putbyquerycsv) | **PUT** /api/Sql/csv | PutByQueryCsv: Executes Sql from the body returning CSV
[**PutByQueryExcel**](SqlExecutionApi.md#putbyqueryexcel) | **PUT** /api/Sql/excel | PutByQueryExcel: Executes Sql from the body making an Excel file
[**PutByQueryJson**](SqlExecutionApi.md#putbyqueryjson) | **PUT** /api/Sql/json | PutByQueryJson: Executes Sql from the body returning JSON
[**PutByQueryParquet**](SqlExecutionApi.md#putbyqueryparquet) | **PUT** /api/Sql/parquet | PutByQueryParquet: Executes Sql from the body making a Parquet file
[**PutByQueryPipe**](SqlExecutionApi.md#putbyquerypipe) | **PUT** /api/Sql/pipe | PutByQueryPipe: Executes Sql from the body making pipe-delimited
[**PutByQuerySqlite**](SqlExecutionApi.md#putbyquerysqlite) | **PUT** /api/Sql/sqlite | PutByQuerySqlite: Executes Sql from the body returning SqLite DB
[**PutByQueryXml**](SqlExecutionApi.md#putbyqueryxml) | **PUT** /api/Sql/xml | PutByQueryXml: Executes Sql from the body returning XML


<a name="getbyquerycsv"></a>
# **GetByQueryCsv**
> string GetByQueryCsv (string query, Dictionary<string, string> scalarParameters = null, string queryName = null, bool? download = null, int? timeout = null, string delimiter = null, string escape = null)

GetByQueryCsv: Executes Sql from the url returning CSV

 Returns data from a simple single-line query execution which is specified on the url. e.g. `select ^ from Sys.Field order by 1, 2`, returned in the format of the method name.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetByQueryCsvExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var scalarParameters = new Dictionary<string, string>(); // Dictionary<string, string> | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = true;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)
            var delimiter = delimiter_example;  // string | Delimiter string to override the default (optional) 
            var escape = escape_example;  // string | Escape character to override the default (optional) 

            try
            {
                // GetByQueryCsv: Executes Sql from the url returning CSV
                string result = apiInstance.GetByQueryCsv(query, scalarParameters, queryName, download, timeout, delimiter, escape);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.GetByQueryCsv: " + e.Message );
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
 **query** | **string**| LuminesceSql to Execute (must be one line only) | 
 **scalarParameters** | [**Dictionary&lt;string, string&gt;**](string.md)| Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional] 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
 **download** | **bool?**| Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false]
 **timeout** | **int?**| In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0]
 **delimiter** | **string**| Delimiter string to override the default | [optional] 
 **escape** | **string**| Escape character to override the default | [optional] 

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
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyqueryexcel"></a>
# **GetByQueryExcel**
> System.IO.Stream GetByQueryExcel (string query, Dictionary<string, string> scalarParameters = null, string queryName = null, int? timeout = null)

GetByQueryExcel: Executes Sql from the url returning an Excel file

 Returns data from a simple single-line query execution which is specified on the url. e.g. `select ^ from Sys.Field order by 1, 2`, returned in the format of the method name.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetByQueryExcelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var scalarParameters = new Dictionary<string, string>(); // Dictionary<string, string> | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // GetByQueryExcel: Executes Sql from the url returning an Excel file
                System.IO.Stream result = apiInstance.GetByQueryExcel(query, scalarParameters, queryName, timeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.GetByQueryExcel: " + e.Message );
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
 **query** | **string**| LuminesceSql to Execute (must be one line only) | 
 **scalarParameters** | [**Dictionary&lt;string, string&gt;**](string.md)| Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional] 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
 **timeout** | **int?**| In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0]

### Return type

**System.IO.Stream**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyqueryjson"></a>
# **GetByQueryJson**
> string GetByQueryJson (string query, Dictionary<string, string> scalarParameters = null, string queryName = null, int? timeout = null, bool? jsonProper = null)

GetByQueryJson: Executes Sql from the url returning JSON

 Returns data from a simple single-line query execution which is specified on the url. e.g. `select ^ from Sys.Field order by 1, 2`, returned in the format of the method name.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetByQueryJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var scalarParameters = new Dictionary<string, string>(); // Dictionary<string, string> | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)
            var jsonProper = true;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)

            try
            {
                // GetByQueryJson: Executes Sql from the url returning JSON
                string result = apiInstance.GetByQueryJson(query, scalarParameters, queryName, timeout, jsonProper);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.GetByQueryJson: " + e.Message );
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
 **query** | **string**| LuminesceSql to Execute (must be one line only) | 
 **scalarParameters** | [**Dictionary&lt;string, string&gt;**](string.md)| Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional] 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
 **timeout** | **int?**| In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0]
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
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyqueryparquet"></a>
# **GetByQueryParquet**
> System.IO.Stream GetByQueryParquet (string query, Dictionary<string, string> scalarParameters = null, string queryName = null, int? timeout = null)

GetByQueryParquet: Executes Sql from the url returning a Parquet file

 Returns data from a simple single-line query execution which is specified on the url. e.g. `select ^ from Sys.Field order by 1, 2`, returned in the format of the method name.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetByQueryParquetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var scalarParameters = new Dictionary<string, string>(); // Dictionary<string, string> | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // GetByQueryParquet: Executes Sql from the url returning a Parquet file
                System.IO.Stream result = apiInstance.GetByQueryParquet(query, scalarParameters, queryName, timeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.GetByQueryParquet: " + e.Message );
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
 **query** | **string**| LuminesceSql to Execute (must be one line only) | 
 **scalarParameters** | [**Dictionary&lt;string, string&gt;**](string.md)| Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional] 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
 **timeout** | **int?**| In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0]

### Return type

**System.IO.Stream**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyquerypipe"></a>
# **GetByQueryPipe**
> string GetByQueryPipe (string query, Dictionary<string, string> scalarParameters = null, string queryName = null, bool? download = null, int? timeout = null)

GetByQueryPipe: Executes Sql from the url returning pipe-delimited

 Returns data from a simple single-line query execution which is specified on the url. e.g. `select ^ from Sys.Field order by 1, 2`, returned in the format of the method name.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetByQueryPipeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var scalarParameters = new Dictionary<string, string>(); // Dictionary<string, string> | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = true;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // GetByQueryPipe: Executes Sql from the url returning pipe-delimited
                string result = apiInstance.GetByQueryPipe(query, scalarParameters, queryName, download, timeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.GetByQueryPipe: " + e.Message );
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
 **query** | **string**| LuminesceSql to Execute (must be one line only) | 
 **scalarParameters** | [**Dictionary&lt;string, string&gt;**](string.md)| Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional] 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
 **download** | **bool?**| Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false]
 **timeout** | **int?**| In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0]

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
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyquerysqlite"></a>
# **GetByQuerySqlite**
> System.IO.Stream GetByQuerySqlite (string query, Dictionary<string, string> scalarParameters = null, string queryName = null, int? timeout = null)

GetByQuerySqlite: Executes Sql from the url returning SqLite DB

 Returns data from a simple single-line query execution which is specified on the url. e.g. `select ^ from Sys.Field order by 1, 2`, returned in the format of the method name.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetByQuerySqliteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var scalarParameters = new Dictionary<string, string>(); // Dictionary<string, string> | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // GetByQuerySqlite: Executes Sql from the url returning SqLite DB
                System.IO.Stream result = apiInstance.GetByQuerySqlite(query, scalarParameters, queryName, timeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.GetByQuerySqlite: " + e.Message );
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
 **query** | **string**| LuminesceSql to Execute (must be one line only) | 
 **scalarParameters** | [**Dictionary&lt;string, string&gt;**](string.md)| Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional] 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
 **timeout** | **int?**| In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0]

### Return type

**System.IO.Stream**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyqueryxml"></a>
# **GetByQueryXml**
> string GetByQueryXml (string query, Dictionary<string, string> scalarParameters = null, string queryName = null, bool? download = null, int? timeout = null)

GetByQueryXml: Executes Sql from the url returning XML

 Returns data from a simple single-line query execution which is specified on the url. e.g. `select ^ from Sys.Field order by 1, 2`, returned in the format of the method name.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetByQueryXmlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var scalarParameters = new Dictionary<string, string>(); // Dictionary<string, string> | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = true;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // GetByQueryXml: Executes Sql from the url returning XML
                string result = apiInstance.GetByQueryXml(query, scalarParameters, queryName, download, timeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.GetByQueryXml: " + e.Message );
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
 **query** | **string**| LuminesceSql to Execute (must be one line only) | 
 **scalarParameters** | [**Dictionary&lt;string, string&gt;**](string.md)| Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional] 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
 **download** | **bool?**| Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false]
 **timeout** | **int?**| In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0]

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
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbyquerycsv"></a>
# **PutByQueryCsv**
> string PutByQueryCsv (string body, Dictionary<string, string> scalarParameters = null, string queryName = null, bool? download = null, int? timeoutSeconds = null, string delimiter = null, string escape = null)

PutByQueryCsv: Executes Sql from the body returning CSV

 For more complex LuminesceSql a PUT will allow for longer and line break delimited Sql, whic will be returned in the format of the method name. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutByQueryCsvExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var scalarParameters = new Dictionary<string, string>(); // Dictionary<string, string> | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = true;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)
            var delimiter = delimiter_example;  // string | Delimiter string to override the default (optional) 
            var escape = escape_example;  // string | Escape character to override the default (optional) 

            try
            {
                // PutByQueryCsv: Executes Sql from the body returning CSV
                string result = apiInstance.PutByQueryCsv(body, scalarParameters, queryName, download, timeoutSeconds, delimiter, escape);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.PutByQueryCsv: " + e.Message );
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
 **body** | **string**| LuminesceSql to Execute (may be multi-line) | 
 **scalarParameters** | [**Dictionary&lt;string, string&gt;**](string.md)| Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional] 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
 **download** | **bool?**| Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false]
 **timeoutSeconds** | **int?**| In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0]
 **delimiter** | **string**| Delimiter string to override the default | [optional] 
 **escape** | **string**| Escape character to override the default | [optional] 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbyqueryexcel"></a>
# **PutByQueryExcel**
> System.IO.Stream PutByQueryExcel (string body, Dictionary<string, string> scalarParameters = null, string queryName = null, int? timeoutSeconds = null)

PutByQueryExcel: Executes Sql from the body making an Excel file

 For more complex LuminesceSql a PUT will allow for longer and line break delimited Sql, whic will be returned in the format of the method name. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutByQueryExcelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var scalarParameters = new Dictionary<string, string>(); // Dictionary<string, string> | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // PutByQueryExcel: Executes Sql from the body making an Excel file
                System.IO.Stream result = apiInstance.PutByQueryExcel(body, scalarParameters, queryName, timeoutSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.PutByQueryExcel: " + e.Message );
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
 **body** | **string**| LuminesceSql to Execute (may be multi-line) | 
 **scalarParameters** | [**Dictionary&lt;string, string&gt;**](string.md)| Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional] 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
 **timeoutSeconds** | **int?**| In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0]

### Return type

**System.IO.Stream**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbyqueryjson"></a>
# **PutByQueryJson**
> string PutByQueryJson (string body, Dictionary<string, string> scalarParameters = null, string queryName = null, int? timeoutSeconds = null, bool? jsonProper = null)

PutByQueryJson: Executes Sql from the body returning JSON

 For more complex LuminesceSql a PUT will allow for longer and line break delimited Sql, whic will be returned in the format of the method name. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutByQueryJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var scalarParameters = new Dictionary<string, string>(); // Dictionary<string, string> | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)
            var jsonProper = true;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)

            try
            {
                // PutByQueryJson: Executes Sql from the body returning JSON
                string result = apiInstance.PutByQueryJson(body, scalarParameters, queryName, timeoutSeconds, jsonProper);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.PutByQueryJson: " + e.Message );
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
 **body** | **string**| LuminesceSql to Execute (may be multi-line) | 
 **scalarParameters** | [**Dictionary&lt;string, string&gt;**](string.md)| Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional] 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
 **timeoutSeconds** | **int?**| In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0]
 **jsonProper** | **bool?**| Should this be text/json (not json-encoded-as-a-string) | [optional] [default to false]

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbyqueryparquet"></a>
# **PutByQueryParquet**
> System.IO.Stream PutByQueryParquet (string body, Dictionary<string, string> scalarParameters = null, string queryName = null, int? timeoutSeconds = null)

PutByQueryParquet: Executes Sql from the body making a Parquet file

 For more complex LuminesceSql a PUT will allow for longer and line break delimited Sql, whic will be returned in the format of the method name. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutByQueryParquetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var scalarParameters = new Dictionary<string, string>(); // Dictionary<string, string> | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // PutByQueryParquet: Executes Sql from the body making a Parquet file
                System.IO.Stream result = apiInstance.PutByQueryParquet(body, scalarParameters, queryName, timeoutSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.PutByQueryParquet: " + e.Message );
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
 **body** | **string**| LuminesceSql to Execute (may be multi-line) | 
 **scalarParameters** | [**Dictionary&lt;string, string&gt;**](string.md)| Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional] 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
 **timeoutSeconds** | **int?**| In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0]

### Return type

**System.IO.Stream**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbyquerypipe"></a>
# **PutByQueryPipe**
> string PutByQueryPipe (string body, Dictionary<string, string> scalarParameters = null, string queryName = null, bool? download = null, int? timeoutSeconds = null)

PutByQueryPipe: Executes Sql from the body making pipe-delimited

 For more complex LuminesceSql a PUT will allow for longer and line break delimited Sql, whic will be returned in the format of the method name. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutByQueryPipeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var scalarParameters = new Dictionary<string, string>(); // Dictionary<string, string> | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = true;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // PutByQueryPipe: Executes Sql from the body making pipe-delimited
                string result = apiInstance.PutByQueryPipe(body, scalarParameters, queryName, download, timeoutSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.PutByQueryPipe: " + e.Message );
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
 **body** | **string**| LuminesceSql to Execute (may be multi-line) | 
 **scalarParameters** | [**Dictionary&lt;string, string&gt;**](string.md)| Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional] 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
 **download** | **bool?**| Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false]
 **timeoutSeconds** | **int?**| In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0]

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbyquerysqlite"></a>
# **PutByQuerySqlite**
> System.IO.Stream PutByQuerySqlite (string body, Dictionary<string, string> scalarParameters = null, string queryName = null, int? timeoutSeconds = null)

PutByQuerySqlite: Executes Sql from the body returning SqLite DB

 For more complex LuminesceSql a PUT will allow for longer and line break delimited Sql, whic will be returned in the format of the method name. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutByQuerySqliteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var scalarParameters = new Dictionary<string, string>(); // Dictionary<string, string> | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // PutByQuerySqlite: Executes Sql from the body returning SqLite DB
                System.IO.Stream result = apiInstance.PutByQuerySqlite(body, scalarParameters, queryName, timeoutSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.PutByQuerySqlite: " + e.Message );
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
 **body** | **string**| LuminesceSql to Execute (may be multi-line) | 
 **scalarParameters** | [**Dictionary&lt;string, string&gt;**](string.md)| Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional] 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
 **timeoutSeconds** | **int?**| In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0]

### Return type

**System.IO.Stream**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbyqueryxml"></a>
# **PutByQueryXml**
> string PutByQueryXml (string body, Dictionary<string, string> scalarParameters = null, string queryName = null, bool? download = null, int? timeoutSeconds = null)

PutByQueryXml: Executes Sql from the body returning XML

 For more complex LuminesceSql a PUT will allow for longer and line break delimited Sql, whic will be returned in the format of the method name. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutByQueryXmlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var scalarParameters = new Dictionary<string, string>(); // Dictionary<string, string> | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = true;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // PutByQueryXml: Executes Sql from the body returning XML
                string result = apiInstance.PutByQueryXml(body, scalarParameters, queryName, download, timeoutSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.PutByQueryXml: " + e.Message );
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
 **body** | **string**| LuminesceSql to Execute (may be multi-line) | 
 **scalarParameters** | [**Dictionary&lt;string, string&gt;**](string.md)| Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional] 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
 **download** | **bool?**| Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false]
 **timeoutSeconds** | **int?**| In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0]

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

