using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace CLOUD.Artik.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMessagesApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get Histogram aggregates
        /// </summary>
        /// <remarks>
        /// Get Histogram on normalized messages.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param>
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="field">Message field being queried for building histogram. (optional)</param>
        /// <param name="interval">Interval of time for building histogram blocks. (Valid values: minute, hour, day, month, year) (optional)</param>
        /// <returns>AggregatesHistogramResponse</returns>
        AggregatesHistogramResponse GetAggregatesHistogram (long? startDate, long? endDate, string sdid = null, string field = null, string interval = null);
  
        /// <summary>
        /// Get Histogram aggregates
        /// </summary>
        /// <remarks>
        /// Get Histogram on normalized messages.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param>
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="field">Message field being queried for building histogram. (optional)</param>
        /// <param name="interval">Interval of time for building histogram blocks. (Valid values: minute, hour, day, month, year) (optional)</param>
        /// <returns>ApiResponse of AggregatesHistogramResponse</returns>
        ApiResponse<AggregatesHistogramResponse> GetAggregatesHistogramWithHttpInfo (long? startDate, long? endDate, string sdid = null, string field = null, string interval = null);
        
        /// <summary>
        /// Get normalized message presence
        /// </summary>
        /// <remarks>
        /// Get normalized message presence.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">startDate</param>
        /// <param name="endDate">endDate</param>
        /// <param name="interval">String representing grouping interval. One of: &#39;minute&#39; (1 hour limit), &#39;hour&#39; (1 day limit), &#39;day&#39; (31 days limit), &#39;month&#39; (1 year limit), or &#39;year&#39; (10 years limit).</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <returns>FieldPresenceEnvelope</returns>
        FieldPresenceEnvelope GetFieldPresence (long? startDate, long? endDate, string interval, string sdid = null, string fieldPresence = null);
  
        /// <summary>
        /// Get normalized message presence
        /// </summary>
        /// <remarks>
        /// Get normalized message presence.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">startDate</param>
        /// <param name="endDate">endDate</param>
        /// <param name="interval">String representing grouping interval. One of: &#39;minute&#39; (1 hour limit), &#39;hour&#39; (1 day limit), &#39;day&#39; (31 days limit), &#39;month&#39; (1 year limit), or &#39;year&#39; (10 years limit).</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <returns>ApiResponse of FieldPresenceEnvelope</returns>
        ApiResponse<FieldPresenceEnvelope> GetFieldPresenceWithHttpInfo (long? startDate, long? endDate, string interval, string sdid = null, string fieldPresence = null);
        
        /// <summary>
        /// Get Last Normalized Message
        /// </summary>
        /// <remarks>
        /// Get last messages normalized.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of items to return per query. (optional)</param>
        /// <param name="sdids">Comma separated list of source device IDs (minimum: 1). (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <returns>NormalizedMessagesEnvelope</returns>
        NormalizedMessagesEnvelope GetLastNormalizedMessages (int? count = null, string sdids = null, string fieldPresence = null);
  
        /// <summary>
        /// Get Last Normalized Message
        /// </summary>
        /// <remarks>
        /// Get last messages normalized.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of items to return per query. (optional)</param>
        /// <param name="sdids">Comma separated list of source device IDs (minimum: 1). (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <returns>ApiResponse of NormalizedMessagesEnvelope</returns>
        ApiResponse<NormalizedMessagesEnvelope> GetLastNormalizedMessagesWithHttpInfo (int? count = null, string sdids = null, string fieldPresence = null);
        
        /// <summary>
        /// Get Normalized Message Aggregates
        /// </summary>
        /// <remarks>
        /// Get Aggregates on normalized messages.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sdid">Source device ID of the messages being searched.</param>
        /// <param name="field">Message field being queried for aggregates.</param>
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param>
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param>
        /// <returns>AggregatesResponse</returns>
        AggregatesResponse GetMessageAggregates (string sdid, string field, long? startDate, long? endDate);
  
        /// <summary>
        /// Get Normalized Message Aggregates
        /// </summary>
        /// <remarks>
        /// Get Aggregates on normalized messages.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sdid">Source device ID of the messages being searched.</param>
        /// <param name="field">Message field being queried for aggregates.</param>
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param>
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param>
        /// <returns>ApiResponse of AggregatesResponse</returns>
        ApiResponse<AggregatesResponse> GetMessageAggregatesWithHttpInfo (string sdid, string field, long? startDate, long? endDate);
        
        /// <summary>
        /// Get Normalized Messages
        /// </summary>
        /// <remarks>
        /// Get the messages normalized
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID. If not specified, assume that of the current authenticated user. If specified, it must be that of a user for which the current authenticated user has read access to. (optional)</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="mid">The SAMI message ID being searched. (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <param name="filter">Filter. (optional)</param>
        /// <param name="offset">A string that represents the starting item, should be the value of &#39;next&#39; field received in the last response. (required for pagination) (optional)</param>
        /// <param name="count">count (optional)</param>
        /// <param name="startDate">startDate (optional)</param>
        /// <param name="endDate">endDate (optional)</param>
        /// <param name="order">Desired sort order: &#39;asc&#39; or &#39;desc&#39; (optional)</param>
        /// <returns>NormalizedMessagesEnvelope</returns>
        NormalizedMessagesEnvelope GetNormalizedMessages (string uid = null, string sdid = null, string mid = null, string fieldPresence = null, string filter = null, string offset = null, int? count = null, long? startDate = null, long? endDate = null, string order = null);
  
        /// <summary>
        /// Get Normalized Messages
        /// </summary>
        /// <remarks>
        /// Get the messages normalized
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID. If not specified, assume that of the current authenticated user. If specified, it must be that of a user for which the current authenticated user has read access to. (optional)</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="mid">The SAMI message ID being searched. (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <param name="filter">Filter. (optional)</param>
        /// <param name="offset">A string that represents the starting item, should be the value of &#39;next&#39; field received in the last response. (required for pagination) (optional)</param>
        /// <param name="count">count (optional)</param>
        /// <param name="startDate">startDate (optional)</param>
        /// <param name="endDate">endDate (optional)</param>
        /// <param name="order">Desired sort order: &#39;asc&#39; or &#39;desc&#39; (optional)</param>
        /// <returns>ApiResponse of NormalizedMessagesEnvelope</returns>
        ApiResponse<NormalizedMessagesEnvelope> GetNormalizedMessagesWithHttpInfo (string uid = null, string sdid = null, string mid = null, string fieldPresence = null, string filter = null, string offset = null, int? count = null, long? startDate = null, long? endDate = null, string order = null);
        
        /// <summary>
        /// Send Message Action
        /// </summary>
        /// <remarks>
        /// Send a message or an Action:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Message&lt;/td&gt;&lt;td&gt;sdid, type=message&lt;/td&gt;&lt;td&gt;Send a message from a Source Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Action&lt;/td&gt;&lt;td&gt;ddid, type=action&lt;/td&gt;&lt;td&gt;Send an action to a Destination Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;data, ts, token&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Message or Action object that is passed in the body</param>
        /// <returns>MessageIDEnvelope</returns>
        MessageIDEnvelope SendMessageAction (MessageAction data);
  
        /// <summary>
        /// Send Message Action
        /// </summary>
        /// <remarks>
        /// Send a message or an Action:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Message&lt;/td&gt;&lt;td&gt;sdid, type=message&lt;/td&gt;&lt;td&gt;Send a message from a Source Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Action&lt;/td&gt;&lt;td&gt;ddid, type=action&lt;/td&gt;&lt;td&gt;Send an action to a Destination Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;data, ts, token&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Message or Action object that is passed in the body</param>
        /// <returns>ApiResponse of MessageIDEnvelope</returns>
        ApiResponse<MessageIDEnvelope> SendMessageActionWithHttpInfo (MessageAction data);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get Histogram aggregates
        /// </summary>
        /// <remarks>
        /// Get Histogram on normalized messages.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param>
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="field">Message field being queried for building histogram. (optional)</param>
        /// <param name="interval">Interval of time for building histogram blocks. (Valid values: minute, hour, day, month, year) (optional)</param>
        /// <returns>Task of AggregatesHistogramResponse</returns>
        System.Threading.Tasks.Task<AggregatesHistogramResponse> GetAggregatesHistogramAsync (long? startDate, long? endDate, string sdid = null, string field = null, string interval = null);

        /// <summary>
        /// Get Histogram aggregates
        /// </summary>
        /// <remarks>
        /// Get Histogram on normalized messages.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param>
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="field">Message field being queried for building histogram. (optional)</param>
        /// <param name="interval">Interval of time for building histogram blocks. (Valid values: minute, hour, day, month, year) (optional)</param>
        /// <returns>Task of ApiResponse (AggregatesHistogramResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AggregatesHistogramResponse>> GetAggregatesHistogramAsyncWithHttpInfo (long? startDate, long? endDate, string sdid = null, string field = null, string interval = null);
        
        /// <summary>
        /// Get normalized message presence
        /// </summary>
        /// <remarks>
        /// Get normalized message presence.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">startDate</param>
        /// <param name="endDate">endDate</param>
        /// <param name="interval">String representing grouping interval. One of: &#39;minute&#39; (1 hour limit), &#39;hour&#39; (1 day limit), &#39;day&#39; (31 days limit), &#39;month&#39; (1 year limit), or &#39;year&#39; (10 years limit).</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <returns>Task of FieldPresenceEnvelope</returns>
        System.Threading.Tasks.Task<FieldPresenceEnvelope> GetFieldPresenceAsync (long? startDate, long? endDate, string interval, string sdid = null, string fieldPresence = null);

        /// <summary>
        /// Get normalized message presence
        /// </summary>
        /// <remarks>
        /// Get normalized message presence.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">startDate</param>
        /// <param name="endDate">endDate</param>
        /// <param name="interval">String representing grouping interval. One of: &#39;minute&#39; (1 hour limit), &#39;hour&#39; (1 day limit), &#39;day&#39; (31 days limit), &#39;month&#39; (1 year limit), or &#39;year&#39; (10 years limit).</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <returns>Task of ApiResponse (FieldPresenceEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<FieldPresenceEnvelope>> GetFieldPresenceAsyncWithHttpInfo (long? startDate, long? endDate, string interval, string sdid = null, string fieldPresence = null);
        
        /// <summary>
        /// Get Last Normalized Message
        /// </summary>
        /// <remarks>
        /// Get last messages normalized.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of items to return per query. (optional)</param>
        /// <param name="sdids">Comma separated list of source device IDs (minimum: 1). (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <returns>Task of NormalizedMessagesEnvelope</returns>
        System.Threading.Tasks.Task<NormalizedMessagesEnvelope> GetLastNormalizedMessagesAsync (int? count = null, string sdids = null, string fieldPresence = null);

        /// <summary>
        /// Get Last Normalized Message
        /// </summary>
        /// <remarks>
        /// Get last messages normalized.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of items to return per query. (optional)</param>
        /// <param name="sdids">Comma separated list of source device IDs (minimum: 1). (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <returns>Task of ApiResponse (NormalizedMessagesEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<NormalizedMessagesEnvelope>> GetLastNormalizedMessagesAsyncWithHttpInfo (int? count = null, string sdids = null, string fieldPresence = null);
        
        /// <summary>
        /// Get Normalized Message Aggregates
        /// </summary>
        /// <remarks>
        /// Get Aggregates on normalized messages.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sdid">Source device ID of the messages being searched.</param>
        /// <param name="field">Message field being queried for aggregates.</param>
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param>
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param>
        /// <returns>Task of AggregatesResponse</returns>
        System.Threading.Tasks.Task<AggregatesResponse> GetMessageAggregatesAsync (string sdid, string field, long? startDate, long? endDate);

        /// <summary>
        /// Get Normalized Message Aggregates
        /// </summary>
        /// <remarks>
        /// Get Aggregates on normalized messages.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sdid">Source device ID of the messages being searched.</param>
        /// <param name="field">Message field being queried for aggregates.</param>
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param>
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param>
        /// <returns>Task of ApiResponse (AggregatesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AggregatesResponse>> GetMessageAggregatesAsyncWithHttpInfo (string sdid, string field, long? startDate, long? endDate);
        
        /// <summary>
        /// Get Normalized Messages
        /// </summary>
        /// <remarks>
        /// Get the messages normalized
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID. If not specified, assume that of the current authenticated user. If specified, it must be that of a user for which the current authenticated user has read access to. (optional)</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="mid">The SAMI message ID being searched. (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <param name="filter">Filter. (optional)</param>
        /// <param name="offset">A string that represents the starting item, should be the value of &#39;next&#39; field received in the last response. (required for pagination) (optional)</param>
        /// <param name="count">count (optional)</param>
        /// <param name="startDate">startDate (optional)</param>
        /// <param name="endDate">endDate (optional)</param>
        /// <param name="order">Desired sort order: &#39;asc&#39; or &#39;desc&#39; (optional)</param>
        /// <returns>Task of NormalizedMessagesEnvelope</returns>
        System.Threading.Tasks.Task<NormalizedMessagesEnvelope> GetNormalizedMessagesAsync (string uid = null, string sdid = null, string mid = null, string fieldPresence = null, string filter = null, string offset = null, int? count = null, long? startDate = null, long? endDate = null, string order = null);

        /// <summary>
        /// Get Normalized Messages
        /// </summary>
        /// <remarks>
        /// Get the messages normalized
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID. If not specified, assume that of the current authenticated user. If specified, it must be that of a user for which the current authenticated user has read access to. (optional)</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="mid">The SAMI message ID being searched. (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <param name="filter">Filter. (optional)</param>
        /// <param name="offset">A string that represents the starting item, should be the value of &#39;next&#39; field received in the last response. (required for pagination) (optional)</param>
        /// <param name="count">count (optional)</param>
        /// <param name="startDate">startDate (optional)</param>
        /// <param name="endDate">endDate (optional)</param>
        /// <param name="order">Desired sort order: &#39;asc&#39; or &#39;desc&#39; (optional)</param>
        /// <returns>Task of ApiResponse (NormalizedMessagesEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<NormalizedMessagesEnvelope>> GetNormalizedMessagesAsyncWithHttpInfo (string uid = null, string sdid = null, string mid = null, string fieldPresence = null, string filter = null, string offset = null, int? count = null, long? startDate = null, long? endDate = null, string order = null);
        
        /// <summary>
        /// Send Message Action
        /// </summary>
        /// <remarks>
        /// Send a message or an Action:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Message&lt;/td&gt;&lt;td&gt;sdid, type=message&lt;/td&gt;&lt;td&gt;Send a message from a Source Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Action&lt;/td&gt;&lt;td&gt;ddid, type=action&lt;/td&gt;&lt;td&gt;Send an action to a Destination Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;data, ts, token&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Message or Action object that is passed in the body</param>
        /// <returns>Task of MessageIDEnvelope</returns>
        System.Threading.Tasks.Task<MessageIDEnvelope> SendMessageActionAsync (MessageAction data);

        /// <summary>
        /// Send Message Action
        /// </summary>
        /// <remarks>
        /// Send a message or an Action:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Message&lt;/td&gt;&lt;td&gt;sdid, type=message&lt;/td&gt;&lt;td&gt;Send a message from a Source Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Action&lt;/td&gt;&lt;td&gt;ddid, type=action&lt;/td&gt;&lt;td&gt;Send an action to a Destination Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;data, ts, token&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Message or Action object that is passed in the body</param>
        /// <returns>Task of ApiResponse (MessageIDEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<MessageIDEnvelope>> SendMessageActionAsyncWithHttpInfo (MessageAction data);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MessagesApi : IMessagesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MessagesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MessagesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Get Histogram aggregates Get Histogram on normalized messages.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param> 
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param> 
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param> 
        /// <param name="field">Message field being queried for building histogram. (optional)</param> 
        /// <param name="interval">Interval of time for building histogram blocks. (Valid values: minute, hour, day, month, year) (optional)</param> 
        /// <returns>AggregatesHistogramResponse</returns>
        public AggregatesHistogramResponse GetAggregatesHistogram (long? startDate, long? endDate, string sdid = null, string field = null, string interval = null)
        {
             ApiResponse<AggregatesHistogramResponse> localVarResponse = GetAggregatesHistogramWithHttpInfo(startDate, endDate, sdid, field, interval);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Histogram aggregates Get Histogram on normalized messages.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param> 
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param> 
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param> 
        /// <param name="field">Message field being queried for building histogram. (optional)</param> 
        /// <param name="interval">Interval of time for building histogram blocks. (Valid values: minute, hour, day, month, year) (optional)</param> 
        /// <returns>ApiResponse of AggregatesHistogramResponse</returns>
        public ApiResponse< AggregatesHistogramResponse > GetAggregatesHistogramWithHttpInfo (long? startDate, long? endDate, string sdid = null, string field = null, string interval = null)
        {
            
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagesApi->GetAggregatesHistogram");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagesApi->GetAggregatesHistogram");
            
    
            var localVarPath = "/messages/analytics/histogram";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (startDate != null) localVarQueryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) localVarQueryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (sdid != null) localVarQueryParams.Add("sdid", Configuration.ApiClient.ParameterToString(sdid)); // query parameter
            if (field != null) localVarQueryParams.Add("field", Configuration.ApiClient.ParameterToString(field)); // query parameter
            if (interval != null) localVarQueryParams.Add("interval", Configuration.ApiClient.ParameterToString(interval)); // query parameter
            
            
            
            

            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAggregatesHistogram: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAggregatesHistogram: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AggregatesHistogramResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AggregatesHistogramResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregatesHistogramResponse)));
            
        }

        
        /// <summary>
        /// Get Histogram aggregates Get Histogram on normalized messages.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param>
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="field">Message field being queried for building histogram. (optional)</param>
        /// <param name="interval">Interval of time for building histogram blocks. (Valid values: minute, hour, day, month, year) (optional)</param>
        /// <returns>Task of AggregatesHistogramResponse</returns>
        public async System.Threading.Tasks.Task<AggregatesHistogramResponse> GetAggregatesHistogramAsync (long? startDate, long? endDate, string sdid = null, string field = null, string interval = null)
        {
             ApiResponse<AggregatesHistogramResponse> localVarResponse = await GetAggregatesHistogramAsyncWithHttpInfo(startDate, endDate, sdid, field, interval);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Histogram aggregates Get Histogram on normalized messages.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param>
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="field">Message field being queried for building histogram. (optional)</param>
        /// <param name="interval">Interval of time for building histogram blocks. (Valid values: minute, hour, day, month, year) (optional)</param>
        /// <returns>Task of ApiResponse (AggregatesHistogramResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AggregatesHistogramResponse>> GetAggregatesHistogramAsyncWithHttpInfo (long? startDate, long? endDate, string sdid = null, string field = null, string interval = null)
        {
            // verify the required parameter 'startDate' is set
            if (startDate == null) throw new ApiException(400, "Missing required parameter 'startDate' when calling GetAggregatesHistogram");
            // verify the required parameter 'endDate' is set
            if (endDate == null) throw new ApiException(400, "Missing required parameter 'endDate' when calling GetAggregatesHistogram");
            
    
            var localVarPath = "/messages/analytics/histogram";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (startDate != null) localVarQueryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) localVarQueryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (sdid != null) localVarQueryParams.Add("sdid", Configuration.ApiClient.ParameterToString(sdid)); // query parameter
            if (field != null) localVarQueryParams.Add("field", Configuration.ApiClient.ParameterToString(field)); // query parameter
            if (interval != null) localVarQueryParams.Add("interval", Configuration.ApiClient.ParameterToString(interval)); // query parameter
            
            
            
            

            
            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAggregatesHistogram: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAggregatesHistogram: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregatesHistogramResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AggregatesHistogramResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregatesHistogramResponse)));
            
        }
        
        /// <summary>
        /// Get normalized message presence Get normalized message presence.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">startDate</param> 
        /// <param name="endDate">endDate</param> 
        /// <param name="interval">String representing grouping interval. One of: &#39;minute&#39; (1 hour limit), &#39;hour&#39; (1 day limit), &#39;day&#39; (31 days limit), &#39;month&#39; (1 year limit), or &#39;year&#39; (10 years limit).</param> 
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param> 
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param> 
        /// <returns>FieldPresenceEnvelope</returns>
        public FieldPresenceEnvelope GetFieldPresence (long? startDate, long? endDate, string interval, string sdid = null, string fieldPresence = null)
        {
             ApiResponse<FieldPresenceEnvelope> localVarResponse = GetFieldPresenceWithHttpInfo(startDate, endDate, interval, sdid, fieldPresence);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get normalized message presence Get normalized message presence.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">startDate</param> 
        /// <param name="endDate">endDate</param> 
        /// <param name="interval">String representing grouping interval. One of: &#39;minute&#39; (1 hour limit), &#39;hour&#39; (1 day limit), &#39;day&#39; (31 days limit), &#39;month&#39; (1 year limit), or &#39;year&#39; (10 years limit).</param> 
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param> 
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param> 
        /// <returns>ApiResponse of FieldPresenceEnvelope</returns>
        public ApiResponse< FieldPresenceEnvelope > GetFieldPresenceWithHttpInfo (long? startDate, long? endDate, string interval, string sdid = null, string fieldPresence = null)
        {
            
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagesApi->GetFieldPresence");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagesApi->GetFieldPresence");
            
            // verify the required parameter 'interval' is set
            if (interval == null)
                throw new ApiException(400, "Missing required parameter 'interval' when calling MessagesApi->GetFieldPresence");
            
    
            var localVarPath = "/messages/presence";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sdid != null) localVarQueryParams.Add("sdid", Configuration.ApiClient.ParameterToString(sdid)); // query parameter
            if (fieldPresence != null) localVarQueryParams.Add("fieldPresence", Configuration.ApiClient.ParameterToString(fieldPresence)); // query parameter
            if (startDate != null) localVarQueryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) localVarQueryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (interval != null) localVarQueryParams.Add("interval", Configuration.ApiClient.ParameterToString(interval)); // query parameter
            
            
            
            

            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetFieldPresence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFieldPresence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FieldPresenceEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FieldPresenceEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FieldPresenceEnvelope)));
            
        }

        
        /// <summary>
        /// Get normalized message presence Get normalized message presence.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">startDate</param>
        /// <param name="endDate">endDate</param>
        /// <param name="interval">String representing grouping interval. One of: &#39;minute&#39; (1 hour limit), &#39;hour&#39; (1 day limit), &#39;day&#39; (31 days limit), &#39;month&#39; (1 year limit), or &#39;year&#39; (10 years limit).</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <returns>Task of FieldPresenceEnvelope</returns>
        public async System.Threading.Tasks.Task<FieldPresenceEnvelope> GetFieldPresenceAsync (long? startDate, long? endDate, string interval, string sdid = null, string fieldPresence = null)
        {
             ApiResponse<FieldPresenceEnvelope> localVarResponse = await GetFieldPresenceAsyncWithHttpInfo(startDate, endDate, interval, sdid, fieldPresence);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get normalized message presence Get normalized message presence.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">startDate</param>
        /// <param name="endDate">endDate</param>
        /// <param name="interval">String representing grouping interval. One of: &#39;minute&#39; (1 hour limit), &#39;hour&#39; (1 day limit), &#39;day&#39; (31 days limit), &#39;month&#39; (1 year limit), or &#39;year&#39; (10 years limit).</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <returns>Task of ApiResponse (FieldPresenceEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FieldPresenceEnvelope>> GetFieldPresenceAsyncWithHttpInfo (long? startDate, long? endDate, string interval, string sdid = null, string fieldPresence = null)
        {
            // verify the required parameter 'startDate' is set
            if (startDate == null) throw new ApiException(400, "Missing required parameter 'startDate' when calling GetFieldPresence");
            // verify the required parameter 'endDate' is set
            if (endDate == null) throw new ApiException(400, "Missing required parameter 'endDate' when calling GetFieldPresence");
            // verify the required parameter 'interval' is set
            if (interval == null) throw new ApiException(400, "Missing required parameter 'interval' when calling GetFieldPresence");
            
    
            var localVarPath = "/messages/presence";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sdid != null) localVarQueryParams.Add("sdid", Configuration.ApiClient.ParameterToString(sdid)); // query parameter
            if (fieldPresence != null) localVarQueryParams.Add("fieldPresence", Configuration.ApiClient.ParameterToString(fieldPresence)); // query parameter
            if (startDate != null) localVarQueryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) localVarQueryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (interval != null) localVarQueryParams.Add("interval", Configuration.ApiClient.ParameterToString(interval)); // query parameter
            
            
            
            

            
            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetFieldPresence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFieldPresence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FieldPresenceEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FieldPresenceEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FieldPresenceEnvelope)));
            
        }
        
        /// <summary>
        /// Get Last Normalized Message Get last messages normalized.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of items to return per query. (optional)</param> 
        /// <param name="sdids">Comma separated list of source device IDs (minimum: 1). (optional)</param> 
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param> 
        /// <returns>NormalizedMessagesEnvelope</returns>
        public NormalizedMessagesEnvelope GetLastNormalizedMessages (int? count = null, string sdids = null, string fieldPresence = null)
        {
             ApiResponse<NormalizedMessagesEnvelope> localVarResponse = GetLastNormalizedMessagesWithHttpInfo(count, sdids, fieldPresence);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Last Normalized Message Get last messages normalized.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of items to return per query. (optional)</param> 
        /// <param name="sdids">Comma separated list of source device IDs (minimum: 1). (optional)</param> 
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param> 
        /// <returns>ApiResponse of NormalizedMessagesEnvelope</returns>
        public ApiResponse< NormalizedMessagesEnvelope > GetLastNormalizedMessagesWithHttpInfo (int? count = null, string sdids = null, string fieldPresence = null)
        {
            
    
            var localVarPath = "/messages/last";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (sdids != null) localVarQueryParams.Add("sdids", Configuration.ApiClient.ParameterToString(sdids)); // query parameter
            if (fieldPresence != null) localVarQueryParams.Add("fieldPresence", Configuration.ApiClient.ParameterToString(fieldPresence)); // query parameter
            
            
            
            

            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetLastNormalizedMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLastNormalizedMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NormalizedMessagesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NormalizedMessagesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NormalizedMessagesEnvelope)));
            
        }

        
        /// <summary>
        /// Get Last Normalized Message Get last messages normalized.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of items to return per query. (optional)</param>
        /// <param name="sdids">Comma separated list of source device IDs (minimum: 1). (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <returns>Task of NormalizedMessagesEnvelope</returns>
        public async System.Threading.Tasks.Task<NormalizedMessagesEnvelope> GetLastNormalizedMessagesAsync (int? count = null, string sdids = null, string fieldPresence = null)
        {
             ApiResponse<NormalizedMessagesEnvelope> localVarResponse = await GetLastNormalizedMessagesAsyncWithHttpInfo(count, sdids, fieldPresence);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Last Normalized Message Get last messages normalized.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of items to return per query. (optional)</param>
        /// <param name="sdids">Comma separated list of source device IDs (minimum: 1). (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <returns>Task of ApiResponse (NormalizedMessagesEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NormalizedMessagesEnvelope>> GetLastNormalizedMessagesAsyncWithHttpInfo (int? count = null, string sdids = null, string fieldPresence = null)
        {
            
    
            var localVarPath = "/messages/last";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (sdids != null) localVarQueryParams.Add("sdids", Configuration.ApiClient.ParameterToString(sdids)); // query parameter
            if (fieldPresence != null) localVarQueryParams.Add("fieldPresence", Configuration.ApiClient.ParameterToString(fieldPresence)); // query parameter
            
            
            
            

            
            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetLastNormalizedMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLastNormalizedMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NormalizedMessagesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NormalizedMessagesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NormalizedMessagesEnvelope)));
            
        }
        
        /// <summary>
        /// Get Normalized Message Aggregates Get Aggregates on normalized messages.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sdid">Source device ID of the messages being searched.</param> 
        /// <param name="field">Message field being queried for aggregates.</param> 
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param> 
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param> 
        /// <returns>AggregatesResponse</returns>
        public AggregatesResponse GetMessageAggregates (string sdid, string field, long? startDate, long? endDate)
        {
             ApiResponse<AggregatesResponse> localVarResponse = GetMessageAggregatesWithHttpInfo(sdid, field, startDate, endDate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Normalized Message Aggregates Get Aggregates on normalized messages.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sdid">Source device ID of the messages being searched.</param> 
        /// <param name="field">Message field being queried for aggregates.</param> 
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param> 
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param> 
        /// <returns>ApiResponse of AggregatesResponse</returns>
        public ApiResponse< AggregatesResponse > GetMessageAggregatesWithHttpInfo (string sdid, string field, long? startDate, long? endDate)
        {
            
            // verify the required parameter 'sdid' is set
            if (sdid == null)
                throw new ApiException(400, "Missing required parameter 'sdid' when calling MessagesApi->GetMessageAggregates");
            
            // verify the required parameter 'field' is set
            if (field == null)
                throw new ApiException(400, "Missing required parameter 'field' when calling MessagesApi->GetMessageAggregates");
            
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagesApi->GetMessageAggregates");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagesApi->GetMessageAggregates");
            
    
            var localVarPath = "/messages/analytics/aggregates";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sdid != null) localVarQueryParams.Add("sdid", Configuration.ApiClient.ParameterToString(sdid)); // query parameter
            if (field != null) localVarQueryParams.Add("field", Configuration.ApiClient.ParameterToString(field)); // query parameter
            if (startDate != null) localVarQueryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) localVarQueryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            
            
            
            

            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessageAggregates: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessageAggregates: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AggregatesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AggregatesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregatesResponse)));
            
        }

        
        /// <summary>
        /// Get Normalized Message Aggregates Get Aggregates on normalized messages.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sdid">Source device ID of the messages being searched.</param>
        /// <param name="field">Message field being queried for aggregates.</param>
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param>
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param>
        /// <returns>Task of AggregatesResponse</returns>
        public async System.Threading.Tasks.Task<AggregatesResponse> GetMessageAggregatesAsync (string sdid, string field, long? startDate, long? endDate)
        {
             ApiResponse<AggregatesResponse> localVarResponse = await GetMessageAggregatesAsyncWithHttpInfo(sdid, field, startDate, endDate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Normalized Message Aggregates Get Aggregates on normalized messages.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sdid">Source device ID of the messages being searched.</param>
        /// <param name="field">Message field being queried for aggregates.</param>
        /// <param name="startDate">Timestamp of earliest message (in milliseconds since epoch).</param>
        /// <param name="endDate">Timestamp of latest message (in milliseconds since epoch).</param>
        /// <returns>Task of ApiResponse (AggregatesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AggregatesResponse>> GetMessageAggregatesAsyncWithHttpInfo (string sdid, string field, long? startDate, long? endDate)
        {
            // verify the required parameter 'sdid' is set
            if (sdid == null) throw new ApiException(400, "Missing required parameter 'sdid' when calling GetMessageAggregates");
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetMessageAggregates");
            // verify the required parameter 'startDate' is set
            if (startDate == null) throw new ApiException(400, "Missing required parameter 'startDate' when calling GetMessageAggregates");
            // verify the required parameter 'endDate' is set
            if (endDate == null) throw new ApiException(400, "Missing required parameter 'endDate' when calling GetMessageAggregates");
            
    
            var localVarPath = "/messages/analytics/aggregates";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sdid != null) localVarQueryParams.Add("sdid", Configuration.ApiClient.ParameterToString(sdid)); // query parameter
            if (field != null) localVarQueryParams.Add("field", Configuration.ApiClient.ParameterToString(field)); // query parameter
            if (startDate != null) localVarQueryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) localVarQueryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            
            
            
            

            
            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessageAggregates: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessageAggregates: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregatesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AggregatesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregatesResponse)));
            
        }
        
        /// <summary>
        /// Get Normalized Messages Get the messages normalized
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID. If not specified, assume that of the current authenticated user. If specified, it must be that of a user for which the current authenticated user has read access to. (optional)</param> 
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param> 
        /// <param name="mid">The SAMI message ID being searched. (optional)</param> 
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param> 
        /// <param name="filter">Filter. (optional)</param> 
        /// <param name="offset">A string that represents the starting item, should be the value of &#39;next&#39; field received in the last response. (required for pagination) (optional)</param> 
        /// <param name="count">count (optional)</param> 
        /// <param name="startDate">startDate (optional)</param> 
        /// <param name="endDate">endDate (optional)</param> 
        /// <param name="order">Desired sort order: &#39;asc&#39; or &#39;desc&#39; (optional)</param> 
        /// <returns>NormalizedMessagesEnvelope</returns>
        public NormalizedMessagesEnvelope GetNormalizedMessages (string uid = null, string sdid = null, string mid = null, string fieldPresence = null, string filter = null, string offset = null, int? count = null, long? startDate = null, long? endDate = null, string order = null)
        {
             ApiResponse<NormalizedMessagesEnvelope> localVarResponse = GetNormalizedMessagesWithHttpInfo(uid, sdid, mid, fieldPresence, filter, offset, count, startDate, endDate, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Normalized Messages Get the messages normalized
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID. If not specified, assume that of the current authenticated user. If specified, it must be that of a user for which the current authenticated user has read access to. (optional)</param> 
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param> 
        /// <param name="mid">The SAMI message ID being searched. (optional)</param> 
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param> 
        /// <param name="filter">Filter. (optional)</param> 
        /// <param name="offset">A string that represents the starting item, should be the value of &#39;next&#39; field received in the last response. (required for pagination) (optional)</param> 
        /// <param name="count">count (optional)</param> 
        /// <param name="startDate">startDate (optional)</param> 
        /// <param name="endDate">endDate (optional)</param> 
        /// <param name="order">Desired sort order: &#39;asc&#39; or &#39;desc&#39; (optional)</param> 
        /// <returns>ApiResponse of NormalizedMessagesEnvelope</returns>
        public ApiResponse< NormalizedMessagesEnvelope > GetNormalizedMessagesWithHttpInfo (string uid = null, string sdid = null, string mid = null, string fieldPresence = null, string filter = null, string offset = null, int? count = null, long? startDate = null, long? endDate = null, string order = null)
        {
            
    
            var localVarPath = "/messages";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (uid != null) localVarQueryParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // query parameter
            if (sdid != null) localVarQueryParams.Add("sdid", Configuration.ApiClient.ParameterToString(sdid)); // query parameter
            if (mid != null) localVarQueryParams.Add("mid", Configuration.ApiClient.ParameterToString(mid)); // query parameter
            if (fieldPresence != null) localVarQueryParams.Add("fieldPresence", Configuration.ApiClient.ParameterToString(fieldPresence)); // query parameter
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (startDate != null) localVarQueryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) localVarQueryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (order != null) localVarQueryParams.Add("order", Configuration.ApiClient.ParameterToString(order)); // query parameter
            
            
            
            

            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetNormalizedMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetNormalizedMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NormalizedMessagesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NormalizedMessagesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NormalizedMessagesEnvelope)));
            
        }

        
        /// <summary>
        /// Get Normalized Messages Get the messages normalized
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID. If not specified, assume that of the current authenticated user. If specified, it must be that of a user for which the current authenticated user has read access to. (optional)</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="mid">The SAMI message ID being searched. (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <param name="filter">Filter. (optional)</param>
        /// <param name="offset">A string that represents the starting item, should be the value of &#39;next&#39; field received in the last response. (required for pagination) (optional)</param>
        /// <param name="count">count (optional)</param>
        /// <param name="startDate">startDate (optional)</param>
        /// <param name="endDate">endDate (optional)</param>
        /// <param name="order">Desired sort order: &#39;asc&#39; or &#39;desc&#39; (optional)</param>
        /// <returns>Task of NormalizedMessagesEnvelope</returns>
        public async System.Threading.Tasks.Task<NormalizedMessagesEnvelope> GetNormalizedMessagesAsync (string uid = null, string sdid = null, string mid = null, string fieldPresence = null, string filter = null, string offset = null, int? count = null, long? startDate = null, long? endDate = null, string order = null)
        {
             ApiResponse<NormalizedMessagesEnvelope> localVarResponse = await GetNormalizedMessagesAsyncWithHttpInfo(uid, sdid, mid, fieldPresence, filter, offset, count, startDate, endDate, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Normalized Messages Get the messages normalized
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uid">User ID. If not specified, assume that of the current authenticated user. If specified, it must be that of a user for which the current authenticated user has read access to. (optional)</param>
        /// <param name="sdid">Source device ID of the messages being searched. (optional)</param>
        /// <param name="mid">The SAMI message ID being searched. (optional)</param>
        /// <param name="fieldPresence">String representing a field from the specified device ID. (optional)</param>
        /// <param name="filter">Filter. (optional)</param>
        /// <param name="offset">A string that represents the starting item, should be the value of &#39;next&#39; field received in the last response. (required for pagination) (optional)</param>
        /// <param name="count">count (optional)</param>
        /// <param name="startDate">startDate (optional)</param>
        /// <param name="endDate">endDate (optional)</param>
        /// <param name="order">Desired sort order: &#39;asc&#39; or &#39;desc&#39; (optional)</param>
        /// <returns>Task of ApiResponse (NormalizedMessagesEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NormalizedMessagesEnvelope>> GetNormalizedMessagesAsyncWithHttpInfo (string uid = null, string sdid = null, string mid = null, string fieldPresence = null, string filter = null, string offset = null, int? count = null, long? startDate = null, long? endDate = null, string order = null)
        {
            
    
            var localVarPath = "/messages";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (uid != null) localVarQueryParams.Add("uid", Configuration.ApiClient.ParameterToString(uid)); // query parameter
            if (sdid != null) localVarQueryParams.Add("sdid", Configuration.ApiClient.ParameterToString(sdid)); // query parameter
            if (mid != null) localVarQueryParams.Add("mid", Configuration.ApiClient.ParameterToString(mid)); // query parameter
            if (fieldPresence != null) localVarQueryParams.Add("fieldPresence", Configuration.ApiClient.ParameterToString(fieldPresence)); // query parameter
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (startDate != null) localVarQueryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) localVarQueryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (order != null) localVarQueryParams.Add("order", Configuration.ApiClient.ParameterToString(order)); // query parameter
            
            
            
            

            
            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetNormalizedMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetNormalizedMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NormalizedMessagesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NormalizedMessagesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NormalizedMessagesEnvelope)));
            
        }
        
        /// <summary>
        /// Send Message Action Send a message or an Action:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Message&lt;/td&gt;&lt;td&gt;sdid, type=message&lt;/td&gt;&lt;td&gt;Send a message from a Source Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Action&lt;/td&gt;&lt;td&gt;ddid, type=action&lt;/td&gt;&lt;td&gt;Send an action to a Destination Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;data, ts, token&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Message or Action object that is passed in the body</param> 
        /// <returns>MessageIDEnvelope</returns>
        public MessageIDEnvelope SendMessageAction (MessageAction data)
        {
             ApiResponse<MessageIDEnvelope> localVarResponse = SendMessageActionWithHttpInfo(data);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send Message Action Send a message or an Action:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Message&lt;/td&gt;&lt;td&gt;sdid, type=message&lt;/td&gt;&lt;td&gt;Send a message from a Source Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Action&lt;/td&gt;&lt;td&gt;ddid, type=action&lt;/td&gt;&lt;td&gt;Send an action to a Destination Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;data, ts, token&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Message or Action object that is passed in the body</param> 
        /// <returns>ApiResponse of MessageIDEnvelope</returns>
        public ApiResponse< MessageIDEnvelope > SendMessageActionWithHttpInfo (MessageAction data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling MessagesApi->SendMessageAction");
            
    
            var localVarPath = "/messages";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (data.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }

            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SendMessageAction: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SendMessageAction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MessageIDEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageIDEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageIDEnvelope)));
            
        }

        
        /// <summary>
        /// Send Message Action Send a message or an Action:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Message&lt;/td&gt;&lt;td&gt;sdid, type=message&lt;/td&gt;&lt;td&gt;Send a message from a Source Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Action&lt;/td&gt;&lt;td&gt;ddid, type=action&lt;/td&gt;&lt;td&gt;Send an action to a Destination Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;data, ts, token&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Message or Action object that is passed in the body</param>
        /// <returns>Task of MessageIDEnvelope</returns>
        public async System.Threading.Tasks.Task<MessageIDEnvelope> SendMessageActionAsync (MessageAction data)
        {
             ApiResponse<MessageIDEnvelope> localVarResponse = await SendMessageActionAsyncWithHttpInfo(data);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send Message Action Send a message or an Action:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Message&lt;/td&gt;&lt;td&gt;sdid, type=message&lt;/td&gt;&lt;td&gt;Send a message from a Source Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Send Action&lt;/td&gt;&lt;td&gt;ddid, type=action&lt;/td&gt;&lt;td&gt;Send an action to a Destination Device&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;data, ts, token&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Message or Action object that is passed in the body</param>
        /// <returns>Task of ApiResponse (MessageIDEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MessageIDEnvelope>> SendMessageActionAsyncWithHttpInfo (MessageAction data)
        {
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling SendMessageAction");
            
    
            var localVarPath = "/messages";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (data.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }

            
            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SendMessageAction: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SendMessageAction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessageIDEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageIDEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageIDEnvelope)));
            
        }
        
    }
    
}
