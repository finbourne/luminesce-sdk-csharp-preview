# Finbourne.Luminesce.Sdk.Api.SqlExecutionApi

All URIs are relative to *https://www.lusid.com/honeycomb*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetByQueryCsv**](SqlExecutionApi.md#getbyquerycsv) | **GET** /api/Sql/csv/{query} | [EXPERIMENTAL] GetByQueryCsv: Executes Sql, returned in CSV format, where the sql is simply in the url.
[**GetByQueryExcel**](SqlExecutionApi.md#getbyqueryexcel) | **GET** /api/Sql/excel/{query} | [EXPERIMENTAL] GetByQueryExcel: Executes Sql, returned in Excel (xlsx) format (as a file to be downloaded) format, where the sql is simply in the url.
[**GetByQueryJson**](SqlExecutionApi.md#getbyqueryjson) | **GET** /api/Sql/json/{query} | [EXPERIMENTAL] GetByQueryJson: Executes Sql, returned in JSON format, where the sql is simply in the url.
[**GetByQueryPipe**](SqlExecutionApi.md#getbyquerypipe) | **GET** /api/Sql/pipe/{query} | [EXPERIMENTAL] GetByQueryPipe: Executes Sql, returned in pipe-delimited format, where the sql is simply in the url.
[**GetByQuerySqlite**](SqlExecutionApi.md#getbyquerysqlite) | **GET** /api/Sql/sqlite/{query} | [EXPERIMENTAL] GetByQuerySqlite: Executes Sql, returned in SqLite DB (sqlite3) format (as a file to be downloaded) format, where the sql is simply in the url.
[**PutByQueryCsv**](SqlExecutionApi.md#putbyquerycsv) | **PUT** /api/Sql/csv | [EXPERIMENTAL] PutByQueryCsv: Executes Sql, returned in CSV format, where the sql is the post-body url.
[**PutByQueryExcel**](SqlExecutionApi.md#putbyqueryexcel) | **PUT** /api/Sql/excel | [EXPERIMENTAL] PutByQueryExcel: Executes Sql, returned in Excel (xlsx) format (as a file to be downloaded), where the sql is the post-body url.
[**PutByQueryJson**](SqlExecutionApi.md#putbyqueryjson) | **PUT** /api/Sql/json | [EXPERIMENTAL] PutByQueryJson: Executes Sql, returned in JSON format, where the sql is the post-body url.
[**PutByQueryPipe**](SqlExecutionApi.md#putbyquerypipe) | **PUT** /api/Sql/pipe | [EXPERIMENTAL] PutByQueryPipe: Executes Sql, returned in pipe-delimited format, where the sql is the post-body url.
[**PutByQuerySqlite**](SqlExecutionApi.md#putbyquerysqlite) | **PUT** /api/Sql/sqlite | [EXPERIMENTAL] PutByQuerySqlite: Executes Sql, returned in SqLite DB (sqlite3) format (as a file to be downloaded), where the sql is the post-body url.
[**PutQueryToFormat**](SqlExecutionApi.md#putquerytoformat) | **PUT** /api/Sql/pretty | [EXPERIMENTAL] PutQueryToFormat: Executes Sql, returned in JSON format, where the sql is the post-body url.


<a name="getbyquerycsv"></a>
# **GetByQueryCsv**
> string GetByQueryCsv (string query, string queryName = null, bool? download = null, int? timeout = null)

[EXPERIMENTAL] GetByQueryCsv: Executes Sql, returned in CSV format, where the sql is simply in the url.

 For simple single-line query execution via the url. e.g. `select ^ from Sys.Field order by 1, 2`  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized 

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
            var query = select ^ from Sys.Field order by 1, 2;  // string | HoneycombSql to Execute (must be one line only)
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = true;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // [EXPERIMENTAL] GetByQueryCsv: Executes Sql, returned in CSV format, where the sql is simply in the url.
                string result = apiInstance.GetByQueryCsv(query, queryName, download, timeout);
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
 **query** | **string**| HoneycombSql to Execute (must be one line only) | 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyqueryexcel"></a>
# **GetByQueryExcel**
> string GetByQueryExcel (string query, string queryName = null, int? timeout = null)

[EXPERIMENTAL] GetByQueryExcel: Executes Sql, returned in Excel (xlsx) format (as a file to be downloaded) format, where the sql is simply in the url.

 For simple single-line query execution via the url. e.g. `select ^ from Sys.Field order by 1, 2`  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized 

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
            var query = select ^ from Sys.Field order by 1, 2;  // string | HoneycombSql to Execute (must be one line only)
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // [EXPERIMENTAL] GetByQueryExcel: Executes Sql, returned in Excel (xlsx) format (as a file to be downloaded) format, where the sql is simply in the url.
                string result = apiInstance.GetByQueryExcel(query, queryName, timeout);
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
 **query** | **string**| HoneycombSql to Execute (must be one line only) | 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyqueryjson"></a>
# **GetByQueryJson**
> string GetByQueryJson (string query, string queryName = null, int? timeout = null, bool? jsonProper = null)

[EXPERIMENTAL] GetByQueryJson: Executes Sql, returned in JSON format, where the sql is simply in the url.

 For simple single-line query execution via the url. e.g. `select ^ from Sys.Field order by 1, 2`  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized 

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
            var query = select ^ from Sys.Field order by 1, 2;  // string | HoneycombSql to Execute (must be one line only)
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)
            var jsonProper = true;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)

            try
            {
                // [EXPERIMENTAL] GetByQueryJson: Executes Sql, returned in JSON format, where the sql is simply in the url.
                string result = apiInstance.GetByQueryJson(query, queryName, timeout, jsonProper);
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
 **query** | **string**| HoneycombSql to Execute (must be one line only) | 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyquerypipe"></a>
# **GetByQueryPipe**
> string GetByQueryPipe (string query, string queryName = null, bool? download = null, int? timeout = null)

[EXPERIMENTAL] GetByQueryPipe: Executes Sql, returned in pipe-delimited format, where the sql is simply in the url.

 For simple single-line query execution via the url. e.g. `select ^ from Sys.Field order by 1, 2`  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized 

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
            var query = select ^ from Sys.Field order by 1, 2;  // string | HoneycombSql to Execute (must be one line only)
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = true;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // [EXPERIMENTAL] GetByQueryPipe: Executes Sql, returned in pipe-delimited format, where the sql is simply in the url.
                string result = apiInstance.GetByQueryPipe(query, queryName, download, timeout);
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
 **query** | **string**| HoneycombSql to Execute (must be one line only) | 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyquerysqlite"></a>
# **GetByQuerySqlite**
> string GetByQuerySqlite (string query, string queryName = null, int? timeout = null)

[EXPERIMENTAL] GetByQuerySqlite: Executes Sql, returned in SqLite DB (sqlite3) format (as a file to be downloaded) format, where the sql is simply in the url.

 For simple single-line query execution via the url. e.g. `select ^ from Sys.Field order by 1, 2`  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized 

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
            var query = select ^ from Sys.Field order by 1, 2;  // string | HoneycombSql to Execute (must be one line only)
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // [EXPERIMENTAL] GetByQuerySqlite: Executes Sql, returned in SqLite DB (sqlite3) format (as a file to be downloaded) format, where the sql is simply in the url.
                string result = apiInstance.GetByQuerySqlite(query, queryName, timeout);
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
 **query** | **string**| HoneycombSql to Execute (must be one line only) | 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbyquerycsv"></a>
# **PutByQueryCsv**
> string PutByQueryCsv (string body, string queryName = null, bool? download = null, int? timeoutSeconds = null)

[EXPERIMENTAL] PutByQueryCsv: Executes Sql, returned in CSV format, where the sql is the post-body url.

 For more complex HoneycombSql a PUT will allow for longer Sql. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized 

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
            var body = body_example;  // string | HoneycombSql to Execute (may be multi-line)
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = true;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // [EXPERIMENTAL] PutByQueryCsv: Executes Sql, returned in CSV format, where the sql is the post-body url.
                string result = apiInstance.PutByQueryCsv(body, queryName, download, timeoutSeconds);
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
 **body** | **string**| HoneycombSql to Execute (may be multi-line) | 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbyqueryexcel"></a>
# **PutByQueryExcel**
> string PutByQueryExcel (string body, string queryName = null, int? timeoutSeconds = null)

[EXPERIMENTAL] PutByQueryExcel: Executes Sql, returned in Excel (xlsx) format (as a file to be downloaded), where the sql is the post-body url.

 For more complex HoneycombSql a PUT will allow for longer Sql. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized 

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
            var body = body_example;  // string | HoneycombSql to Execute (may be multi-line)
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // [EXPERIMENTAL] PutByQueryExcel: Executes Sql, returned in Excel (xlsx) format (as a file to be downloaded), where the sql is the post-body url.
                string result = apiInstance.PutByQueryExcel(body, queryName, timeoutSeconds);
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
 **body** | **string**| HoneycombSql to Execute (may be multi-line) | 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbyqueryjson"></a>
# **PutByQueryJson**
> string PutByQueryJson (string body, string queryName = null, int? timeoutSeconds = null, bool? jsonProper = null)

[EXPERIMENTAL] PutByQueryJson: Executes Sql, returned in JSON format, where the sql is the post-body url.

 For more complex HoneycombSql a PUT will allow for longer Sql. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized 

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
            var body = body_example;  // string | HoneycombSql to Execute (may be multi-line)
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)
            var jsonProper = true;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)

            try
            {
                // [EXPERIMENTAL] PutByQueryJson: Executes Sql, returned in JSON format, where the sql is the post-body url.
                string result = apiInstance.PutByQueryJson(body, queryName, timeoutSeconds, jsonProper);
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
 **body** | **string**| HoneycombSql to Execute (may be multi-line) | 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbyquerypipe"></a>
# **PutByQueryPipe**
> string PutByQueryPipe (string body, string queryName = null, bool? download = null, int? timeoutSeconds = null)

[EXPERIMENTAL] PutByQueryPipe: Executes Sql, returned in pipe-delimited format, where the sql is the post-body url.

 For more complex HoneycombSql a PUT will allow for longer Sql. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized 

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
            var body = body_example;  // string | HoneycombSql to Execute (may be multi-line)
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = true;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // [EXPERIMENTAL] PutByQueryPipe: Executes Sql, returned in pipe-delimited format, where the sql is the post-body url.
                string result = apiInstance.PutByQueryPipe(body, queryName, download, timeoutSeconds);
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
 **body** | **string**| HoneycombSql to Execute (may be multi-line) | 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbyquerysqlite"></a>
# **PutByQuerySqlite**
> string PutByQuerySqlite (string body, string queryName = null, int? timeoutSeconds = null)

[EXPERIMENTAL] PutByQuerySqlite: Executes Sql, returned in SqLite DB (sqlite3) format (as a file to be downloaded), where the sql is the post-body url.

 For more complex HoneycombSql a PUT will allow for longer Sql. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized 

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
            var body = body_example;  // string | HoneycombSql to Execute (may be multi-line)
            var queryName = Get tables/fields;  // string | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // [EXPERIMENTAL] PutByQuerySqlite: Executes Sql, returned in SqLite DB (sqlite3) format (as a file to be downloaded), where the sql is the post-body url.
                string result = apiInstance.PutByQuerySqlite(body, queryName, timeoutSeconds);
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
 **body** | **string**| HoneycombSql to Execute (may be multi-line) | 
 **queryName** | **string**| Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional] 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putquerytoformat"></a>
# **PutQueryToFormat**
> string PutQueryToFormat (string body, bool? trailingCommas = null, bool? uppercaseKeywords = null, bool? breakJoinOnSections = null, bool? spaceAfterExpandedComma = null, bool? keywordStandardization = null, bool? expandCommaLists = null, bool? expandInLists = null, bool? expandBooleanExpressions = null, bool? expandBetweenConditions = null, bool? expandCaseStatements = null, int? maxLineWidth = null)

[EXPERIMENTAL] PutQueryToFormat: Executes Sql, returned in JSON format, where the sql is the post-body url.

 This formats SQL (given a set of options as to how to do so). It takes some SQL (or a fragment thereof, it need not fully parse as yet and certainly need not execute correctly) and returns the reformatted version. e.g. ```sql select x,y,z from a inner join b on a.x=b.x where x>y or y!=z ``` becomes ```sql select x, y, z from a inner join b    on a.x = b.x where x > y    or y != z ``` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutQueryToFormatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var body = body_example;  // string | HoneycombSql to Pretty-Print. Even if it doesn't parse an attempt will be made to format it
            var trailingCommas = true;  // bool? | Should commas be after an expression (as opposed to before) (optional)  (default to true)
            var uppercaseKeywords = true;  // bool? | Should key words be capitalized (optional)  (default to false)
            var breakJoinOnSections = true;  // bool? | Should clauses on joins be given line breaks? (optional)  (default to true)
            var spaceAfterExpandedComma = true;  // bool? | Should comma-lists have spaces after the commas? (optional)  (default to true)
            var keywordStandardization = true;  // bool? | Should the \"nicest\" key words be used? (e.g. JOIN -> INNER JOIN) (optional)  (default to true)
            var expandCommaLists = true;  // bool? | Should comma-lists (e.g. select a,b,c) have line breaks added? (optional)  (default to false)
            var expandInLists = true;  // bool? | Should IN-lists have line breaks added? (optional)  (default to false)
            var expandBooleanExpressions = true;  // bool? | Should boolean expressions have line breaks added? (optional)  (default to true)
            var expandBetweenConditions = true;  // bool? | Should between conditions have line breaks added? (optional)  (default to true)
            var expandCaseStatements = true;  // bool? | Should case-statements have line breaks added? (optional)  (default to true)
            var maxLineWidth = 56;  // int? | Maximum number of characters to allow on one line (if possible) (optional)  (default to 120)

            try
            {
                // [EXPERIMENTAL] PutQueryToFormat: Executes Sql, returned in JSON format, where the sql is the post-body url.
                string result = apiInstance.PutQueryToFormat(body, trailingCommas, uppercaseKeywords, breakJoinOnSections, spaceAfterExpandedComma, keywordStandardization, expandCommaLists, expandInLists, expandBooleanExpressions, expandBetweenConditions, expandCaseStatements, maxLineWidth);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.PutQueryToFormat: " + e.Message );
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
 **body** | **string**| HoneycombSql to Pretty-Print. Even if it doesn&#39;t parse an attempt will be made to format it | 
 **trailingCommas** | **bool?**| Should commas be after an expression (as opposed to before) | [optional] [default to true]
 **uppercaseKeywords** | **bool?**| Should key words be capitalized | [optional] [default to false]
 **breakJoinOnSections** | **bool?**| Should clauses on joins be given line breaks? | [optional] [default to true]
 **spaceAfterExpandedComma** | **bool?**| Should comma-lists have spaces after the commas? | [optional] [default to true]
 **keywordStandardization** | **bool?**| Should the \&quot;nicest\&quot; key words be used? (e.g. JOIN -&gt; INNER JOIN) | [optional] [default to true]
 **expandCommaLists** | **bool?**| Should comma-lists (e.g. select a,b,c) have line breaks added? | [optional] [default to false]
 **expandInLists** | **bool?**| Should IN-lists have line breaks added? | [optional] [default to false]
 **expandBooleanExpressions** | **bool?**| Should boolean expressions have line breaks added? | [optional] [default to true]
 **expandBetweenConditions** | **bool?**| Should between conditions have line breaks added? | [optional] [default to true]
 **expandCaseStatements** | **bool?**| Should case-statements have line breaks added? | [optional] [default to true]
 **maxLineWidth** | **int?**| Maximum number of characters to allow on one line (if possible) | [optional] [default to 120]

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

