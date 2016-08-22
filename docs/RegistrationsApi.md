# CLOUD.Artik.Api.RegistrationsApi

All URIs are relative to *https://api.artik.cloud/v1.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfirmUser**](RegistrationsApi.md#confirmuser) | **PUT** /devices/registrations/pin | Confirm User
[**GetRequestStatusForUser**](RegistrationsApi.md#getrequeststatusforuser) | **GET** /devices/registrations/{requestId}/status | Get Request Status For User
[**UnregisterDevice**](RegistrationsApi.md#unregisterdevice) | **DELETE** /devices/{deviceId}/registrations | Unregister Device


<a name="confirmuser"></a>
# **ConfirmUser**
> DeviceRegConfirmUserResponseEnvelope ConfirmUser (DeviceRegConfirmUserRequest registrationInfo)

Confirm User

This call updates the registration request issued earlier by associating it with an authenticated user and captures all additional information required to add a new device.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class ConfirmUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationsApi();
            var registrationInfo = new DeviceRegConfirmUserRequest(); // DeviceRegConfirmUserRequest | Device Registration information.

            try
            {
                // Confirm User
                DeviceRegConfirmUserResponseEnvelope result = apiInstance.ConfirmUser(registrationInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationsApi.ConfirmUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationInfo** | [**DeviceRegConfirmUserRequest**](DeviceRegConfirmUserRequest.md)| Device Registration information. | 

### Return type

[**DeviceRegConfirmUserResponseEnvelope**](DeviceRegConfirmUserResponseEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrequeststatusforuser"></a>
# **GetRequestStatusForUser**
> DeviceRegStatusResponseEnvelope GetRequestStatusForUser (string requestId)

Get Request Status For User

This call checks the status of the request so users can poll and know when registration is complete.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetRequestStatusForUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationsApi();
            var requestId = requestId_example;  // string | Request ID.

            try
            {
                // Get Request Status For User
                DeviceRegStatusResponseEnvelope result = apiInstance.GetRequestStatusForUser(requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationsApi.GetRequestStatusForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestId** | **string**| Request ID. | 

### Return type

[**DeviceRegStatusResponseEnvelope**](DeviceRegStatusResponseEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unregisterdevice"></a>
# **UnregisterDevice**
> UnregisterDeviceResponseEnvelope UnregisterDevice (string deviceId)

Unregister Device

This call clears any associations from the secure device registration.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class UnregisterDeviceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationsApi();
            var deviceId = deviceId_example;  // string | Device ID.

            try
            {
                // Unregister Device
                UnregisterDeviceResponseEnvelope result = apiInstance.UnregisterDevice(deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationsApi.UnregisterDevice: " + e.Message );
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

[**UnregisterDeviceResponseEnvelope**](UnregisterDeviceResponseEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

