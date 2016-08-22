# CLOUD.Artik.Api.UsersApi

All URIs are relative to *https://api.artik.cloud/v1.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUserProperties**](UsersApi.md#createuserproperties) | **POST** /users/{userId}/properties | Create User Application Properties
[**DeleteUserProperties**](UsersApi.md#deleteuserproperties) | **DELETE** /users/{userId}/properties | Delete User Application Properties
[**GetSelf**](UsersApi.md#getself) | **GET** /users/self | Get Current User Profile
[**GetUserDeviceTypes**](UsersApi.md#getuserdevicetypes) | **GET** /users/{userId}/devicetypes | Get User Device Types
[**GetUserDevices**](UsersApi.md#getuserdevices) | **GET** /users/{userId}/devices | Get User Devices
[**GetUserProperties**](UsersApi.md#getuserproperties) | **GET** /users/{userId}/properties | Get User application properties
[**GetUserRules**](UsersApi.md#getuserrules) | **GET** /users/{userId}/rules | Get User Rules
[**UpdateUserProperties**](UsersApi.md#updateuserproperties) | **PUT** /users/{userId}/properties | Update User Application Properties


<a name="createuserproperties"></a>
# **CreateUserProperties**
> PropertiesEnvelope CreateUserProperties (string userId, AppProperties properties, string aid = null)

Create User Application Properties

Create application properties for a user

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class CreateUserPropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var properties = new AppProperties(); // AppProperties | Properties to be updated
            var aid = aid_example;  // string | Application ID (optional) 

            try
            {
                // Create User Application Properties
                PropertiesEnvelope result = apiInstance.CreateUserProperties(userId, properties, aid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUserProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **properties** | [**AppProperties**](AppProperties.md)| Properties to be updated | 
 **aid** | **string**| Application ID | [optional] 

### Return type

[**PropertiesEnvelope**](PropertiesEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuserproperties"></a>
# **DeleteUserProperties**
> PropertiesEnvelope DeleteUserProperties (string userId, string aid = null)

Delete User Application Properties

Deletes a user's application properties

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class DeleteUserPropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var aid = aid_example;  // string | Application ID (optional) 

            try
            {
                // Delete User Application Properties
                PropertiesEnvelope result = apiInstance.DeleteUserProperties(userId, aid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **aid** | **string**| Application ID | [optional] 

### Return type

[**PropertiesEnvelope**](PropertiesEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getself"></a>
# **GetSelf**
> UserEnvelope GetSelf ()

Get Current User Profile

Get's the current user's profile

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetSelfExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();

            try
            {
                // Get Current User Profile
                UserEnvelope result = apiInstance.GetSelf();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetSelf: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserEnvelope**](UserEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserdevicetypes"></a>
# **GetUserDeviceTypes**
> DeviceTypesEnvelope GetUserDeviceTypes (string userId, int? offset = null, int? count = null, bool? includeShared = null)

Get User Device Types

Retrieve User's Device Types

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetUserDeviceTypesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID.
            var offset = 56;  // int? | Offset for pagination. (optional) 
            var count = 56;  // int? | Desired count of items in the result set (optional) 
            var includeShared = true;  // bool? | Optional. Boolean (true/false) - If false, only return the user's device types. If true, also return device types shared by other users. (optional) 

            try
            {
                // Get User Device Types
                DeviceTypesEnvelope result = apiInstance.GetUserDeviceTypes(userId, offset, count, includeShared);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserDeviceTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User ID. | 
 **offset** | **int?**| Offset for pagination. | [optional] 
 **count** | **int?**| Desired count of items in the result set | [optional] 
 **includeShared** | **bool?**| Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. | [optional] 

### Return type

[**DeviceTypesEnvelope**](DeviceTypesEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserdevices"></a>
# **GetUserDevices**
> DevicesEnvelope GetUserDevices (string userId, int? offset = null, int? count = null, bool? includeProperties = null)

Get User Devices

Retrieve User's Devices

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetUserDevicesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var offset = 56;  // int? | Offset for pagination. (optional) 
            var count = 56;  // int? | Desired count of items in the result set (optional) 
            var includeProperties = true;  // bool? | Optional. Boolean (true/false) - If false, only return the user's device types. If true, also return device types shared by other users. (optional) 

            try
            {
                // Get User Devices
                DevicesEnvelope result = apiInstance.GetUserDevices(userId, offset, count, includeProperties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserDevices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User ID | 
 **offset** | **int?**| Offset for pagination. | [optional] 
 **count** | **int?**| Desired count of items in the result set | [optional] 
 **includeProperties** | **bool?**| Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. | [optional] 

### Return type

[**DevicesEnvelope**](DevicesEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserproperties"></a>
# **GetUserProperties**
> PropertiesEnvelope GetUserProperties (string userId, string aid = null)

Get User application properties

Get application properties of a user

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetUserPropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var aid = aid_example;  // string | Application ID (optional) 

            try
            {
                // Get User application properties
                PropertiesEnvelope result = apiInstance.GetUserProperties(userId, aid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **aid** | **string**| Application ID | [optional] 

### Return type

[**PropertiesEnvelope**](PropertiesEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserrules"></a>
# **GetUserRules**
> RulesEnvelope GetUserRules (string userId, bool? excludeDisabled = null, int? count = null, int? offset = null)

Get User Rules

Retrieve User's Rules

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetUserRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID.
            var excludeDisabled = true;  // bool? | Exclude disabled rules in the result. (optional) 
            var count = 56;  // int? | Desired count of items in the result set. (optional) 
            var offset = 56;  // int? | Offset for pagination. (optional) 

            try
            {
                // Get User Rules
                RulesEnvelope result = apiInstance.GetUserRules(userId, excludeDisabled, count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User ID. | 
 **excludeDisabled** | **bool?**| Exclude disabled rules in the result. | [optional] 
 **count** | **int?**| Desired count of items in the result set. | [optional] 
 **offset** | **int?**| Offset for pagination. | [optional] 

### Return type

[**RulesEnvelope**](RulesEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserproperties"></a>
# **UpdateUserProperties**
> PropertiesEnvelope UpdateUserProperties (string userId, AppProperties properties, string aid = null)

Update User Application Properties

Updates application properties of a user

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class UpdateUserPropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var properties = new AppProperties(); // AppProperties | Properties to be updated
            var aid = aid_example;  // string | Application ID (optional) 

            try
            {
                // Update User Application Properties
                PropertiesEnvelope result = apiInstance.UpdateUserProperties(userId, properties, aid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUserProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **properties** | [**AppProperties**](AppProperties.md)| Properties to be updated | 
 **aid** | **string**| Application ID | [optional] 

### Return type

[**PropertiesEnvelope**](PropertiesEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

