# CLOUD.Artik.Api.DevicesApi

All URIs are relative to *https://api.artik.cloud/v1.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDevice**](DevicesApi.md#adddevice) | **POST** /devices | Add Device
[**DeleteDevice**](DevicesApi.md#deletedevice) | **DELETE** /devices/{deviceId} | Delete Device
[**DeleteDeviceToken**](DevicesApi.md#deletedevicetoken) | **DELETE** /devices/{deviceId}/tokens | Delete Device Token
[**GetDevice**](DevicesApi.md#getdevice) | **GET** /devices/{deviceId} | Get Device
[**GetDevicePresence**](DevicesApi.md#getdevicepresence) | **GET** /devices/{deviceId}/presence | Get device presence information
[**GetDeviceToken**](DevicesApi.md#getdevicetoken) | **GET** /devices/{deviceId}/tokens | Get Device Token
[**UpdateDevice**](DevicesApi.md#updatedevice) | **PUT** /devices/{deviceId} | Update Device
[**UpdateDeviceToken**](DevicesApi.md#updatedevicetoken) | **PUT** /devices/{deviceId}/tokens | Update Device Token


<a name="adddevice"></a>
# **AddDevice**
> DeviceEnvelope AddDevice (Device device)

Add Device

Create a device

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class AddDeviceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var device = new Device(); // Device | Device to be added to the user

            try
            {
                // Add Device
                DeviceEnvelope result = apiInstance.AddDevice(device);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.AddDevice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **device** | [**Device**](Device.md)| Device to be added to the user | 

### Return type

[**DeviceEnvelope**](DeviceEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedevice"></a>
# **DeleteDevice**
> DeviceEnvelope DeleteDevice (string deviceId)

Delete Device

Deletes a device

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class DeleteDeviceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var deviceId = deviceId_example;  // string | deviceId

            try
            {
                // Delete Device
                DeviceEnvelope result = apiInstance.DeleteDevice(deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.DeleteDevice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**| deviceId | 

### Return type

[**DeviceEnvelope**](DeviceEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedevicetoken"></a>
# **DeleteDeviceToken**
> DeviceTokenEnvelope DeleteDeviceToken (string deviceId)

Delete Device Token

Deletes a device's token

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class DeleteDeviceTokenExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var deviceId = deviceId_example;  // string | deviceId

            try
            {
                // Delete Device Token
                DeviceTokenEnvelope result = apiInstance.DeleteDeviceToken(deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.DeleteDeviceToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**| deviceId | 

### Return type

[**DeviceTokenEnvelope**](DeviceTokenEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdevice"></a>
# **GetDevice**
> DeviceEnvelope GetDevice (string deviceId)

Get Device

Retrieves a device

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetDeviceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var deviceId = deviceId_example;  // string | deviceId

            try
            {
                // Get Device
                DeviceEnvelope result = apiInstance.GetDevice(deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.GetDevice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**| deviceId | 

### Return type

[**DeviceEnvelope**](DeviceEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdevicepresence"></a>
# **GetDevicePresence**
> PresenceEnvelope GetDevicePresence (string deviceId)

Get device presence information

Return the presence status of the given device along with the time it was last seen

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetDevicePresenceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var deviceId = deviceId_example;  // string | Device ID.

            try
            {
                // Get device presence information
                PresenceEnvelope result = apiInstance.GetDevicePresence(deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.GetDevicePresence: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**| Device ID. | 

### Return type

[**PresenceEnvelope**](PresenceEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdevicetoken"></a>
# **GetDeviceToken**
> DeviceTokenEnvelope GetDeviceToken (string deviceId)

Get Device Token

Retrieves a device's token

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetDeviceTokenExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var deviceId = deviceId_example;  // string | deviceId

            try
            {
                // Get Device Token
                DeviceTokenEnvelope result = apiInstance.GetDeviceToken(deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.GetDeviceToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**| deviceId | 

### Return type

[**DeviceTokenEnvelope**](DeviceTokenEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedevice"></a>
# **UpdateDevice**
> DeviceEnvelope UpdateDevice (string deviceId, Device device)

Update Device

Updates a device

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class UpdateDeviceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var deviceId = deviceId_example;  // string | deviceId
            var device = new Device(); // Device | Device to be updated

            try
            {
                // Update Device
                DeviceEnvelope result = apiInstance.UpdateDevice(deviceId, device);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.UpdateDevice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**| deviceId | 
 **device** | [**Device**](Device.md)| Device to be updated | 

### Return type

[**DeviceEnvelope**](DeviceEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedevicetoken"></a>
# **UpdateDeviceToken**
> DeviceTokenEnvelope UpdateDeviceToken (string deviceId)

Update Device Token

Updates a device's token

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class UpdateDeviceTokenExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var deviceId = deviceId_example;  // string | deviceId

            try
            {
                // Update Device Token
                DeviceTokenEnvelope result = apiInstance.UpdateDeviceToken(deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.UpdateDeviceToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**| deviceId | 

### Return type

[**DeviceTokenEnvelope**](DeviceTokenEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

