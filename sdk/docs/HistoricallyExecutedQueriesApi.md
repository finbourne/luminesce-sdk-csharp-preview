# Finbourne.Luminesce.Sdk.Api.HistoricallyExecutedQueriesApi

All URIs are relative to *https://www.lusid.com/honeycomb*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelHistory**](HistoricallyExecutedQueriesApi.md#cancelhistory) | **DELETE** /api/History/{executionId} | CancelHistory: Cancels (if running) or clears the data from (if completed) a previously started History query
[**FetchHistoryResultHistogram**](HistoricallyExecutedQueriesApi.md#fetchhistoryresulthistogram) | **GET** /api/History/{executionId}/histogram | FetchHistoryResultHistogram: Fetches the result from a previously started query, converts it to a histogram (counts in buckets).
[**FetchHistoryResultJson**](HistoricallyExecutedQueriesApi.md#fetchhistoryresultjson) | **GET** /api/History/{executionId}/json | FetchHistoryResultJson: Fetches the result from a previously started query, in JSON format.
[**GetHistory**](HistoricallyExecutedQueriesApi.md#gethistory) | **GET** /api/History | GetHistory: Shows queries executed in a given historical time window (in Json format).
[**GetProgressOfHistory**](HistoricallyExecutedQueriesApi.md#getprogressofhistory) | **GET** /api/History/{executionId} | GetProgressOfHistory: View progress information (up until this point) of a history query


<a name="cancelhistory"></a>
# **CancelHistory**
> BackgroundQueryCancelResponse CancelHistory (string executionId)

CancelHistory: Cancels (if running) or clears the data from (if completed) a previously started History query

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
    public class CancelHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HistoricallyExecutedQueriesApi(config);
            var executionId = executionId_example;  // string | ExecutionId returned when starting the query

            try
            {
                // CancelHistory: Cancels (if running) or clears the data from (if completed) a previously started History query
                BackgroundQueryCancelResponse result = apiInstance.CancelHistory(executionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricallyExecutedQueriesApi.CancelHistory: " + e.Message );
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

<a name="fetchhistoryresulthistogram"></a>
# **FetchHistoryResultHistogram**
> string FetchHistoryResultHistogram (string executionId, string bucketSize = null, string filter = null, bool? jsonProper = null)

FetchHistoryResultHistogram: Fetches the result from a previously started query, converts it to a histogram (counts in buckets).

Fetch the histogram in Json format (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchHistoryResultHistogramExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HistoricallyExecutedQueriesApi(config);
            var executionId = executionId_example;  // string | ExecutionId returned when starting the query
            var bucketSize = bucketSize_example;  // string | Optional histogram bucket width.  If not provided a set number of buckets between start/end range will be generated. (optional) 
            var filter = filter_example;  // string | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var jsonProper = true;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)

            try
            {
                // FetchHistoryResultHistogram: Fetches the result from a previously started query, converts it to a histogram (counts in buckets).
                string result = apiInstance.FetchHistoryResultHistogram(executionId, bucketSize, filter, jsonProper);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricallyExecutedQueriesApi.FetchHistoryResultHistogram: " + e.Message );
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
 **bucketSize** | **string**| Optional histogram bucket width.  If not provided a set number of buckets between start/end range will be generated. | [optional] 
 **filter** | **string**| An ODATA filter per Finbourne.Filtering syntax. | [optional] 
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

<a name="fetchhistoryresultjson"></a>
# **FetchHistoryResultJson**
> string FetchHistoryResultJson (string executionId, string sortBy = null, string filter = null, string select = null, string groupBy = null, int? limit = null, int? page = null, bool? jsonProper = null)

FetchHistoryResultJson: Fetches the result from a previously started query, in JSON format.

Fetch the data in Json format (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchHistoryResultJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HistoricallyExecutedQueriesApi(config);
            var executionId = executionId_example;  // string | ExecutionId returned when starting the query
            var sortBy = sortBy_example;  // string | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = filter_example;  // string | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = select_example;  // string | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = groupBy_example;  // string | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var limit = 56;  // int? | When paginating, only return this number of records, page should also be specified. (optional)  (default to 0)
            var page = 56;  // int? | 0-N based on chunk sized determined by the limit, ignored if limit < 1. (optional)  (default to 0)
            var jsonProper = true;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)

            try
            {
                // FetchHistoryResultJson: Fetches the result from a previously started query, in JSON format.
                string result = apiInstance.FetchHistoryResultJson(executionId, sortBy, filter, select, groupBy, limit, page, jsonProper);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricallyExecutedQueriesApi.FetchHistoryResultJson: " + e.Message );
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

<a name="gethistory"></a>
# **GetHistory**
> BackgroundQueryResponse GetHistory (DateTimeOffset? startAt = null, DateTimeOffset? endAt = null, string freeTextSearch = null, bool? showAll = null)

GetHistory: Shows queries executed in a given historical time window (in Json format).

 Starts to load the historical query logs for a certain time range, search criteria, etc.  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HistoricallyExecutedQueriesApi(config);
            var startAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Date time to start the search from.  Will default to Now - 1 Day (optional) 
            var endAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Date time to end the search at.  Defaults to now. (optional) 
            var freeTextSearch = freeTextSearch_example;  // string | Some test that must be in at least one field returned. (optional) 
            var showAll = true;  // bool? | For users with extra permissions, they may optionally see other users' queries. (optional)  (default to false)

            try
            {
                // GetHistory: Shows queries executed in a given historical time window (in Json format).
                BackgroundQueryResponse result = apiInstance.GetHistory(startAt, endAt, freeTextSearch, showAll);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricallyExecutedQueriesApi.GetHistory: " + e.Message );
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
 **startAt** | **DateTimeOffset?**| Date time to start the search from.  Will default to Now - 1 Day | [optional] 
 **endAt** | **DateTimeOffset?**| Date time to end the search at.  Defaults to now. | [optional] 
 **freeTextSearch** | **string**| Some test that must be in at least one field returned. | [optional] 
 **showAll** | **bool?**| For users with extra permissions, they may optionally see other users&#39; queries. | [optional] [default to false]

### Return type

[**BackgroundQueryResponse**](BackgroundQueryResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprogressofhistory"></a>
# **GetProgressOfHistory**
> BackgroundQueryProgressResponse GetProgressOfHistory (string executionId)

GetProgressOfHistory: View progress information (up until this point) of a history query

View progress information (up until this point) of previously started History query The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 404 Not Found : The requested query result doesn't exist and is not running. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetProgressOfHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HistoricallyExecutedQueriesApi(config);
            var executionId = executionId_example;  // string | ExecutionId returned when starting the query

            try
            {
                // GetProgressOfHistory: View progress information (up until this point) of a history query
                BackgroundQueryProgressResponse result = apiInstance.GetProgressOfHistory(executionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricallyExecutedQueriesApi.GetProgressOfHistory: " + e.Message );
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

