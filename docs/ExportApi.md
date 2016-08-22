# CLOUD.Artik.Api.ExportApi

All URIs are relative to *https://api.artik.cloud/v1.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportRequest**](ExportApi.md#exportrequest) | **POST** /messages/export | Create Export Request
[**GetExportHistory**](ExportApi.md#getexporthistory) | **GET** /messages/export/history | Get Export History
[**GetExportResult**](ExportApi.md#getexportresult) | **GET** /messages/export/{exportId}/result | Get Export Result
[**GetExportStatus**](ExportApi.md#getexportstatus) | **GET** /messages/export/{exportId}/status | Check Export Status


<a name="exportrequest"></a>
# **ExportRequest**
> ExportRequestResponse ExportRequest (ExportRequestInfo exportRequestInfo)

Create Export Request

Export normalized messages. The following input combinations are supported:<br/><table><tr><th>Combination</th><th>Parameters</th><th>Description</th></tr><tr><td>Get by users</td><td>uids</td><td>Search by a list of User IDs. For each user in the list, the current authenticated user must have read access over the specified user.</td></tr><tr><td>Get by devices</td><td>sdids</td><td>Search by Source Device IDs.</td></tr><tr><td>Get by device types</td><td>uids,sdtids</td><td>Search by list of Source Device Type IDs for the given list of users.</td></tr><tr><td>Get by trial</td><td>trialId</td><td>Search by Trial ID.</td></tr><tr><td>Get by combination of parameters</td><td>uids,sdids,sdtids</td><td>Search by list of Source Device IDs. Each Device ID must belong to a Source Device Type ID and a User ID.</td></tr><tr><td>Common</td><td>startDate,endDate,order,format,url,csvHeaders</td><td>Parameters that can be used with the above combinations.</td></tr></table>

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class ExportRequestExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExportApi();
            var exportRequestInfo = new ExportRequestInfo(); // ExportRequestInfo | ExportRequest object that is passed in the body

            try
            {
                // Create Export Request
                ExportRequestResponse result = apiInstance.ExportRequest(exportRequestInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exportRequestInfo** | [**ExportRequestInfo**](ExportRequestInfo.md)| ExportRequest object that is passed in the body | 

### Return type

[**ExportRequestResponse**](ExportRequestResponse.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexporthistory"></a>
# **GetExportHistory**
> ExportHistoryResponse GetExportHistory (string trialId = null, int? count = null, int? offset = null)

Get Export History

Get the history of export requests.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetExportHistoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExportApi();
            var trialId = trialId_example;  // string | Filter by trialId. (optional) 
            var count = 56;  // int? | Pagination count. (optional) 
            var offset = 56;  // int? | Pagination offset. (optional) 

            try
            {
                // Get Export History
                ExportHistoryResponse result = apiInstance.GetExportHistory(trialId, count, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.GetExportHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **trialId** | **string**| Filter by trialId. | [optional] 
 **count** | **int?**| Pagination count. | [optional] 
 **offset** | **int?**| Pagination offset. | [optional] 

### Return type

[**ExportHistoryResponse**](ExportHistoryResponse.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexportresult"></a>
# **GetExportResult**
> string GetExportResult (string exportId)

Get Export Result

Retrieve result of the export query in tgz format. The tar file may contain one or more files with the results.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetExportResultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExportApi();
            var exportId = exportId_example;  // string | Export ID of the export query.

            try
            {
                // Get Export Result
                string result = apiInstance.GetExportResult(exportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.GetExportResult: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exportId** | **string**| Export ID of the export query. | 

### Return type

**string**

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexportstatus"></a>
# **GetExportStatus**
> ExportStatusResponse GetExportStatus (string exportId)

Check Export Status

Check status of the export query.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetExportStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExportApi();
            var exportId = exportId_example;  // string | Export ID of the export query.

            try
            {
                // Check Export Status
                ExportStatusResponse result = apiInstance.GetExportStatus(exportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.GetExportStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exportId** | **string**| Export ID of the export query. | 

### Return type

[**ExportStatusResponse**](ExportStatusResponse.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

