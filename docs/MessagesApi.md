# CLOUD.Artik.Api.MessagesApi

All URIs are relative to *https://api.artik.cloud/v1.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAggregatesHistogram**](MessagesApi.md#getaggregateshistogram) | **GET** /messages/analytics/histogram | Get Histogram aggregates
[**GetFieldPresence**](MessagesApi.md#getfieldpresence) | **GET** /messages/presence | Get normalized message presence
[**GetLastNormalizedMessages**](MessagesApi.md#getlastnormalizedmessages) | **GET** /messages/last | Get Last Normalized Message
[**GetMessageAggregates**](MessagesApi.md#getmessageaggregates) | **GET** /messages/analytics/aggregates | Get Normalized Message Aggregates
[**GetMessageSnapshots**](MessagesApi.md#getmessagesnapshots) | **GET** /messages/snapshots | Get Message Snapshots
[**GetNormalizedMessages**](MessagesApi.md#getnormalizedmessages) | **GET** /messages | Get Normalized Messages
[**SendMessageAction**](MessagesApi.md#sendmessageaction) | **POST** /messages | Send Message Action


<a name="getaggregateshistogram"></a>
# **GetAggregatesHistogram**
> AggregatesHistogramResponse GetAggregatesHistogram (long? startDate, long? endDate, string sdid = null, string field = null, string interval = null)

Get Histogram aggregates

Get Histogram on normalized messages.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetAggregatesHistogramExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagesApi();
            var startDate = 789;  // long? | Timestamp of earliest message (in milliseconds since epoch).
            var endDate = 789;  // long? | Timestamp of latest message (in milliseconds since epoch).
            var sdid = sdid_example;  // string | Source device ID of the messages being searched. (optional) 
            var field = field_example;  // string | Message field being queried for building histogram. (optional) 
            var interval = interval_example;  // string | Interval of time for building histogram blocks. (Valid values: minute, hour, day, month, year) (optional) 

            try
            {
                // Get Histogram aggregates
                AggregatesHistogramResponse result = apiInstance.GetAggregatesHistogram(startDate, endDate, sdid, field, interval);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.GetAggregatesHistogram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **long?**| Timestamp of earliest message (in milliseconds since epoch). | 
 **endDate** | **long?**| Timestamp of latest message (in milliseconds since epoch). | 
 **sdid** | **string**| Source device ID of the messages being searched. | [optional] 
 **field** | **string**| Message field being queried for building histogram. | [optional] 
 **interval** | **string**| Interval of time for building histogram blocks. (Valid values: minute, hour, day, month, year) | [optional] 

### Return type

[**AggregatesHistogramResponse**](AggregatesHistogramResponse.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfieldpresence"></a>
# **GetFieldPresence**
> FieldPresenceEnvelope GetFieldPresence (long? startDate, long? endDate, string interval, string sdid = null, string fieldPresence = null)

Get normalized message presence

Get normalized message presence.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetFieldPresenceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagesApi();
            var startDate = 789;  // long? | startDate
            var endDate = 789;  // long? | endDate
            var interval = interval_example;  // string | String representing grouping interval. One of: 'minute' (1 hour limit), 'hour' (1 day limit), 'day' (31 days limit), 'month' (1 year limit), or 'year' (10 years limit).
            var sdid = sdid_example;  // string | Source device ID of the messages being searched. (optional) 
            var fieldPresence = fieldPresence_example;  // string | String representing a field from the specified device ID. (optional) 

            try
            {
                // Get normalized message presence
                FieldPresenceEnvelope result = apiInstance.GetFieldPresence(startDate, endDate, interval, sdid, fieldPresence);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.GetFieldPresence: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **long?**| startDate | 
 **endDate** | **long?**| endDate | 
 **interval** | **string**| String representing grouping interval. One of: &#39;minute&#39; (1 hour limit), &#39;hour&#39; (1 day limit), &#39;day&#39; (31 days limit), &#39;month&#39; (1 year limit), or &#39;year&#39; (10 years limit). | 
 **sdid** | **string**| Source device ID of the messages being searched. | [optional] 
 **fieldPresence** | **string**| String representing a field from the specified device ID. | [optional] 

### Return type

[**FieldPresenceEnvelope**](FieldPresenceEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlastnormalizedmessages"></a>
# **GetLastNormalizedMessages**
> NormalizedMessagesEnvelope GetLastNormalizedMessages (int? count = null, string sdids = null, string fieldPresence = null)

Get Last Normalized Message

Get last messages normalized.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetLastNormalizedMessagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagesApi();
            var count = 56;  // int? | Number of items to return per query. (optional) 
            var sdids = sdids_example;  // string | Comma separated list of source device IDs (minimum: 1). (optional) 
            var fieldPresence = fieldPresence_example;  // string | String representing a field from the specified device ID. (optional) 

            try
            {
                // Get Last Normalized Message
                NormalizedMessagesEnvelope result = apiInstance.GetLastNormalizedMessages(count, sdids, fieldPresence);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.GetLastNormalizedMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **int?**| Number of items to return per query. | [optional] 
 **sdids** | **string**| Comma separated list of source device IDs (minimum: 1). | [optional] 
 **fieldPresence** | **string**| String representing a field from the specified device ID. | [optional] 

### Return type

[**NormalizedMessagesEnvelope**](NormalizedMessagesEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessageaggregates"></a>
# **GetMessageAggregates**
> AggregatesResponse GetMessageAggregates (string sdid, string field, long? startDate, long? endDate)

Get Normalized Message Aggregates

Get Aggregates on normalized messages.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetMessageAggregatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagesApi();
            var sdid = sdid_example;  // string | Source device ID of the messages being searched.
            var field = field_example;  // string | Message field being queried for aggregates.
            var startDate = 789;  // long? | Timestamp of earliest message (in milliseconds since epoch).
            var endDate = 789;  // long? | Timestamp of latest message (in milliseconds since epoch).

            try
            {
                // Get Normalized Message Aggregates
                AggregatesResponse result = apiInstance.GetMessageAggregates(sdid, field, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.GetMessageAggregates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sdid** | **string**| Source device ID of the messages being searched. | 
 **field** | **string**| Message field being queried for aggregates. | 
 **startDate** | **long?**| Timestamp of earliest message (in milliseconds since epoch). | 
 **endDate** | **long?**| Timestamp of latest message (in milliseconds since epoch). | 

### Return type

[**AggregatesResponse**](AggregatesResponse.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessagesnapshots"></a>
# **GetMessageSnapshots**
> SnapshotResponses GetMessageSnapshots (string sdids, bool? includeTimestamp = null)

Get Message Snapshots

Get message snapshots.

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetMessageSnapshotsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagesApi();
            var sdids = sdids_example;  // string | Device IDs for which the snapshots are requested. Max 100 device ids per call.
            var includeTimestamp = true;  // bool? | Indicates whether to return timestamps of the last update for each field. (optional) 

            try
            {
                // Get Message Snapshots
                SnapshotResponses result = apiInstance.GetMessageSnapshots(sdids, includeTimestamp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.GetMessageSnapshots: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sdids** | **string**| Device IDs for which the snapshots are requested. Max 100 device ids per call. | 
 **includeTimestamp** | **bool?**| Indicates whether to return timestamps of the last update for each field. | [optional] 

### Return type

[**SnapshotResponses**](SnapshotResponses.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnormalizedmessages"></a>
# **GetNormalizedMessages**
> NormalizedMessagesEnvelope GetNormalizedMessages (string uid = null, string sdid = null, string mid = null, string fieldPresence = null, string filter = null, string offset = null, int? count = null, long? startDate = null, long? endDate = null, string order = null)

Get Normalized Messages

Get the messages normalized

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class GetNormalizedMessagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagesApi();
            var uid = uid_example;  // string | User ID. If not specified, assume that of the current authenticated user. If specified, it must be that of a user for which the current authenticated user has read access to. (optional) 
            var sdid = sdid_example;  // string | Source device ID of the messages being searched. (optional) 
            var mid = mid_example;  // string | The SAMI message ID being searched. (optional) 
            var fieldPresence = fieldPresence_example;  // string | String representing a field from the specified device ID. (optional) 
            var filter = filter_example;  // string | Filter. (optional) 
            var offset = offset_example;  // string | A string that represents the starting item, should be the value of 'next' field received in the last response. (required for pagination) (optional) 
            var count = 56;  // int? | count (optional) 
            var startDate = 789;  // long? | startDate (optional) 
            var endDate = 789;  // long? | endDate (optional) 
            var order = order_example;  // string | Desired sort order: 'asc' or 'desc' (optional) 

            try
            {
                // Get Normalized Messages
                NormalizedMessagesEnvelope result = apiInstance.GetNormalizedMessages(uid, sdid, mid, fieldPresence, filter, offset, count, startDate, endDate, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.GetNormalizedMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uid** | **string**| User ID. If not specified, assume that of the current authenticated user. If specified, it must be that of a user for which the current authenticated user has read access to. | [optional] 
 **sdid** | **string**| Source device ID of the messages being searched. | [optional] 
 **mid** | **string**| The SAMI message ID being searched. | [optional] 
 **fieldPresence** | **string**| String representing a field from the specified device ID. | [optional] 
 **filter** | **string**| Filter. | [optional] 
 **offset** | **string**| A string that represents the starting item, should be the value of &#39;next&#39; field received in the last response. (required for pagination) | [optional] 
 **count** | **int?**| count | [optional] 
 **startDate** | **long?**| startDate | [optional] 
 **endDate** | **long?**| endDate | [optional] 
 **order** | **string**| Desired sort order: &#39;asc&#39; or &#39;desc&#39; | [optional] 

### Return type

[**NormalizedMessagesEnvelope**](NormalizedMessagesEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendmessageaction"></a>
# **SendMessageAction**
> MessageIDEnvelope SendMessageAction (MessageAction data)

Send Message Action

Send a message or an Action:<br/><table><tr><th>Combination</th><th>Parameters</th><th>Description</th></tr><tr><td>Send Message</td><td>sdid, type=message</td><td>Send a message from a Source Device</td></tr><tr><td>Send Action</td><td>ddid, type=action</td><td>Send an action to a Destination Device</td></tr><tr><td>Common</td><td>data, ts, token</td><td>Parameters that can be used with the above combinations.</td></tr></table>

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class SendMessageActionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagesApi();
            var data = new MessageAction(); // MessageAction | Message or Action object that is passed in the body

            try
            {
                // Send Message Action
                MessageIDEnvelope result = apiInstance.SendMessageAction(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.SendMessageAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**MessageAction**](MessageAction.md)| Message or Action object that is passed in the body | 

### Return type

[**MessageIDEnvelope**](MessageIDEnvelope.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

