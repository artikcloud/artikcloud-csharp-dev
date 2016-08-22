# CLOUD.Artik.Api.RulesApi

All URIs are relative to *https://api.artik.cloud/v1.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRule**](RulesApi.md#createrule) | **POST** /rules | Create Rule
[**DeleteRule**](RulesApi.md#deleterule) | **DELETE** /rules/{ruleId} | Delete Rule
[**GetRule**](RulesApi.md#getrule) | **GET** /rules/{ruleId} | Get Rule
[**UpdateRule**](RulesApi.md#updaterule) | **PUT** /rules/{ruleId} | Update Rule


<a name="createrule"></a>
# **CreateRule**
> RuleEnvelope CreateRule (RuleCreationInfo ruleInfo, string userId)

Create Rule

Create a new Rule

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class CreateRuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RulesApi();
            var ruleInfo = new RuleCreationInfo(); // RuleCreationInfo | Rule object that needs to be added
            var userId = userId_example;  // string | User ID

            try
            {
                // Create Rule
                RuleEnvelope result = apiInstance.CreateRule(ruleInfo, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesApi.CreateRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ruleInfo** | [**RuleCreationInfo**](RuleCreationInfo.md)| Rule object that needs to be added | 
 **userId** | **string**| User ID | 

### Return type

[**RuleEnvelope**](RuleEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterule"></a>
# **DeleteRule**
> RuleEnvelope DeleteRule (string ruleId)

Delete Rule

Delete a Rule

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class DeleteRuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RulesApi();
            var ruleId = ruleId_example;  // string | Rule ID.

            try
            {
                // Delete Rule
                RuleEnvelope result = apiInstance.DeleteRule(ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesApi.DeleteRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ruleId** | **string**| Rule ID. | 

### Return type

[**RuleEnvelope**](RuleEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrule"></a>
# **GetRule**
> RuleEnvelope GetRule (string ruleId)

Get Rule

Get a rule using the Rule ID

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetRuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RulesApi();
            var ruleId = ruleId_example;  // string | Rule ID.

            try
            {
                // Get Rule
                RuleEnvelope result = apiInstance.GetRule(ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesApi.GetRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ruleId** | **string**| Rule ID. | 

### Return type

[**RuleEnvelope**](RuleEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterule"></a>
# **UpdateRule**
> RuleEnvelope UpdateRule (string ruleId, RuleUpdateInfo ruleInfo)

Update Rule

Update an existing Rule

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class UpdateRuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RulesApi();
            var ruleId = ruleId_example;  // string | Rule ID.
            var ruleInfo = new RuleUpdateInfo(); // RuleUpdateInfo | Rule object that needs to be updated

            try
            {
                // Update Rule
                RuleEnvelope result = apiInstance.UpdateRule(ruleId, ruleInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RulesApi.UpdateRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ruleId** | **string**| Rule ID. | 
 **ruleInfo** | [**RuleUpdateInfo**](RuleUpdateInfo.md)| Rule object that needs to be updated | 

### Return type

[**RuleEnvelope**](RuleEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

