# CLOUD.Artik.Api.TagsApi

All URIs are relative to *https://api.artik.cloud/v1.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTagCategories**](TagsApi.md#gettagcategories) | **GET** /tags/categories | Get all categories
[**GetTagSuggestions**](TagsApi.md#gettagsuggestions) | **GET** /tags/suggestions | Get tag suggestions
[**GetTagsByCategories**](TagsApi.md#gettagsbycategories) | **GET** /tags | Get all tags of categories


<a name="gettagcategories"></a>
# **GetTagCategories**
> TagsEnvelope GetTagCategories ()

Get all categories

Get all tags marked as categories

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetTagCategoriesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TagsApi();

            try
            {
                // Get all categories
                TagsEnvelope result = apiInstance.GetTagCategories();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.GetTagCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TagsEnvelope**](TagsEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettagsuggestions"></a>
# **GetTagSuggestions**
> TagsEnvelope GetTagSuggestions (string entityType = null, string tags = null, string name = null, int? count = null)

Get tag suggestions

Get tag suggestions for applications, device types that have been most used with a group of tags.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetTagSuggestionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TagsApi();
            var entityType = entityType_example;  // string | Entity type name. (optional) 
            var tags = tags_example;  // string | Comma separated list of tags. (optional) 
            var name = name_example;  // string | Name of tags used for type ahead. (optional) 
            var count = 56;  // int? | Number of results to return. Max 10. (optional) 

            try
            {
                // Get tag suggestions
                TagsEnvelope result = apiInstance.GetTagSuggestions(entityType, tags, name, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.GetTagSuggestions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityType** | **string**| Entity type name. | [optional] 
 **tags** | **string**| Comma separated list of tags. | [optional] 
 **name** | **string**| Name of tags used for type ahead. | [optional] 
 **count** | **int?**| Number of results to return. Max 10. | [optional] 

### Return type

[**TagsEnvelope**](TagsEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettagsbycategories"></a>
# **GetTagsByCategories**
> TagsEnvelope GetTagsByCategories (string categories = null)

Get all tags of categories

Get all tags related to the list of categories

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetTagsByCategoriesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TagsApi();
            var categories = categories_example;  // string | Comma separated list of categories. (optional) 

            try
            {
                // Get all tags of categories
                TagsEnvelope result = apiInstance.GetTagsByCategories(categories);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.GetTagsByCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categories** | **string**| Comma separated list of categories. | [optional] 

### Return type

[**TagsEnvelope**](TagsEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

