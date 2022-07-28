# Finbourne.Luminesce.Sdk.Api.MultiQueryExecutionApi

All URIs are relative to *https://www.lusid.com/honeycomb*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelMultiQuery**](MultiQueryExecutionApi.md#cancelmultiquery) | **DELETE** /api/MultiQueryBackground/{executionId} | CancelMultiQuery: Cancels (if running) or clears the data from (if completed) a previously started query-set
[**GetProgressOfMultiQuery**](MultiQueryExecutionApi.md#getprogressofmultiquery) | **GET** /api/MultiQueryBackground/{executionId} | GetProgressOfMultiQuery: View progress information (up until this point) for the entire query-set
[**StartQueries**](MultiQueryExecutionApi.md#startqueries) | **PUT** /api/MultiQueryBackground | StartQueries: Starts to Execute the HoneycombSql statements in the background.


<a name="cancelmultiquery"></a>
# **CancelMultiQuery**
> BackgroundQueryCancelResponse CancelMultiQuery (string executionId)

CancelMultiQuery: Cancels (if running) or clears the data from (if completed) a previously started query-set

Cancel the query-set (if still running) / clear the data (if already returned) The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 404 Not Found : The requested query result doesn't exist and is not running. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class CancelMultiQueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MultiQueryExecutionApi(config);
            var executionId = executionId_example;  // string | ExecutionId returned when starting the query

            try
            {
                // CancelMultiQuery: Cancels (if running) or clears the data from (if completed) a previously started query-set
                BackgroundQueryCancelResponse result = apiInstance.CancelMultiQuery(executionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MultiQueryExecutionApi.CancelMultiQuery: " + e.Message );
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

<a name="getprogressofmultiquery"></a>
# **GetProgressOfMultiQuery**
> BackgroundMultiQueryProgressResponse GetProgressOfMultiQuery (string executionId)

GetProgressOfMultiQuery: View progress information (up until this point) for the entire query-set

View progress information (up until this point) for the entire query-set The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 404 Not Found : The requested query result doesn't exist and is not running. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetProgressOfMultiQueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MultiQueryExecutionApi(config);
            var executionId = executionId_example;  // string | ExecutionId returned when starting the query

            try
            {
                // GetProgressOfMultiQuery: View progress information (up until this point) for the entire query-set
                BackgroundMultiQueryProgressResponse result = apiInstance.GetProgressOfMultiQuery(executionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MultiQueryExecutionApi.GetProgressOfMultiQuery: " + e.Message );
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

[**BackgroundMultiQueryProgressResponse**](BackgroundMultiQueryProgressResponse.md)

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

<a name="startqueries"></a>
# **StartQueries**
> BackgroundMultiQueryResponse StartQueries (MultiQueryDefinitionType type, string body, DateTimeOffset? asAt = null, DateTimeOffset? effectiveAt = null, int? limit1 = null, int? limit2 = null, string input1 = null, string input2 = null, string input3 = null, int? timeoutSeconds = null, int? keepForSeconds = null)

StartQueries: Starts to Execute the HoneycombSql statements in the background.

 Allow for starting a potentially long running query and getting back an immediate response with how to  - fetch the data in various formats (if available, or if not simply being informed it is not yet ready), on a per result basis - view progress information (up until this point), for all results in one go - cancel the queries (if still running) / clear the data (if already returned)  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - there was something wrong with your query syntax (the issue was detected at parse-time) - 401 Unauthorized 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class StartQueriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MultiQueryExecutionApi(config);
            var type = ;  // MultiQueryDefinitionType | An enum value defining the set of statements being executed
            var body = body_example;  // string | A \"search\" value (e.g. 'Apple' on an instrument search, a `Finbourne.Filtering` expression of Insights, etc.)  In the cases where \"Nothing\" is valid for a `Finbourne.Filtering` expression, pass `True`.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The AsAt time used by any bitemporal provider in the queries. (optional) 
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The EffectiveAt time used by any bitemporal provider in the queries. (optional) 
            var limit1 = 56;  // int? | A limit that is applied to first-level queries (e.g. Instruments themselves) (optional) 
            var limit2 = 56;  // int? | A limit that is applied to second-level queries (e.g. Holdings based on the set of Instruments found) (optional) 
            var input1 = input1_example;  // string | A value available to queries, these vary by 'type' and are only used by some types at all.  e.g. a start-date of some sort (optional) 
            var input2 = input2_example;  // string | A second value available to queries, these vary by 'type' and are only used by some types at all. (optional) 
            var input3 = input3_example;  // string | A third value available to queries, these vary by 'type' and are only used by some types at all. (optional) 
            var timeoutSeconds = 1200;  // int? | Maximum time the query may run for, in seconds: <0 → ∞, 0 → 1200s (20m) (optional)  (default to 0)
            var keepForSeconds = 7200;  // int? | Maximum time the result may be kept for, in seconds: <0 → 1200 (20m), 0 → 28800 (8h), max = 2,678,400 (31d) (optional)  (default to 0)

            try
            {
                // StartQueries: Starts to Execute the HoneycombSql statements in the background.
                BackgroundMultiQueryResponse result = apiInstance.StartQueries(type, body, asAt, effectiveAt, limit1, limit2, input1, input2, input3, timeoutSeconds, keepForSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MultiQueryExecutionApi.StartQueries: " + e.Message );
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
 **type** | **MultiQueryDefinitionType**| An enum value defining the set of statements being executed | 
 **body** | **string**| A \&quot;search\&quot; value (e.g. &#39;Apple&#39; on an instrument search, a &#x60;Finbourne.Filtering&#x60; expression of Insights, etc.)  In the cases where \&quot;Nothing\&quot; is valid for a &#x60;Finbourne.Filtering&#x60; expression, pass &#x60;True&#x60;. | 
 **asAt** | **DateTimeOffset?**| The AsAt time used by any bitemporal provider in the queries. | [optional] 
 **effectiveAt** | **DateTimeOffset?**| The EffectiveAt time used by any bitemporal provider in the queries. | [optional] 
 **limit1** | **int?**| A limit that is applied to first-level queries (e.g. Instruments themselves) | [optional] 
 **limit2** | **int?**| A limit that is applied to second-level queries (e.g. Holdings based on the set of Instruments found) | [optional] 
 **input1** | **string**| A value available to queries, these vary by &#39;type&#39; and are only used by some types at all.  e.g. a start-date of some sort | [optional] 
 **input2** | **string**| A second value available to queries, these vary by &#39;type&#39; and are only used by some types at all. | [optional] 
 **input3** | **string**| A third value available to queries, these vary by &#39;type&#39; and are only used by some types at all. | [optional] 
 **timeoutSeconds** | **int?**| Maximum time the query may run for, in seconds: &lt;0 → ∞, 0 → 1200s (20m) | [optional] [default to 0]
 **keepForSeconds** | **int?**| Maximum time the result may be kept for, in seconds: &lt;0 → 1200 (20m), 0 → 28800 (8h), max &#x3D; 2,678,400 (31d) | [optional] [default to 0]

### Return type

[**BackgroundMultiQueryResponse**](BackgroundMultiQueryResponse.md)

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

