# Finbourne.Luminesce.Sdk.Api.ApplicationMetadataApi

All URIs are relative to *https://www.lusid.com/honeycomb*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetServicesAsAccessControlledResources**](ApplicationMetadataApi.md#getservicesasaccesscontrolledresources) | **GET** /api/metadata/access/resources | GetServicesAsAccessControlledResources: Get resources available for access control


<a name="getservicesasaccesscontrolledresources"></a>
# **GetServicesAsAccessControlledResources**
> ResourceListOfAccessControlledResource GetServicesAsAccessControlledResources ()

GetServicesAsAccessControlledResources: Get resources available for access control

Get the comprehensive set of resources that are available for access control

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetServicesAsAccessControlledResourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationMetadataApi(config);

            try
            {
                // GetServicesAsAccessControlledResources: Get resources available for access control
                ResourceListOfAccessControlledResource result = apiInstance.GetServicesAsAccessControlledResources();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationMetadataApi.GetServicesAsAccessControlledResources: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ResourceListOfAccessControlledResource**](ResourceListOfAccessControlledResource.md)

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

