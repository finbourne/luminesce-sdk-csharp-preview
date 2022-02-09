# Finbourne.Luminesce.Sdk.Api.SqlBackgroundExecutionApi

All URIs are relative to *https://www.lusid.com/honeycomb*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelQuery**](SqlBackgroundExecutionApi.md#cancelquery) | **DELETE** /api/SqlBackground/{executionId} | [EXPERIMENTAL] CancelQuery: Cancels (if running) or clears the data from (if completed) a previously started query
[**FetchQueryResultCsv**](SqlBackgroundExecutionApi.md#fetchqueryresultcsv) | **GET** /api/SqlBackground/{executionId}/csv | [EXPERIMENTAL] FetchQueryResultCsv: Fetches the result from a previously started query, in CSV format.
[**FetchQueryResultExcel**](SqlBackgroundExecutionApi.md#fetchqueryresultexcel) | **GET** /api/SqlBackground/{executionId}/excel | [EXPERIMENTAL] FetchQueryResultExcel: Fetches the result from a previously started query, in Excel format.
[**FetchQueryResultJson**](SqlBackgroundExecutionApi.md#fetchqueryresultjson) | **GET** /api/SqlBackground/{executionId}/json | [EXPERIMENTAL] FetchQueryResultJson: Fetches the result from a previously started query, in JSON string format.  Please move to &#39;/jsonProper&#39; instead.  This may be marked as Deprecated in the future.
[**FetchQueryResultJsonProper**](SqlBackgroundExecutionApi.md#fetchqueryresultjsonproper) | **GET** /api/SqlBackground/{executionId}/jsonProper | [EXPERIMENTAL] FetchQueryResultJsonProper: Fetches the result from a previously started query, in JSON format.
[**FetchQueryResultPipe**](SqlBackgroundExecutionApi.md#fetchqueryresultpipe) | **GET** /api/SqlBackground/{executionId}/pipe | [EXPERIMENTAL] FetchQueryResultPipe: Fetches the result from a previously started query, in pipe-delimited format.
[**FetchQueryResultSqlite**](SqlBackgroundExecutionApi.md#fetchqueryresultsqlite) | **GET** /api/SqlBackground/{executionId}/sqlite | [EXPERIMENTAL] FetchQueryResultSqlite: Fetches the result from a previously started query, in SqLite format.
[**GetProgressOf**](SqlBackgroundExecutionApi.md#getprogressof) | **GET** /api/SqlBackground/{executionId} | [EXPERIMENTAL] GetProgressOf: View progress information (up until this point)
[**StartQuery**](SqlBackgroundExecutionApi.md#startquery) | **PUT** /api/SqlBackground | [EXPERIMENTAL] StartQuery: Starts to Execute HoneycombSql in the background.


<a name="cancelquery"></a>
# **CancelQuery**
> BackgroundQueryCancelResponse CancelQuery (string executionId)

[EXPERIMENTAL] CancelQuery: Cancels (if running) or clears the data from (if completed) a previously started query

Cancel the query (if still running) / clear the data (if already returned) The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 404 Not Found : The requested query result doesn't exist and is not running. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class CancelQueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = executionId_example;  // string | ExecutionId returned when starting the query

            try
            {
                // [EXPERIMENTAL] CancelQuery: Cancels (if running) or clears the data from (if completed) a previously started query
                BackgroundQueryCancelResponse result = apiInstance.CancelQuery(executionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.CancelQuery: " + e.Message );
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
 **executionId** | **string**| ExecutionId returned when starting the query | 

### Return type

[**BackgroundQueryCancelResponse**](BackgroundQueryCancelResponse.md)

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

<a name="fetchqueryresultcsv"></a>
# **FetchQueryResultCsv**
> string FetchQueryResultCsv (string executionId, bool? download = null, string sortBy = null, string filter = null, string select = null, string groupBy = null, int? limit = null, int? page = null)

[EXPERIMENTAL] FetchQueryResultCsv: Fetches the result from a previously started query, in CSV format.

Fetch the data in various formats (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchQueryResultCsvExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = executionId_example;  // string | ExecutionId returned when starting the query
            var download = true;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var sortBy = sortBy_example;  // string | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = filter_example;  // string | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = select_example;  // string | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = groupBy_example;  // string | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var limit = 56;  // int? | When paginating, only return this number of records, page should also be specified. (optional)  (default to 0)
            var page = 56;  // int? | 0-N based on chunk sized determined by the limit, ignored if limit < 1. (optional)  (default to 0)

            try
            {
                // [EXPERIMENTAL] FetchQueryResultCsv: Fetches the result from a previously started query, in CSV format.
                string result = apiInstance.FetchQueryResultCsv(executionId, download, sortBy, filter, select, groupBy, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultCsv: " + e.Message );
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
 **executionId** | **string**| ExecutionId returned when starting the query | 
 **download** | **bool?**| Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false]
 **sortBy** | **string**| Order the results by these fields.              Use the &#x60;-&#x60; sign to denote descending order, e.g. &#x60;-MyFieldName&#x60;.  Numeric indexes may be used also, e.g. &#x60;2,-3&#x60;.              Multiple fields can be denoted by a comma e.g. &#x60;-MyFieldName,AnotherFieldName,-AFurtherFieldName&#x60;.              Default is null, the sort order specified in the query itself. | [optional] 
 **filter** | **string**| An ODATA filter per Finbourne.Filtering syntax. | [optional] 
 **select** | **string**| Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - &#x60;MyField&#x60;  - &#x60;Max(x) FILTER (WHERE y &gt; 12) as ABC&#x60; (max of a field, if another field lets it qualify, with a nice column name)  - &#x60;count(*)&#x60; (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - &#x60;count(distinct x) as numOfXs&#x60;  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - &#x60;some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name&#x60;    where you would likely want to pass &#x60;1&#x60; as the &#x60;groupBy&#x60; also. | [optional] 
 **groupBy** | **string**| Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. &#x60;2,3&#x60;, &#x60;myColumn&#x60;.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \&quot;select\&quot; parameter fields.              Only specify this if you are selecting aggregations in the \&quot;select\&quot; parameter. | [optional] 
 **limit** | **int?**| When paginating, only return this number of records, page should also be specified. | [optional] [default to 0]
 **page** | **int?**| 0-N based on chunk sized determined by the limit, ignored if limit &lt; 1. | [optional] [default to 0]

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

<a name="fetchqueryresultexcel"></a>
# **FetchQueryResultExcel**
> string FetchQueryResultExcel (string executionId, string sortBy = null, string filter = null, string select = null, string groupBy = null)

[EXPERIMENTAL] FetchQueryResultExcel: Fetches the result from a previously started query, in Excel format.

Fetch the data in various formats (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchQueryResultExcelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = executionId_example;  // string | ExecutionId returned when starting the query
            var sortBy = sortBy_example;  // string | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = filter_example;  // string | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = select_example;  // string | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = groupBy_example;  // string | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 

            try
            {
                // [EXPERIMENTAL] FetchQueryResultExcel: Fetches the result from a previously started query, in Excel format.
                string result = apiInstance.FetchQueryResultExcel(executionId, sortBy, filter, select, groupBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultExcel: " + e.Message );
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
 **executionId** | **string**| ExecutionId returned when starting the query | 
 **sortBy** | **string**| Order the results by these fields.              Use the &#x60;-&#x60; sign to denote descending order, e.g. &#x60;-MyFieldName&#x60;.  Numeric indexes may be used also, e.g. &#x60;2,-3&#x60;.              Multiple fields can be denoted by a comma e.g. &#x60;-MyFieldName,AnotherFieldName,-AFurtherFieldName&#x60;.              Default is null, the sort order specified in the query itself. | [optional] 
 **filter** | **string**| An ODATA filter per Finbourne.Filtering syntax. | [optional] 
 **select** | **string**| Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - &#x60;MyField&#x60;  - &#x60;Max(x) FILTER (WHERE y &gt; 12) as ABC&#x60; (max of a field, if another field lets it qualify, with a nice column name)  - &#x60;count(*)&#x60; (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - &#x60;count(distinct x) as numOfXs&#x60;  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - &#x60;some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name&#x60;    where you would likely want to pass &#x60;1&#x60; as the &#x60;groupBy&#x60; also. | [optional] 
 **groupBy** | **string**| Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. &#x60;2,3&#x60;, &#x60;myColumn&#x60;.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \&quot;select\&quot; parameter fields.              Only specify this if you are selecting aggregations in the \&quot;select\&quot; parameter. | [optional] 

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

<a name="fetchqueryresultjson"></a>
# **FetchQueryResultJson**
> string FetchQueryResultJson (string executionId, string sortBy = null, string filter = null, string select = null, string groupBy = null, int? limit = null, int? page = null)

[EXPERIMENTAL] FetchQueryResultJson: Fetches the result from a previously started query, in JSON string format.  Please move to '/jsonProper' instead.  This may be marked as Deprecated in the future.

Fetch the data in various formats (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchQueryResultJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = executionId_example;  // string | ExecutionId returned when starting the query
            var sortBy = sortBy_example;  // string | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = filter_example;  // string | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = select_example;  // string | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = groupBy_example;  // string | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var limit = 56;  // int? | When paginating, only return this number of records, page should also be specified. (optional)  (default to 0)
            var page = 56;  // int? | 0-N based on chunk sized determined by the limit, ignored if limit < 1. (optional)  (default to 0)

            try
            {
                // [EXPERIMENTAL] FetchQueryResultJson: Fetches the result from a previously started query, in JSON string format.  Please move to '/jsonProper' instead.  This may be marked as Deprecated in the future.
                string result = apiInstance.FetchQueryResultJson(executionId, sortBy, filter, select, groupBy, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultJson: " + e.Message );
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
 **executionId** | **string**| ExecutionId returned when starting the query | 
 **sortBy** | **string**| Order the results by these fields.              Use the &#x60;-&#x60; sign to denote descending order, e.g. &#x60;-MyFieldName&#x60;.  Numeric indexes may be used also, e.g. &#x60;2,-3&#x60;.              Multiple fields can be denoted by a comma e.g. &#x60;-MyFieldName,AnotherFieldName,-AFurtherFieldName&#x60;.              Default is null, the sort order specified in the query itself. | [optional] 
 **filter** | **string**| An ODATA filter per Finbourne.Filtering syntax. | [optional] 
 **select** | **string**| Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - &#x60;MyField&#x60;  - &#x60;Max(x) FILTER (WHERE y &gt; 12) as ABC&#x60; (max of a field, if another field lets it qualify, with a nice column name)  - &#x60;count(*)&#x60; (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - &#x60;count(distinct x) as numOfXs&#x60;  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - &#x60;some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name&#x60;    where you would likely want to pass &#x60;1&#x60; as the &#x60;groupBy&#x60; also. | [optional] 
 **groupBy** | **string**| Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. &#x60;2,3&#x60;, &#x60;myColumn&#x60;.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \&quot;select\&quot; parameter fields.              Only specify this if you are selecting aggregations in the \&quot;select\&quot; parameter. | [optional] 
 **limit** | **int?**| When paginating, only return this number of records, page should also be specified. | [optional] [default to 0]
 **page** | **int?**| 0-N based on chunk sized determined by the limit, ignored if limit &lt; 1. | [optional] [default to 0]

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

<a name="fetchqueryresultjsonproper"></a>
# **FetchQueryResultJsonProper**
> string FetchQueryResultJsonProper (string executionId, bool? download = null, string sortBy = null, string filter = null, string select = null, string groupBy = null, int? limit = null, int? page = null)

[EXPERIMENTAL] FetchQueryResultJsonProper: Fetches the result from a previously started query, in JSON format.

Fetch the data in various formats (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchQueryResultJsonProperExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = executionId_example;  // string | ExecutionId returned when starting the query
            var download = true;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var sortBy = sortBy_example;  // string | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = filter_example;  // string | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = select_example;  // string | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = groupBy_example;  // string | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var limit = 56;  // int? | When paginating, only return this number of records, page should also be specified. (optional)  (default to 0)
            var page = 56;  // int? | 0-N based on chunk sized determined by the limit, ignored if limit < 1. (optional)  (default to 0)

            try
            {
                // [EXPERIMENTAL] FetchQueryResultJsonProper: Fetches the result from a previously started query, in JSON format.
                string result = apiInstance.FetchQueryResultJsonProper(executionId, download, sortBy, filter, select, groupBy, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultJsonProper: " + e.Message );
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
 **executionId** | **string**| ExecutionId returned when starting the query | 
 **download** | **bool?**| Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false]
 **sortBy** | **string**| Order the results by these fields.              Use the &#x60;-&#x60; sign to denote descending order, e.g. &#x60;-MyFieldName&#x60;.  Numeric indexes may be used also, e.g. &#x60;2,-3&#x60;.              Multiple fields can be denoted by a comma e.g. &#x60;-MyFieldName,AnotherFieldName,-AFurtherFieldName&#x60;.              Default is null, the sort order specified in the query itself. | [optional] 
 **filter** | **string**| An ODATA filter per Finbourne.Filtering syntax. | [optional] 
 **select** | **string**| Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - &#x60;MyField&#x60;  - &#x60;Max(x) FILTER (WHERE y &gt; 12) as ABC&#x60; (max of a field, if another field lets it qualify, with a nice column name)  - &#x60;count(*)&#x60; (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - &#x60;count(distinct x) as numOfXs&#x60;  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - &#x60;some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name&#x60;    where you would likely want to pass &#x60;1&#x60; as the &#x60;groupBy&#x60; also. | [optional] 
 **groupBy** | **string**| Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. &#x60;2,3&#x60;, &#x60;myColumn&#x60;.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \&quot;select\&quot; parameter fields.              Only specify this if you are selecting aggregations in the \&quot;select\&quot; parameter. | [optional] 
 **limit** | **int?**| When paginating, only return this number of records, page should also be specified. | [optional] [default to 0]
 **page** | **int?**| 0-N based on chunk sized determined by the limit, ignored if limit &lt; 1. | [optional] [default to 0]

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

<a name="fetchqueryresultpipe"></a>
# **FetchQueryResultPipe**
> string FetchQueryResultPipe (string executionId, bool? download = null, string sortBy = null, string filter = null, string select = null, string groupBy = null, int? limit = null, int? page = null)

[EXPERIMENTAL] FetchQueryResultPipe: Fetches the result from a previously started query, in pipe-delimited format.

Fetch the data in various formats (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchQueryResultPipeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = executionId_example;  // string | ExecutionId returned when starting the query
            var download = true;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var sortBy = sortBy_example;  // string | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = filter_example;  // string | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = select_example;  // string | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = groupBy_example;  // string | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var limit = 56;  // int? | When paginating, only return this number of records, page should also be specified. (optional)  (default to 0)
            var page = 56;  // int? | 0-N based on chunk sized determined by the limit, ignored if limit < 1. (optional)  (default to 0)

            try
            {
                // [EXPERIMENTAL] FetchQueryResultPipe: Fetches the result from a previously started query, in pipe-delimited format.
                string result = apiInstance.FetchQueryResultPipe(executionId, download, sortBy, filter, select, groupBy, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultPipe: " + e.Message );
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
 **executionId** | **string**| ExecutionId returned when starting the query | 
 **download** | **bool?**| Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false]
 **sortBy** | **string**| Order the results by these fields.              Use the &#x60;-&#x60; sign to denote descending order, e.g. &#x60;-MyFieldName&#x60;.  Numeric indexes may be used also, e.g. &#x60;2,-3&#x60;.              Multiple fields can be denoted by a comma e.g. &#x60;-MyFieldName,AnotherFieldName,-AFurtherFieldName&#x60;.              Default is null, the sort order specified in the query itself. | [optional] 
 **filter** | **string**| An ODATA filter per Finbourne.Filtering syntax. | [optional] 
 **select** | **string**| Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - &#x60;MyField&#x60;  - &#x60;Max(x) FILTER (WHERE y &gt; 12) as ABC&#x60; (max of a field, if another field lets it qualify, with a nice column name)  - &#x60;count(*)&#x60; (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - &#x60;count(distinct x) as numOfXs&#x60;  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - &#x60;some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name&#x60;    where you would likely want to pass &#x60;1&#x60; as the &#x60;groupBy&#x60; also. | [optional] 
 **groupBy** | **string**| Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. &#x60;2,3&#x60;, &#x60;myColumn&#x60;.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \&quot;select\&quot; parameter fields.              Only specify this if you are selecting aggregations in the \&quot;select\&quot; parameter. | [optional] 
 **limit** | **int?**| When paginating, only return this number of records, page should also be specified. | [optional] [default to 0]
 **page** | **int?**| 0-N based on chunk sized determined by the limit, ignored if limit &lt; 1. | [optional] [default to 0]

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

<a name="fetchqueryresultsqlite"></a>
# **FetchQueryResultSqlite**
> string FetchQueryResultSqlite (string executionId, string sortBy = null, string filter = null, string select = null, string groupBy = null)

[EXPERIMENTAL] FetchQueryResultSqlite: Fetches the result from a previously started query, in SqLite format.

Fetch the data in various formats (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchQueryResultSqliteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = executionId_example;  // string | ExecutionId returned when starting the query
            var sortBy = sortBy_example;  // string | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = filter_example;  // string | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = select_example;  // string | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = groupBy_example;  // string | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 

            try
            {
                // [EXPERIMENTAL] FetchQueryResultSqlite: Fetches the result from a previously started query, in SqLite format.
                string result = apiInstance.FetchQueryResultSqlite(executionId, sortBy, filter, select, groupBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultSqlite: " + e.Message );
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
 **executionId** | **string**| ExecutionId returned when starting the query | 
 **sortBy** | **string**| Order the results by these fields.              Use the &#x60;-&#x60; sign to denote descending order, e.g. &#x60;-MyFieldName&#x60;.  Numeric indexes may be used also, e.g. &#x60;2,-3&#x60;.              Multiple fields can be denoted by a comma e.g. &#x60;-MyFieldName,AnotherFieldName,-AFurtherFieldName&#x60;.              Default is null, the sort order specified in the query itself. | [optional] 
 **filter** | **string**| An ODATA filter per Finbourne.Filtering syntax. | [optional] 
 **select** | **string**| Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - &#x60;MyField&#x60;  - &#x60;Max(x) FILTER (WHERE y &gt; 12) as ABC&#x60; (max of a field, if another field lets it qualify, with a nice column name)  - &#x60;count(*)&#x60; (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - &#x60;count(distinct x) as numOfXs&#x60;  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - &#x60;some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name&#x60;    where you would likely want to pass &#x60;1&#x60; as the &#x60;groupBy&#x60; also. | [optional] 
 **groupBy** | **string**| Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. &#x60;2,3&#x60;, &#x60;myColumn&#x60;.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \&quot;select\&quot; parameter fields.              Only specify this if you are selecting aggregations in the \&quot;select\&quot; parameter. | [optional] 

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

<a name="getprogressof"></a>
# **GetProgressOf**
> BackgroundQueryProgressResponse GetProgressOf (string executionId)

[EXPERIMENTAL] GetProgressOf: View progress information (up until this point)

View progress information (up until this point) The following error codes are to be anticipated most with standard Problem Detail reports: - 401 Unauthorized - 404 Not Found : The requested query result doesn't exist and is not running. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetProgressOfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = executionId_example;  // string | ExecutionId returned when starting the query

            try
            {
                // [EXPERIMENTAL] GetProgressOf: View progress information (up until this point)
                BackgroundQueryProgressResponse result = apiInstance.GetProgressOf(executionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.GetProgressOf: " + e.Message );
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
 **executionId** | **string**| ExecutionId returned when starting the query | 

### Return type

[**BackgroundQueryProgressResponse**](BackgroundQueryProgressResponse.md)

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

<a name="startquery"></a>
# **StartQuery**
> BackgroundQueryResponse StartQuery (string body, string queryName = null, int? timeoutSeconds = null, int? keepForSeconds = null)

[EXPERIMENTAL] StartQuery: Starts to Execute HoneycombSql in the background.

 Allow for starting a potentially long running query and getting back an immediate response with how to  - fetch the data in various formats (if available, or if not simply being informed it is not yet ready) - view progress information (up until this point) - cancel the query (if still running) / clear the data (if already returned)  This can still error on things like an outright syntax error, but more runtime errors (e.g. from providers) will not cause this to error (that will happen when attempting to fetch data)  Here is an example that intentionally takes one minute to run:  ```sql select Str, Takes500Ms from Testing1K where UseLinq = true and [Int] <= 120 ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - there was something wrong with your query syntax (the issue was detected at parse-time) - 401 Unauthorized 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class StartQueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var body = body_example;  // string | The HoneycombSql query to kick off.
            var queryName = Intentionally slow test query;  // string | A name for this query.  This goes into logs and is available in `Sys.Logs.HcQueryStart`. (optional) 
            var timeoutSeconds = 1200;  // int? | Maximum time the query may run for, in seconds: <0 → ∞, 0 → 7200 (2h) (optional)  (default to 0)
            var keepForSeconds = 7200;  // int? | Maximum time the result may be kept for, in seconds: <0 → 1200 (20m), 0 → 28800 (8h), max = 2,678,400 (31d) (optional)  (default to 0)

            try
            {
                // [EXPERIMENTAL] StartQuery: Starts to Execute HoneycombSql in the background.
                BackgroundQueryResponse result = apiInstance.StartQuery(body, queryName, timeoutSeconds, keepForSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.StartQuery: " + e.Message );
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
 **body** | **string**| The HoneycombSql query to kick off. | 
 **queryName** | **string**| A name for this query.  This goes into logs and is available in &#x60;Sys.Logs.HcQueryStart&#x60;. | [optional] 
 **timeoutSeconds** | **int?**| Maximum time the query may run for, in seconds: &lt;0 → ∞, 0 → 7200 (2h) | [optional] [default to 0]
 **keepForSeconds** | **int?**| Maximum time the result may be kept for, in seconds: &lt;0 → 1200 (20m), 0 → 28800 (8h), max &#x3D; 2,678,400 (31d) | [optional] [default to 0]

### Return type

[**BackgroundQueryResponse**](BackgroundQueryResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

