# Finbourne.Luminesce.Sdk.Api.SqlDesignApi

All URIs are relative to *https://www.lusid.com/honeycomb*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PutCaseStatementDesignSqlToDesign**](SqlDesignApi.md#putcasestatementdesignsqltodesign) | **PUT** /api/Sql/tocasestatementdesign | [EXPERIMENTAL] PutCaseStatementDesignSqlToDesign: Converts SQL to a case statement design object
[**PutCaseStatementDesignToSql**](SqlDesignApi.md#putcasestatementdesigntosql) | **PUT** /api/Sql/fromcasestatementdesign | [EXPERIMENTAL] PutCaseStatementDesignToSql: Converts a case statement design object to SQL
[**PutFileReadDesignToSql**](SqlDesignApi.md#putfilereaddesigntosql) | **PUT** /api/Sql/fromfilereaddesign | [EXPERIMENTAL] PutFileReadDesignToSql: Makes file read SQL from a design object
[**PutInlinedPropertiesDesignSqlToDesign**](SqlDesignApi.md#putinlinedpropertiesdesignsqltodesign) | **PUT** /api/Sql/toinlinedpropertiesdesign | [EXPERIMENTAL] PutInlinedPropertiesDesignSqlToDesign: Makes an inlined properties design from SQL
[**PutInlinedPropertiesDesignToSql**](SqlDesignApi.md#putinlinedpropertiesdesigntosql) | **PUT** /api/Sql/frominlinedpropertiesdesign | [EXPERIMENTAL] PutInlinedPropertiesDesignToSql: Makes inlined properties SQL from a design object
[**PutIntellisense**](SqlDesignApi.md#putintellisense) | **PUT** /api/Sql/intellisense | PutIntellisense: Makes a intellisense prompts given an SQL snip-it
[**PutIntellisenseError**](SqlDesignApi.md#putintellisenseerror) | **PUT** /api/Sql/intellisenseError | PutIntellisenseError: Expresses error ranges from SQL
[**PutQueryDesignToSql**](SqlDesignApi.md#putquerydesigntosql) | **PUT** /api/Sql/fromdesign | [EXPERIMENTAL] PutQueryDesignToSql: Makes SQL from a structured query design
[**PutQueryToFormat**](SqlDesignApi.md#putquerytoformat) | **PUT** /api/Sql/pretty | PutQueryToFormat: Formats SQL into a more readable form
[**PutSqlToExtractScalarParameters**](SqlDesignApi.md#putsqltoextractscalarparameters) | **PUT** /api/Sql/extractscalarparameters | [EXPERIMENTAL] PutSqlToExtractScalarParameters: Extracts scalar parameter information from SQL
[**PutSqlToFileReadDesign**](SqlDesignApi.md#putsqltofilereaddesign) | **PUT** /api/Sql/tofilereaddesign | [EXPERIMENTAL] PutSqlToFileReadDesign: Makes a design object from file-read SQL
[**PutSqlToQueryDesign**](SqlDesignApi.md#putsqltoquerydesign) | **PUT** /api/Sql/todesign | [EXPERIMENTAL] PutSqlToQueryDesign: Makes a SQL-design object from SQL if possible
[**PutSqlToViewDesign**](SqlDesignApi.md#putsqltoviewdesign) | **PUT** /api/Sql/toviewdesign | [EXPERIMENTAL] PutSqlToViewDesign: Makes a view-design from view creation SQL
[**PutSqlToWriterDesign**](SqlDesignApi.md#putsqltowriterdesign) | **PUT** /api/Sql/towriterdesign | [EXPERIMENTAL] PutSqlToWriterDesign: Makes a SQL-writer-design object from SQL
[**PutViewDesignToSql**](SqlDesignApi.md#putviewdesigntosql) | **PUT** /api/Sql/fromviewdesign | [EXPERIMENTAL] PutViewDesignToSql: Makes view creation sql from a view-design
[**PutWriterDesignToSql**](SqlDesignApi.md#putwriterdesigntosql) | **PUT** /api/Sql/fromwriterdesign | [EXPERIMENTAL] PutWriterDesignToSql: Makes writer SQL from a writer-design object


<a name="putcasestatementdesignsqltodesign"></a>
# **PutCaseStatementDesignSqlToDesign**
> CaseStatementDesign PutCaseStatementDesignSqlToDesign (string body = null)

[EXPERIMENTAL] PutCaseStatementDesignSqlToDesign: Converts SQL to a case statement design object

Converts a SQL query to a CaseStatementDesign object  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutCaseStatementDesignSqlToDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var body = CASE 
 WHEN [currency] = 'US' THEN 'USD' 
 WHEN [currency] = 'Gb' THEN 'GBP' 
 ELSE [currency] 
 END;  // string | SQL to attempt to create an case statement Design object from (optional) 

            try
            {
                // [EXPERIMENTAL] PutCaseStatementDesignSqlToDesign: Converts SQL to a case statement design object
                CaseStatementDesign result = apiInstance.PutCaseStatementDesignSqlToDesign(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutCaseStatementDesignSqlToDesign: " + e.Message );
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
 **body** | **string**| SQL to attempt to create an case statement Design object from | [optional] 

### Return type

[**CaseStatementDesign**](CaseStatementDesign.md)

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

<a name="putcasestatementdesigntosql"></a>
# **PutCaseStatementDesignToSql**
> string PutCaseStatementDesignToSql (CaseStatementDesign caseStatementDesign)

[EXPERIMENTAL] PutCaseStatementDesignToSql: Converts a case statement design object to SQL

Generates a SQL case statement query from a structured CaseStatementDesign object  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutCaseStatementDesignToSqlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var caseStatementDesign = new CaseStatementDesign(); // CaseStatementDesign | CaseStatementDesign object to try and create a SQL query from

            try
            {
                // [EXPERIMENTAL] PutCaseStatementDesignToSql: Converts a case statement design object to SQL
                string result = apiInstance.PutCaseStatementDesignToSql(caseStatementDesign);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutCaseStatementDesignToSql: " + e.Message );
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
 **caseStatementDesign** | [**CaseStatementDesign**](CaseStatementDesign.md)| CaseStatementDesign object to try and create a SQL query from | 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfilereaddesigntosql"></a>
# **PutFileReadDesignToSql**
> FileReaderBuilderResponse PutFileReadDesignToSql (FileReaderBuilderDef fileReaderBuilderDef, bool? executeQuery = null)

[EXPERIMENTAL] PutFileReadDesignToSql: Makes file read SQL from a design object

Generates SQL from a FileReaderBuilderDef object  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutFileReadDesignToSqlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var fileReaderBuilderDef = new FileReaderBuilderDef(); // FileReaderBuilderDef | Structured file read design object to generate SQL from
            var executeQuery = true;  // bool? | Should the generated query be executed to build preview data or determine errors.> (optional)  (default to true)

            try
            {
                // [EXPERIMENTAL] PutFileReadDesignToSql: Makes file read SQL from a design object
                FileReaderBuilderResponse result = apiInstance.PutFileReadDesignToSql(fileReaderBuilderDef, executeQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutFileReadDesignToSql: " + e.Message );
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
 **fileReaderBuilderDef** | [**FileReaderBuilderDef**](FileReaderBuilderDef.md)| Structured file read design object to generate SQL from | 
 **executeQuery** | **bool?**| Should the generated query be executed to build preview data or determine errors.&gt; | [optional] [default to true]

### Return type

[**FileReaderBuilderResponse**](FileReaderBuilderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putinlinedpropertiesdesignsqltodesign"></a>
# **PutInlinedPropertiesDesignSqlToDesign**
> InlinedPropertyDesign PutInlinedPropertiesDesignSqlToDesign (string body = null)

[EXPERIMENTAL] PutInlinedPropertiesDesignSqlToDesign: Makes an inlined properties design from SQL

Generates a SQL-inlined-properties-design object from SQL string, if possible.  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutInlinedPropertiesDesignSqlToDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var body = @keysToCatalog = values('Portfolio/3897-78d4-e91c-26/location', 'PortfolioLocation', false, '');
 @config = select column1 as [Key], column2 as Name, column3 as IsMain, column4 as Description from @keysToCatalog; 
 select * from Sys.Admin.Lusid.Provider.Configure where Provider = 'Lusid.Portfolio' and Configuration = @config;;  // string | SQL query to attempt to generate the inlined properties design object from (optional) 

            try
            {
                // [EXPERIMENTAL] PutInlinedPropertiesDesignSqlToDesign: Makes an inlined properties design from SQL
                InlinedPropertyDesign result = apiInstance.PutInlinedPropertiesDesignSqlToDesign(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutInlinedPropertiesDesignSqlToDesign: " + e.Message );
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
 **body** | **string**| SQL query to attempt to generate the inlined properties design object from | [optional] 

### Return type

[**InlinedPropertyDesign**](InlinedPropertyDesign.md)

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

<a name="putinlinedpropertiesdesigntosql"></a>
# **PutInlinedPropertiesDesignToSql**
> string PutInlinedPropertiesDesignToSql (InlinedPropertyDesign inlinedPropertyDesign)

[EXPERIMENTAL] PutInlinedPropertiesDesignToSql: Makes inlined properties SQL from a design object

Generates inlined properties SQL from a structured design  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutInlinedPropertiesDesignToSqlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var inlinedPropertyDesign = new InlinedPropertyDesign(); // InlinedPropertyDesign | Inlined properties Designer specification to generate SQL from

            try
            {
                // [EXPERIMENTAL] PutInlinedPropertiesDesignToSql: Makes inlined properties SQL from a design object
                string result = apiInstance.PutInlinedPropertiesDesignToSql(inlinedPropertyDesign);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutInlinedPropertiesDesignToSql: " + e.Message );
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
 **inlinedPropertyDesign** | [**InlinedPropertyDesign**](InlinedPropertyDesign.md)| Inlined properties Designer specification to generate SQL from | 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putintellisense"></a>
# **PutIntellisense**
> IntellisenseResponse PutIntellisense (IntellisenseRequest intellisenseRequest)

PutIntellisense: Makes a intellisense prompts given an SQL snip-it

Generate a set of possible intellisense prompts given a SQL snip-it (in need not yet be valid SQL) and cursor location  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutIntellisenseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var intellisenseRequest = new IntellisenseRequest(); // IntellisenseRequest | SQL and a row/colum position within it from which to determine intellisense options for the user to potentially choose from.

            try
            {
                // PutIntellisense: Makes a intellisense prompts given an SQL snip-it
                IntellisenseResponse result = apiInstance.PutIntellisense(intellisenseRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutIntellisense: " + e.Message );
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
 **intellisenseRequest** | [**IntellisenseRequest**](IntellisenseRequest.md)| SQL and a row/colum position within it from which to determine intellisense options for the user to potentially choose from. | 

### Return type

[**IntellisenseResponse**](IntellisenseResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putintellisenseerror"></a>
# **PutIntellisenseError**
> ErrorHighlightResponse PutIntellisenseError (ErrorHighlightRequest errorHighlightRequest)

PutIntellisenseError: Expresses error ranges from SQL

Generate a set of error ranges, if any, in the given SQL (expressed as Lines)  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutIntellisenseErrorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var errorHighlightRequest = new ErrorHighlightRequest(); // ErrorHighlightRequest | SQL (by line) to syntax check and return error ranges from within, if any.

            try
            {
                // PutIntellisenseError: Expresses error ranges from SQL
                ErrorHighlightResponse result = apiInstance.PutIntellisenseError(errorHighlightRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutIntellisenseError: " + e.Message );
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
 **errorHighlightRequest** | [**ErrorHighlightRequest**](ErrorHighlightRequest.md)| SQL (by line) to syntax check and return error ranges from within, if any. | 

### Return type

[**ErrorHighlightResponse**](ErrorHighlightResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putquerydesigntosql"></a>
# **PutQueryDesignToSql**
> string PutQueryDesignToSql (QueryDesign queryDesign)

[EXPERIMENTAL] PutQueryDesignToSql: Makes SQL from a structured query design

Generates SQL from a QueryDesign object  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutQueryDesignToSqlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var queryDesign = new QueryDesign(); // QueryDesign | Structured Query design object to generate SQL from

            try
            {
                // [EXPERIMENTAL] PutQueryDesignToSql: Makes SQL from a structured query design
                string result = apiInstance.PutQueryDesignToSql(queryDesign);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutQueryDesignToSql: " + e.Message );
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
 **queryDesign** | [**QueryDesign**](QueryDesign.md)| Structured Query design object to generate SQL from | 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putquerytoformat"></a>
# **PutQueryToFormat**
> string PutQueryToFormat (string body, bool? trailingCommas = null, bool? uppercaseKeywords = null, bool? breakJoinOnSections = null, bool? spaceAfterExpandedComma = null, bool? keywordStandardization = null, bool? expandCommaLists = null, bool? expandInLists = null, bool? expandBooleanExpressions = null, bool? expandBetweenConditions = null, bool? expandCaseStatements = null, int? maxLineWidth = null, bool? spaceBeforeTrailingSingleLineComments = null, bool? multilineCommentExtraLineBreak = null)

PutQueryToFormat: Formats SQL into a more readable form

 This formats SQL (given a set of options as to how to do so), a.k.a. Pretty-Print the SQL. It takes some SQL (or a fragment thereof, it need not fully parse as yet and certainly need not execute correctly) and returns the reformatted version. e.g. ```sql select x,y,z from a inner join b on a.x=b.x where x>y or y!=z ``` becomes ```sql select x, y, z from a inner join b    on a.x = b.x where x > y    or y != z ``` 

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

            var apiInstance = new SqlDesignApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Pretty-Print. Even if it doesn't parse an attempt will be made to format it
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
            var spaceBeforeTrailingSingleLineComments = true;  // bool? | Should the be a space before trailing single line comments? (optional)  (default to true)
            var multilineCommentExtraLineBreak = true;  // bool? | Should an additional line break be added after multi-line comments? (optional)  (default to false)

            try
            {
                // PutQueryToFormat: Formats SQL into a more readable form
                string result = apiInstance.PutQueryToFormat(body, trailingCommas, uppercaseKeywords, breakJoinOnSections, spaceAfterExpandedComma, keywordStandardization, expandCommaLists, expandInLists, expandBooleanExpressions, expandBetweenConditions, expandCaseStatements, maxLineWidth, spaceBeforeTrailingSingleLineComments, multilineCommentExtraLineBreak);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutQueryToFormat: " + e.Message );
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
 **body** | **string**| LuminesceSql to Pretty-Print. Even if it doesn&#39;t parse an attempt will be made to format it | 
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
 **spaceBeforeTrailingSingleLineComments** | **bool?**| Should the be a space before trailing single line comments? | [optional] [default to true]
 **multilineCommentExtraLineBreak** | **bool?**| Should an additional line break be added after multi-line comments? | [optional] [default to false]

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

<a name="putsqltoextractscalarparameters"></a>
# **PutSqlToExtractScalarParameters**
> ICollection&lt;ScalarParameter&gt; PutSqlToExtractScalarParameters (string body)

[EXPERIMENTAL] PutSqlToExtractScalarParameters: Extracts scalar parameter information from SQL

Extracts information about all the scalar parameters defined in the given SQL statement  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutSqlToExtractScalarParametersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var body = select abc, :p1:'this' as c1 from xxx where abc = :abcP:123 or xyz in (:p2:, 'zzz');  // string | SQL query to generate the design object from

            try
            {
                // [EXPERIMENTAL] PutSqlToExtractScalarParameters: Extracts scalar parameter information from SQL
                ICollection<ScalarParameter> result = apiInstance.PutSqlToExtractScalarParameters(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutSqlToExtractScalarParameters: " + e.Message );
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
 **body** | **string**| SQL query to generate the design object from | 

### Return type

[**ICollection&lt;ScalarParameter&gt;**](ScalarParameter.md)

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

<a name="putsqltofilereaddesign"></a>
# **PutSqlToFileReadDesign**
> FileReaderBuilderDef PutSqlToFileReadDesign (bool? determineAvailableSources = null, string body = null)

[EXPERIMENTAL] PutSqlToFileReadDesign: Makes a design object from file-read SQL

Generates a SQL-file-read-design object from SQL string, if possible.  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutSqlToFileReadDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var determineAvailableSources = true;  // bool? | Should the available sources be determined from `Sys.Registration` (optional)  (default to true)
            var body = @x = 
use Drive.Csv
  --file=/some/folder/somefile.csv
enduse;

select * from @x;;  // string | SQL query to generate the file read design object from (optional) 

            try
            {
                // [EXPERIMENTAL] PutSqlToFileReadDesign: Makes a design object from file-read SQL
                FileReaderBuilderDef result = apiInstance.PutSqlToFileReadDesign(determineAvailableSources, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutSqlToFileReadDesign: " + e.Message );
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
 **determineAvailableSources** | **bool?**| Should the available sources be determined from &#x60;Sys.Registration&#x60; | [optional] [default to true]
 **body** | **string**| SQL query to generate the file read design object from | [optional] 

### Return type

[**FileReaderBuilderDef**](FileReaderBuilderDef.md)

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

<a name="putsqltoquerydesign"></a>
# **PutSqlToQueryDesign**
> QueryDesign PutSqlToQueryDesign (string body, bool? validateWithMetadata = null)

[EXPERIMENTAL] PutSqlToQueryDesign: Makes a SQL-design object from SQL if possible

Generates a QueryDesign object from simple SQL if possible  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutSqlToQueryDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var body = SELECT
    [TableName],
    Count(distinct [FieldName]) as [NumberOfFields]
FROM
    [Sys.Field]
WHERE
    ([TableName] = 'Sys.Registration')
GROUP BY
    [TableName]
ORDER BY
    [DataType]
LIMIT 42;  // string | SQL query to generate the design object from
            var validateWithMetadata = true;  // bool? | Should the table be validated against the users' view of Sys.Field to fill in DataTypes, etc.? (optional)  (default to true)

            try
            {
                // [EXPERIMENTAL] PutSqlToQueryDesign: Makes a SQL-design object from SQL if possible
                QueryDesign result = apiInstance.PutSqlToQueryDesign(body, validateWithMetadata);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutSqlToQueryDesign: " + e.Message );
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
 **body** | **string**| SQL query to generate the design object from | 
 **validateWithMetadata** | **bool?**| Should the table be validated against the users&#39; view of Sys.Field to fill in DataTypes, etc.? | [optional] [default to true]

### Return type

[**QueryDesign**](QueryDesign.md)

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

<a name="putsqltoviewdesign"></a>
# **PutSqlToViewDesign**
> ConvertToViewData PutSqlToViewDesign (string body)

[EXPERIMENTAL] PutSqlToViewDesign: Makes a view-design from view creation SQL

Converts SQL which creates a view into a structured ConvertToViewData object  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutSqlToViewDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var body = @x = 
use Sys.Admin.SetupView
  --provider=YourView
----
select * from Lusid.Instrument
enduse;

select * from @x;;  // string | SQL Query to generate the ConvertToViewData object from

            try
            {
                // [EXPERIMENTAL] PutSqlToViewDesign: Makes a view-design from view creation SQL
                ConvertToViewData result = apiInstance.PutSqlToViewDesign(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutSqlToViewDesign: " + e.Message );
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
 **body** | **string**| SQL Query to generate the ConvertToViewData object from | 

### Return type

[**ConvertToViewData**](ConvertToViewData.md)

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

<a name="putsqltowriterdesign"></a>
# **PutSqlToWriterDesign**
> WriterDesign PutSqlToWriterDesign (string body, bool? mergeAdditionalMappingFields = null)

[EXPERIMENTAL] PutSqlToWriterDesign: Makes a SQL-writer-design object from SQL

Generates a SQL-writer-design object (WriterDesign) from a SQL query, if possible  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutSqlToWriterDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var body = Select abc from xyz;  // string | SQL query to generate the writer design object from
            var mergeAdditionalMappingFields = true;  // bool? | Should `Sys.Field` be used to find additional potential fields to map from? (not always possible) (optional)  (default to false)

            try
            {
                // [EXPERIMENTAL] PutSqlToWriterDesign: Makes a SQL-writer-design object from SQL
                WriterDesign result = apiInstance.PutSqlToWriterDesign(body, mergeAdditionalMappingFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutSqlToWriterDesign: " + e.Message );
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
 **body** | **string**| SQL query to generate the writer design object from | 
 **mergeAdditionalMappingFields** | **bool?**| Should &#x60;Sys.Field&#x60; be used to find additional potential fields to map from? (not always possible) | [optional] [default to false]

### Return type

[**WriterDesign**](WriterDesign.md)

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

<a name="putviewdesigntosql"></a>
# **PutViewDesignToSql**
> string PutViewDesignToSql (ConvertToViewData convertToViewData)

[EXPERIMENTAL] PutViewDesignToSql: Makes view creation sql from a view-design

Converts a ConvertToView specification into SQL that creates a view  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutViewDesignToSqlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var convertToViewData = new ConvertToViewData(); // ConvertToViewData | Structured Query design object to generate SQL from

            try
            {
                // [EXPERIMENTAL] PutViewDesignToSql: Makes view creation sql from a view-design
                string result = apiInstance.PutViewDesignToSql(convertToViewData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutViewDesignToSql: " + e.Message );
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
 **convertToViewData** | [**ConvertToViewData**](ConvertToViewData.md)| Structured Query design object to generate SQL from | 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putwriterdesigntosql"></a>
# **PutWriterDesignToSql**
> string PutWriterDesignToSql (WriterDesign writerDesign)

[EXPERIMENTAL] PutWriterDesignToSql: Makes writer SQL from a writer-design object

Generates writer SQL from a valid WriterDesign structure  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutWriterDesignToSqlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var writerDesign = new WriterDesign(); // WriterDesign | Structured Writer Design design object to generate Writer SQL from

            try
            {
                // [EXPERIMENTAL] PutWriterDesignToSql: Makes writer SQL from a writer-design object
                string result = apiInstance.PutWriterDesignToSql(writerDesign);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutWriterDesignToSql: " + e.Message );
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
 **writerDesign** | [**WriterDesign**](WriterDesign.md)| Structured Writer Design design object to generate Writer SQL from | 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

