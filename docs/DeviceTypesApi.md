# CLOUD.Artik.Api.DeviceTypesApi

All URIs are relative to *https://api.artik.cloud/v1.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAvailableManifestVersions**](DeviceTypesApi.md#getavailablemanifestversions) | **GET** /devicetypes/{deviceTypeId}/availablemanifestversions | Get Available Manifest Versions
[**GetDeviceType**](DeviceTypesApi.md#getdevicetype) | **GET** /devicetypes/{deviceTypeId} | Get Device Type
[**GetDeviceTypes**](DeviceTypesApi.md#getdevicetypes) | **GET** /devicetypes | Get Device Types
[**GetLatestManifestProperties**](DeviceTypesApi.md#getlatestmanifestproperties) | **GET** /devicetypes/{deviceTypeId}/manifests/latest/properties | Get Latest Manifest Properties
[**GetManifestProperties**](DeviceTypesApi.md#getmanifestproperties) | **GET** /devicetypes/{deviceTypeId}/manifests/{version}/properties | Get manifest properties


<a name="getavailablemanifestversions"></a>
# **GetAvailableManifestVersions**
> ManifestVersionsEnvelope GetAvailableManifestVersions (string deviceTypeId)

Get Available Manifest Versions

Get a Device Type's available manifest versions

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetAvailableManifestVersionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeviceTypesApi();
            var deviceTypeId = deviceTypeId_example;  // string | deviceTypeId

            try
            {
                // Get Available Manifest Versions
                ManifestVersionsEnvelope result = apiInstance.GetAvailableManifestVersions(deviceTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceTypesApi.GetAvailableManifestVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceTypeId** | **string**| deviceTypeId | 

### Return type

[**ManifestVersionsEnvelope**](ManifestVersionsEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdevicetype"></a>
# **GetDeviceType**
> DeviceTypeEnvelope GetDeviceType (string deviceTypeId)

Get Device Type

Retrieves a Device Type

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetDeviceTypeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeviceTypesApi();
            var deviceTypeId = deviceTypeId_example;  // string | deviceTypeId

            try
            {
                // Get Device Type
                DeviceTypeEnvelope result = apiInstance.GetDeviceType(deviceTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceTypesApi.GetDeviceType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceTypeId** | **string**| deviceTypeId | 

### Return type

[**DeviceTypeEnvelope**](DeviceTypeEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdevicetypes"></a>
# **GetDeviceTypes**
> DeviceTypesEnvelope GetDeviceTypes (string name, int? offset = null, int? count = null, string tags = null)

Get Device Types

Retrieves Device Types

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetDeviceTypesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeviceTypesApi();
            var name = name_example;  // string | Device Type name
            var offset = 56;  // int? | Offset for pagination. (optional) 
            var count = 56;  // int? | Desired count of items in the result set (optional) 
            var tags = tags_example;  // string | Elements tagged with the list of tags. (comma separated) (optional) 

            try
            {
                // Get Device Types
                DeviceTypesEnvelope result = apiInstance.GetDeviceTypes(name, offset, count, tags);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceTypesApi.GetDeviceTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Device Type name | 
 **offset** | **int?**| Offset for pagination. | [optional] 
 **count** | **int?**| Desired count of items in the result set | [optional] 
 **tags** | **string**| Elements tagged with the list of tags. (comma separated) | [optional] 

### Return type

[**DeviceTypesEnvelope**](DeviceTypesEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlatestmanifestproperties"></a>
# **GetLatestManifestProperties**
> ManifestPropertiesEnvelope GetLatestManifestProperties (string deviceTypeId)

Get Latest Manifest Properties

Get a Device Type's manifest properties for the latest version.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetLatestManifestPropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeviceTypesApi();
            var deviceTypeId = deviceTypeId_example;  // string | Device Type ID.

            try
            {
                // Get Latest Manifest Properties
                ManifestPropertiesEnvelope result = apiInstance.GetLatestManifestProperties(deviceTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceTypesApi.GetLatestManifestProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceTypeId** | **string**| Device Type ID. | 

### Return type

[**ManifestPropertiesEnvelope**](ManifestPropertiesEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanifestproperties"></a>
# **GetManifestProperties**
> ManifestPropertiesEnvelope GetManifestProperties (string deviceTypeId, string version)

Get manifest properties

Get a Device Type's manifest properties for a specific version.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetManifestPropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeviceTypesApi();
            var deviceTypeId = deviceTypeId_example;  // string | Device Type ID.
            var version = version_example;  // string | Manifest Version.

            try
            {
                // Get manifest properties
                ManifestPropertiesEnvelope result = apiInstance.GetManifestProperties(deviceTypeId, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceTypesApi.GetManifestProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceTypeId** | **string**| Device Type ID. | 
 **version** | **string**| Manifest Version. | 

### Return type

[**ManifestPropertiesEnvelope**](ManifestPropertiesEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

