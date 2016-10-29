# CLOUD.Artik.Api.DevicesManagementApi

All URIs are relative to *https://api.artik.cloud/v1.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTasks**](DevicesManagementApi.md#createtasks) | **POST** /devicemgmt/tasks | Create a new task for one or more devices
[**DeleteServerProperties**](DevicesManagementApi.md#deleteserverproperties) | **DELETE** /devicemgmt/devices/{did}/serverproperties | Deletes a device&#39;s properties.
[**GetAllByDid**](DevicesManagementApi.md#getallbydid) | **GET** /devicemgmt/devices/{did}/tasks | Returns the list of tasks for a particular device id with optional status filter.
[**GetDeviceTypesInfo**](DevicesManagementApi.md#getdevicetypesinfo) | **GET** /devicemgmt/devicetypes/{dtid} | Read a device type device management information.
[**GetManifestProperties**](DevicesManagementApi.md#getmanifestproperties) | **GET** /devicemgmt/devicetypes/{dtid}/manifest/properties | Get a device type&#39;s device management manifest properties
[**GetProperties**](DevicesManagementApi.md#getproperties) | **GET** /devicemgmt/devices/{did}/properties | Read a device&#39;s properties.
[**GetStatuses**](DevicesManagementApi.md#getstatuses) | **GET** /devicemgmt/tasks/{tid}/statuses | Returns the details and status of a task id and the individual statuses of each device id in the list.
[**GetStatusesHistory**](DevicesManagementApi.md#getstatuseshistory) | **GET** /devicemgmt/tasks/{tid}/statuses/history | Returns the history of the status changes for a specific task id, or for a specific device id in that task.
[**GetTaskByID**](DevicesManagementApi.md#gettaskbyid) | **GET** /devicemgmt/tasks/{tid} | Returns the details and global status of a specific task id.
[**GetTasks**](DevicesManagementApi.md#gettasks) | **GET** /devicemgmt/tasks | Returns the all the tasks for a device type.
[**QueryProperties**](DevicesManagementApi.md#queryproperties) | **GET** /devicemgmt/devices/properties | Query device properties across devices.
[**UpdateDeviceTypesInfo**](DevicesManagementApi.md#updatedevicetypesinfo) | **PUT** /devicemgmt/devicetypes/{dtid} | Updates a device type information
[**UpdateServerProperties**](DevicesManagementApi.md#updateserverproperties) | **POST** /devicemgmt/devices/{did}/serverproperties | Updates a device&#39;s server properties.
[**UpdateTask**](DevicesManagementApi.md#updatetask) | **PUT** /devicemgmt/tasks/{tid} | Updates a task for all devices - For now just allows changing the state to cancelled.
[**UpdateTaskForDevice**](DevicesManagementApi.md#updatetaskfordevice) | **PUT** /devicemgmt/tasks/{tid}/devices/{did} | Updates a task for a specific device - For now just allows changing the state to cancelled.


<a name="createtasks"></a>
# **CreateTasks**
> TaskEnvelope CreateTasks (TaskRequest taskPayload)

Create a new task for one or more devices

Create a new task for one or more devices

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class CreateTasksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesManagementApi();
            var taskPayload = new TaskRequest(); // TaskRequest | Task object to be created

            try
            {
                // Create a new task for one or more devices
                TaskEnvelope result = apiInstance.CreateTasks(taskPayload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesManagementApi.CreateTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskPayload** | [**TaskRequest**](TaskRequest.md)| Task object to be created | 

### Return type

[**TaskEnvelope**](TaskEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteserverproperties"></a>
# **DeleteServerProperties**
> MetadataEnvelope DeleteServerProperties (string did)

Deletes a device's properties.

Deletes a device's properties.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class DeleteServerPropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesManagementApi();
            var did = did_example;  // string | Device ID.

            try
            {
                // Deletes a device's properties.
                MetadataEnvelope result = apiInstance.DeleteServerProperties(did);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesManagementApi.DeleteServerProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **did** | **string**| Device ID. | 

### Return type

[**MetadataEnvelope**](MetadataEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallbydid"></a>
# **GetAllByDid**
> TaskByDidListEnvelope GetAllByDid (string did, int? count = null, int? offset = null, string status = null, string order = null, string sort = null)

Returns the list of tasks for a particular device id with optional status filter.

Returns the list of tasks for a particular device id with optional status filter.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetAllByDidExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesManagementApi();
            var did = did_example;  // string | Device ID.
            var count = 56;  // int? | Max results count. (optional) 
            var offset = 56;  // int? | Result starting offset. (optional) 
            var status = status_example;  // string | Status filter. Comma-separated statuses. (optional) 
            var order = order_example;  // string | Sort results by a field. Valid fields: createdOn. (optional) 
            var sort = sort_example;  // string | Sort order. Valid values: asc or desc. (optional) 

            try
            {
                // Returns the list of tasks for a particular device id with optional status filter.
                TaskByDidListEnvelope result = apiInstance.GetAllByDid(did, count, offset, status, order, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesManagementApi.GetAllByDid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **did** | **string**| Device ID. | 
 **count** | **int?**| Max results count. | [optional] 
 **offset** | **int?**| Result starting offset. | [optional] 
 **status** | **string**| Status filter. Comma-separated statuses. | [optional] 
 **order** | **string**| Sort results by a field. Valid fields: createdOn. | [optional] 
 **sort** | **string**| Sort order. Valid values: asc or desc. | [optional] 

### Return type

[**TaskByDidListEnvelope**](TaskByDidListEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdevicetypesinfo"></a>
# **GetDeviceTypesInfo**
> DeviceTypesInfoEnvelope GetDeviceTypesInfo (string dtid)

Read a device type device management information.

Read a device type device management information.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetDeviceTypesInfoExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesManagementApi();
            var dtid = dtid_example;  // string | Device type ID.

            try
            {
                // Read a device type device management information.
                DeviceTypesInfoEnvelope result = apiInstance.GetDeviceTypesInfo(dtid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesManagementApi.GetDeviceTypesInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dtid** | **string**| Device type ID. | 

### Return type

[**DeviceTypesInfoEnvelope**](DeviceTypesInfoEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanifestproperties"></a>
# **GetManifestProperties**
> MetadataPropertiesEnvelope GetManifestProperties (string dtid)

Get a device type's device management manifest properties

Get a device type's device management manifest properties

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

            var apiInstance = new DevicesManagementApi();
            var dtid = dtid_example;  // string | Device Type ID.

            try
            {
                // Get a device type's device management manifest properties
                MetadataPropertiesEnvelope result = apiInstance.GetManifestProperties(dtid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesManagementApi.GetManifestProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dtid** | **string**| Device Type ID. | 

### Return type

[**MetadataPropertiesEnvelope**](MetadataPropertiesEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproperties"></a>
# **GetProperties**
> MetadataEnvelope GetProperties (string did, bool? includeTimestamp = null)

Read a device's properties.

Read a device's properties.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetPropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesManagementApi();
            var did = did_example;  // string | Device ID.
            var includeTimestamp = true;  // bool? | Include timestamp. (optional) 

            try
            {
                // Read a device's properties.
                MetadataEnvelope result = apiInstance.GetProperties(did, includeTimestamp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesManagementApi.GetProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **did** | **string**| Device ID. | 
 **includeTimestamp** | **bool?**| Include timestamp. | [optional] 

### Return type

[**MetadataEnvelope**](MetadataEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstatuses"></a>
# **GetStatuses**
> TaskStatusesEnvelope GetStatuses (string tid, int? count = null, int? offset = null, string status = null, string dids = null)

Returns the details and status of a task id and the individual statuses of each device id in the list.

Returns the details and status of a task id and the individual statuses of each device id in the list.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetStatusesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesManagementApi();
            var tid = tid_example;  // string | Task ID.
            var count = 56;  // int? | Max results count. (optional) 
            var offset = 56;  // int? | Result starting offset. (optional) 
            var status = status_example;  // string | Status filter. Comma-separated statuses. (optional) 
            var dids = dids_example;  // string | Devices filter. Comma-separated device IDs. (optional) 

            try
            {
                // Returns the details and status of a task id and the individual statuses of each device id in the list.
                TaskStatusesEnvelope result = apiInstance.GetStatuses(tid, count, offset, status, dids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesManagementApi.GetStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tid** | **string**| Task ID. | 
 **count** | **int?**| Max results count. | [optional] 
 **offset** | **int?**| Result starting offset. | [optional] 
 **status** | **string**| Status filter. Comma-separated statuses. | [optional] 
 **dids** | **string**| Devices filter. Comma-separated device IDs. | [optional] 

### Return type

[**TaskStatusesEnvelope**](TaskStatusesEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstatuseshistory"></a>
# **GetStatusesHistory**
> TaskStatusesHistoryEnvelope GetStatusesHistory (string tid, string did = null)

Returns the history of the status changes for a specific task id, or for a specific device id in that task.

Returns the history of the status changes for a specific task id, or for a specific device id in that task.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetStatusesHistoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesManagementApi();
            var tid = tid_example;  // string | Task ID.
            var did = did_example;  // string | Device ID. Optional. (optional) 

            try
            {
                // Returns the history of the status changes for a specific task id, or for a specific device id in that task.
                TaskStatusesHistoryEnvelope result = apiInstance.GetStatusesHistory(tid, did);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesManagementApi.GetStatusesHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tid** | **string**| Task ID. | 
 **did** | **string**| Device ID. Optional. | [optional] 

### Return type

[**TaskStatusesHistoryEnvelope**](TaskStatusesHistoryEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskbyid"></a>
# **GetTaskByID**
> TaskEnvelope GetTaskByID (string tid)

Returns the details and global status of a specific task id.

Returns the details and global status of a specific task id.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetTaskByIDExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesManagementApi();
            var tid = tid_example;  // string | Task ID.

            try
            {
                // Returns the details and global status of a specific task id.
                TaskEnvelope result = apiInstance.GetTaskByID(tid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesManagementApi.GetTaskByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tid** | **string**| Task ID. | 

### Return type

[**TaskEnvelope**](TaskEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettasks"></a>
# **GetTasks**
> TaskListEnvelope GetTasks (string dtid, int? count = null, int? offset = null, string status = null, string order = null, string sort = null)

Returns the all the tasks for a device type.

Returns the all the tasks for a device type.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetTasksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesManagementApi();
            var dtid = dtid_example;  // string | Device Type ID.
            var count = 56;  // int? | Max results count. (optional) 
            var offset = 56;  // int? | Result starting offset. (optional) 
            var status = status_example;  // string | Status filter. Comma-separated statuses. (optional) 
            var order = order_example;  // string | Sort results by a field. Valid fields: createdOn. (optional) 
            var sort = sort_example;  // string | Sort order. Valid values: asc or desc. (optional) 

            try
            {
                // Returns the all the tasks for a device type.
                TaskListEnvelope result = apiInstance.GetTasks(dtid, count, offset, status, order, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesManagementApi.GetTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dtid** | **string**| Device Type ID. | 
 **count** | **int?**| Max results count. | [optional] 
 **offset** | **int?**| Result starting offset. | [optional] 
 **status** | **string**| Status filter. Comma-separated statuses. | [optional] 
 **order** | **string**| Sort results by a field. Valid fields: createdOn. | [optional] 
 **sort** | **string**| Sort order. Valid values: asc or desc. | [optional] 

### Return type

[**TaskListEnvelope**](TaskListEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryproperties"></a>
# **QueryProperties**
> MetadataQueryEnvelope QueryProperties (string dtid, int? count = null, int? offset = null, string filter = null, bool? includeTimestamp = null)

Query device properties across devices.

Query device properties across devices.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class QueryPropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesManagementApi();
            var dtid = dtid_example;  // string | Device Type ID.
            var count = 56;  // int? | Max results count. (optional) 
            var offset = 56;  // int? | Result starting offset. (optional) 
            var filter = filter_example;  // string | Query filter. Comma-separated key=value pairs (optional) 
            var includeTimestamp = true;  // bool? | Include timestamp. (optional) 

            try
            {
                // Query device properties across devices.
                MetadataQueryEnvelope result = apiInstance.QueryProperties(dtid, count, offset, filter, includeTimestamp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesManagementApi.QueryProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dtid** | **string**| Device Type ID. | 
 **count** | **int?**| Max results count. | [optional] 
 **offset** | **int?**| Result starting offset. | [optional] 
 **filter** | **string**| Query filter. Comma-separated key&#x3D;value pairs | [optional] 
 **includeTimestamp** | **bool?**| Include timestamp. | [optional] 

### Return type

[**MetadataQueryEnvelope**](MetadataQueryEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedevicetypesinfo"></a>
# **UpdateDeviceTypesInfo**
> DeviceTypesInfoEnvelope UpdateDeviceTypesInfo (string dtid, DeviceTypesInfo deviceTypeInfo)

Updates a device type information

Updates a device type information

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class UpdateDeviceTypesInfoExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesManagementApi();
            var dtid = dtid_example;  // string | Device type ID.
            var deviceTypeInfo = new DeviceTypesInfo(); // DeviceTypesInfo | Device type info object to be set

            try
            {
                // Updates a device type information
                DeviceTypesInfoEnvelope result = apiInstance.UpdateDeviceTypesInfo(dtid, deviceTypeInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesManagementApi.UpdateDeviceTypesInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dtid** | **string**| Device type ID. | 
 **deviceTypeInfo** | [**DeviceTypesInfo**](DeviceTypesInfo.md)| Device type info object to be set | 

### Return type

[**DeviceTypesInfoEnvelope**](DeviceTypesInfoEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateserverproperties"></a>
# **UpdateServerProperties**
> MetadataEnvelope UpdateServerProperties (string did, Object deviceProperties)

Updates a device's server properties.

Updates a device's server properties.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class UpdateServerPropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesManagementApi();
            var did = did_example;  // string | Device ID.
            var deviceProperties = ;  // Object | Device properties object to be set

            try
            {
                // Updates a device's server properties.
                MetadataEnvelope result = apiInstance.UpdateServerProperties(did, deviceProperties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesManagementApi.UpdateServerProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **did** | **string**| Device ID. | 
 **deviceProperties** | **Object**| Device properties object to be set | 

### Return type

[**MetadataEnvelope**](MetadataEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetask"></a>
# **UpdateTask**
> TaskUpdateResponse UpdateTask (string tid, TaskUpdateRequest taskUpdateRequest)

Updates a task for all devices - For now just allows changing the state to cancelled.

Updates a task for all devices - For now just allows changing the state to cancelled.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class UpdateTaskExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesManagementApi();
            var tid = tid_example;  // string | Task ID.
            var taskUpdateRequest = new TaskUpdateRequest(); // TaskUpdateRequest | Task update request

            try
            {
                // Updates a task for all devices - For now just allows changing the state to cancelled.
                TaskUpdateResponse result = apiInstance.UpdateTask(tid, taskUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesManagementApi.UpdateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tid** | **string**| Task ID. | 
 **taskUpdateRequest** | [**TaskUpdateRequest**](TaskUpdateRequest.md)| Task update request | 

### Return type

[**TaskUpdateResponse**](TaskUpdateResponse.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetaskfordevice"></a>
# **UpdateTaskForDevice**
> DeviceTaskUpdateResponse UpdateTaskForDevice (string tid, string did, DeviceTaskUpdateRequest deviceTaskUpdateRequest)

Updates a task for a specific device - For now just allows changing the state to cancelled.

Updates a task for a specific device - For now just allows changing the state to cancelled.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class UpdateTaskForDeviceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesManagementApi();
            var tid = tid_example;  // string | Task ID.
            var did = did_example;  // string | Device ID.
            var deviceTaskUpdateRequest = new DeviceTaskUpdateRequest(); // DeviceTaskUpdateRequest | Device task update request

            try
            {
                // Updates a task for a specific device - For now just allows changing the state to cancelled.
                DeviceTaskUpdateResponse result = apiInstance.UpdateTaskForDevice(tid, did, deviceTaskUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesManagementApi.UpdateTaskForDevice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tid** | **string**| Task ID. | 
 **did** | **string**| Device ID. | 
 **deviceTaskUpdateRequest** | [**DeviceTaskUpdateRequest**](DeviceTaskUpdateRequest.md)| Device task update request | 

### Return type

[**DeviceTaskUpdateResponse**](DeviceTaskUpdateResponse.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

