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
    public interface IExportApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create Export Request
        /// </summary>
        /// <remarks>
        /// Export normalized messages. The following input combinations are supported:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by users&lt;/td&gt;&lt;td&gt;uids&lt;/td&gt;&lt;td&gt;Search by a list of User IDs. For each user in the list, the current authenticated user must have read access over the specified user.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by devices&lt;/td&gt;&lt;td&gt;sdids&lt;/td&gt;&lt;td&gt;Search by Source Device IDs.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by device types&lt;/td&gt;&lt;td&gt;uids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device Type IDs for the given list of users.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by trial&lt;/td&gt;&lt;td&gt;trialId&lt;/td&gt;&lt;td&gt;Search by Trial ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by combination of parameters&lt;/td&gt;&lt;td&gt;uids,sdids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device IDs. Each Device ID must belong to a Source Device Type ID and a User ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;startDate,endDate,order,format,url,csvHeaders&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportRequestInfo">ExportRequest object that is passed in the body</param>
        /// <returns>ExportRequestResponse</returns>
        ExportRequestResponse ExportRequest (ExportRequestInfo exportRequestInfo);
  
        /// <summary>
        /// Create Export Request
        /// </summary>
        /// <remarks>
        /// Export normalized messages. The following input combinations are supported:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by users&lt;/td&gt;&lt;td&gt;uids&lt;/td&gt;&lt;td&gt;Search by a list of User IDs. For each user in the list, the current authenticated user must have read access over the specified user.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by devices&lt;/td&gt;&lt;td&gt;sdids&lt;/td&gt;&lt;td&gt;Search by Source Device IDs.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by device types&lt;/td&gt;&lt;td&gt;uids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device Type IDs for the given list of users.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by trial&lt;/td&gt;&lt;td&gt;trialId&lt;/td&gt;&lt;td&gt;Search by Trial ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by combination of parameters&lt;/td&gt;&lt;td&gt;uids,sdids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device IDs. Each Device ID must belong to a Source Device Type ID and a User ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;startDate,endDate,order,format,url,csvHeaders&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportRequestInfo">ExportRequest object that is passed in the body</param>
        /// <returns>ApiResponse of ExportRequestResponse</returns>
        ApiResponse<ExportRequestResponse> ExportRequestWithHttpInfo (ExportRequestInfo exportRequestInfo);
        
        /// <summary>
        /// Get Export History
        /// </summary>
        /// <remarks>
        /// Get the history of export requests.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trialId">Filter by trialId. (optional)</param>
        /// <param name="count">Pagination count. (optional)</param>
        /// <param name="offset">Pagination offset. (optional)</param>
        /// <returns>ExportHistoryResponse</returns>
        ExportHistoryResponse GetExportHistory (string trialId = null, int? count = null, int? offset = null);
  
        /// <summary>
        /// Get Export History
        /// </summary>
        /// <remarks>
        /// Get the history of export requests.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trialId">Filter by trialId. (optional)</param>
        /// <param name="count">Pagination count. (optional)</param>
        /// <param name="offset">Pagination offset. (optional)</param>
        /// <returns>ApiResponse of ExportHistoryResponse</returns>
        ApiResponse<ExportHistoryResponse> GetExportHistoryWithHttpInfo (string trialId = null, int? count = null, int? offset = null);
        
        /// <summary>
        /// Get Export Result
        /// </summary>
        /// <remarks>
        /// Retrieve result of the export query in tgz format. The tar file may contain one or more files with the results.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param>
        /// <returns>string</returns>
        string GetExportResult (string exportId);
  
        /// <summary>
        /// Get Export Result
        /// </summary>
        /// <remarks>
        /// Retrieve result of the export query in tgz format. The tar file may contain one or more files with the results.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetExportResultWithHttpInfo (string exportId);
        
        /// <summary>
        /// Check Export Status
        /// </summary>
        /// <remarks>
        /// Check status of the export query.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param>
        /// <returns>ExportStatusResponse</returns>
        ExportStatusResponse GetExportStatus (string exportId);
  
        /// <summary>
        /// Check Export Status
        /// </summary>
        /// <remarks>
        /// Check status of the export query.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param>
        /// <returns>ApiResponse of ExportStatusResponse</returns>
        ApiResponse<ExportStatusResponse> GetExportStatusWithHttpInfo (string exportId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create Export Request
        /// </summary>
        /// <remarks>
        /// Export normalized messages. The following input combinations are supported:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by users&lt;/td&gt;&lt;td&gt;uids&lt;/td&gt;&lt;td&gt;Search by a list of User IDs. For each user in the list, the current authenticated user must have read access over the specified user.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by devices&lt;/td&gt;&lt;td&gt;sdids&lt;/td&gt;&lt;td&gt;Search by Source Device IDs.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by device types&lt;/td&gt;&lt;td&gt;uids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device Type IDs for the given list of users.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by trial&lt;/td&gt;&lt;td&gt;trialId&lt;/td&gt;&lt;td&gt;Search by Trial ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by combination of parameters&lt;/td&gt;&lt;td&gt;uids,sdids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device IDs. Each Device ID must belong to a Source Device Type ID and a User ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;startDate,endDate,order,format,url,csvHeaders&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportRequestInfo">ExportRequest object that is passed in the body</param>
        /// <returns>Task of ExportRequestResponse</returns>
        System.Threading.Tasks.Task<ExportRequestResponse> ExportRequestAsync (ExportRequestInfo exportRequestInfo);

        /// <summary>
        /// Create Export Request
        /// </summary>
        /// <remarks>
        /// Export normalized messages. The following input combinations are supported:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by users&lt;/td&gt;&lt;td&gt;uids&lt;/td&gt;&lt;td&gt;Search by a list of User IDs. For each user in the list, the current authenticated user must have read access over the specified user.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by devices&lt;/td&gt;&lt;td&gt;sdids&lt;/td&gt;&lt;td&gt;Search by Source Device IDs.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by device types&lt;/td&gt;&lt;td&gt;uids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device Type IDs for the given list of users.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by trial&lt;/td&gt;&lt;td&gt;trialId&lt;/td&gt;&lt;td&gt;Search by Trial ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by combination of parameters&lt;/td&gt;&lt;td&gt;uids,sdids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device IDs. Each Device ID must belong to a Source Device Type ID and a User ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;startDate,endDate,order,format,url,csvHeaders&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportRequestInfo">ExportRequest object that is passed in the body</param>
        /// <returns>Task of ApiResponse (ExportRequestResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExportRequestResponse>> ExportRequestAsyncWithHttpInfo (ExportRequestInfo exportRequestInfo);
        
        /// <summary>
        /// Get Export History
        /// </summary>
        /// <remarks>
        /// Get the history of export requests.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trialId">Filter by trialId. (optional)</param>
        /// <param name="count">Pagination count. (optional)</param>
        /// <param name="offset">Pagination offset. (optional)</param>
        /// <returns>Task of ExportHistoryResponse</returns>
        System.Threading.Tasks.Task<ExportHistoryResponse> GetExportHistoryAsync (string trialId = null, int? count = null, int? offset = null);

        /// <summary>
        /// Get Export History
        /// </summary>
        /// <remarks>
        /// Get the history of export requests.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trialId">Filter by trialId. (optional)</param>
        /// <param name="count">Pagination count. (optional)</param>
        /// <param name="offset">Pagination offset. (optional)</param>
        /// <returns>Task of ApiResponse (ExportHistoryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExportHistoryResponse>> GetExportHistoryAsyncWithHttpInfo (string trialId = null, int? count = null, int? offset = null);
        
        /// <summary>
        /// Get Export Result
        /// </summary>
        /// <remarks>
        /// Retrieve result of the export query in tgz format. The tar file may contain one or more files with the results.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GetExportResultAsync (string exportId);

        /// <summary>
        /// Get Export Result
        /// </summary>
        /// <remarks>
        /// Retrieve result of the export query in tgz format. The tar file may contain one or more files with the results.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GetExportResultAsyncWithHttpInfo (string exportId);
        
        /// <summary>
        /// Check Export Status
        /// </summary>
        /// <remarks>
        /// Check status of the export query.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param>
        /// <returns>Task of ExportStatusResponse</returns>
        System.Threading.Tasks.Task<ExportStatusResponse> GetExportStatusAsync (string exportId);

        /// <summary>
        /// Check Export Status
        /// </summary>
        /// <remarks>
        /// Check status of the export query.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param>
        /// <returns>Task of ApiResponse (ExportStatusResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExportStatusResponse>> GetExportStatusAsyncWithHttpInfo (string exportId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ExportApi : IExportApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExportApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExportApi(Configuration configuration = null)
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
        /// Create Export Request Export normalized messages. The following input combinations are supported:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by users&lt;/td&gt;&lt;td&gt;uids&lt;/td&gt;&lt;td&gt;Search by a list of User IDs. For each user in the list, the current authenticated user must have read access over the specified user.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by devices&lt;/td&gt;&lt;td&gt;sdids&lt;/td&gt;&lt;td&gt;Search by Source Device IDs.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by device types&lt;/td&gt;&lt;td&gt;uids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device Type IDs for the given list of users.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by trial&lt;/td&gt;&lt;td&gt;trialId&lt;/td&gt;&lt;td&gt;Search by Trial ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by combination of parameters&lt;/td&gt;&lt;td&gt;uids,sdids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device IDs. Each Device ID must belong to a Source Device Type ID and a User ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;startDate,endDate,order,format,url,csvHeaders&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportRequestInfo">ExportRequest object that is passed in the body</param> 
        /// <returns>ExportRequestResponse</returns>
        public ExportRequestResponse ExportRequest (ExportRequestInfo exportRequestInfo)
        {
             ApiResponse<ExportRequestResponse> localVarResponse = ExportRequestWithHttpInfo(exportRequestInfo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Export Request Export normalized messages. The following input combinations are supported:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by users&lt;/td&gt;&lt;td&gt;uids&lt;/td&gt;&lt;td&gt;Search by a list of User IDs. For each user in the list, the current authenticated user must have read access over the specified user.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by devices&lt;/td&gt;&lt;td&gt;sdids&lt;/td&gt;&lt;td&gt;Search by Source Device IDs.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by device types&lt;/td&gt;&lt;td&gt;uids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device Type IDs for the given list of users.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by trial&lt;/td&gt;&lt;td&gt;trialId&lt;/td&gt;&lt;td&gt;Search by Trial ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by combination of parameters&lt;/td&gt;&lt;td&gt;uids,sdids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device IDs. Each Device ID must belong to a Source Device Type ID and a User ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;startDate,endDate,order,format,url,csvHeaders&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportRequestInfo">ExportRequest object that is passed in the body</param> 
        /// <returns>ApiResponse of ExportRequestResponse</returns>
        public ApiResponse< ExportRequestResponse > ExportRequestWithHttpInfo (ExportRequestInfo exportRequestInfo)
        {
            
            // verify the required parameter 'exportRequestInfo' is set
            if (exportRequestInfo == null)
                throw new ApiException(400, "Missing required parameter 'exportRequestInfo' when calling ExportApi->ExportRequest");
            
    
            var localVarPath = "/messages/export";
    
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
            
            
            
            
            if (exportRequestInfo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(exportRequestInfo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = exportRequestInfo; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling ExportRequest: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ExportRequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ExportRequestResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExportRequestResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportRequestResponse)));
            
        }

        
        /// <summary>
        /// Create Export Request Export normalized messages. The following input combinations are supported:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by users&lt;/td&gt;&lt;td&gt;uids&lt;/td&gt;&lt;td&gt;Search by a list of User IDs. For each user in the list, the current authenticated user must have read access over the specified user.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by devices&lt;/td&gt;&lt;td&gt;sdids&lt;/td&gt;&lt;td&gt;Search by Source Device IDs.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by device types&lt;/td&gt;&lt;td&gt;uids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device Type IDs for the given list of users.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by trial&lt;/td&gt;&lt;td&gt;trialId&lt;/td&gt;&lt;td&gt;Search by Trial ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by combination of parameters&lt;/td&gt;&lt;td&gt;uids,sdids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device IDs. Each Device ID must belong to a Source Device Type ID and a User ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;startDate,endDate,order,format,url,csvHeaders&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportRequestInfo">ExportRequest object that is passed in the body</param>
        /// <returns>Task of ExportRequestResponse</returns>
        public async System.Threading.Tasks.Task<ExportRequestResponse> ExportRequestAsync (ExportRequestInfo exportRequestInfo)
        {
             ApiResponse<ExportRequestResponse> localVarResponse = await ExportRequestAsyncWithHttpInfo(exportRequestInfo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Export Request Export normalized messages. The following input combinations are supported:&lt;br/&gt;&lt;table&gt;&lt;tr&gt;&lt;th&gt;Combination&lt;/th&gt;&lt;th&gt;Parameters&lt;/th&gt;&lt;th&gt;Description&lt;/th&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by users&lt;/td&gt;&lt;td&gt;uids&lt;/td&gt;&lt;td&gt;Search by a list of User IDs. For each user in the list, the current authenticated user must have read access over the specified user.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by devices&lt;/td&gt;&lt;td&gt;sdids&lt;/td&gt;&lt;td&gt;Search by Source Device IDs.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by device types&lt;/td&gt;&lt;td&gt;uids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device Type IDs for the given list of users.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by trial&lt;/td&gt;&lt;td&gt;trialId&lt;/td&gt;&lt;td&gt;Search by Trial ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Get by combination of parameters&lt;/td&gt;&lt;td&gt;uids,sdids,sdtids&lt;/td&gt;&lt;td&gt;Search by list of Source Device IDs. Each Device ID must belong to a Source Device Type ID and a User ID.&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;Common&lt;/td&gt;&lt;td&gt;startDate,endDate,order,format,url,csvHeaders&lt;/td&gt;&lt;td&gt;Parameters that can be used with the above combinations.&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportRequestInfo">ExportRequest object that is passed in the body</param>
        /// <returns>Task of ApiResponse (ExportRequestResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExportRequestResponse>> ExportRequestAsyncWithHttpInfo (ExportRequestInfo exportRequestInfo)
        {
            // verify the required parameter 'exportRequestInfo' is set
            if (exportRequestInfo == null) throw new ApiException(400, "Missing required parameter 'exportRequestInfo' when calling ExportRequest");
            
    
            var localVarPath = "/messages/export";
    
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
            
            
            
            
            if (exportRequestInfo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(exportRequestInfo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = exportRequestInfo; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling ExportRequest: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ExportRequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExportRequestResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExportRequestResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportRequestResponse)));
            
        }
        
        /// <summary>
        /// Get Export History Get the history of export requests.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trialId">Filter by trialId. (optional)</param> 
        /// <param name="count">Pagination count. (optional)</param> 
        /// <param name="offset">Pagination offset. (optional)</param> 
        /// <returns>ExportHistoryResponse</returns>
        public ExportHistoryResponse GetExportHistory (string trialId = null, int? count = null, int? offset = null)
        {
             ApiResponse<ExportHistoryResponse> localVarResponse = GetExportHistoryWithHttpInfo(trialId, count, offset);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Export History Get the history of export requests.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trialId">Filter by trialId. (optional)</param> 
        /// <param name="count">Pagination count. (optional)</param> 
        /// <param name="offset">Pagination offset. (optional)</param> 
        /// <returns>ApiResponse of ExportHistoryResponse</returns>
        public ApiResponse< ExportHistoryResponse > GetExportHistoryWithHttpInfo (string trialId = null, int? count = null, int? offset = null)
        {
            
    
            var localVarPath = "/messages/export/history";
    
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
            
            if (trialId != null) localVarQueryParams.Add("trialId", Configuration.ApiClient.ParameterToString(trialId)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetExportHistory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExportHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ExportHistoryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExportHistoryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportHistoryResponse)));
            
        }

        
        /// <summary>
        /// Get Export History Get the history of export requests.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trialId">Filter by trialId. (optional)</param>
        /// <param name="count">Pagination count. (optional)</param>
        /// <param name="offset">Pagination offset. (optional)</param>
        /// <returns>Task of ExportHistoryResponse</returns>
        public async System.Threading.Tasks.Task<ExportHistoryResponse> GetExportHistoryAsync (string trialId = null, int? count = null, int? offset = null)
        {
             ApiResponse<ExportHistoryResponse> localVarResponse = await GetExportHistoryAsyncWithHttpInfo(trialId, count, offset);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Export History Get the history of export requests.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trialId">Filter by trialId. (optional)</param>
        /// <param name="count">Pagination count. (optional)</param>
        /// <param name="offset">Pagination offset. (optional)</param>
        /// <returns>Task of ApiResponse (ExportHistoryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExportHistoryResponse>> GetExportHistoryAsyncWithHttpInfo (string trialId = null, int? count = null, int? offset = null)
        {
            
    
            var localVarPath = "/messages/export/history";
    
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
            
            if (trialId != null) localVarQueryParams.Add("trialId", Configuration.ApiClient.ParameterToString(trialId)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetExportHistory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExportHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExportHistoryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExportHistoryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportHistoryResponse)));
            
        }
        
        /// <summary>
        /// Get Export Result Retrieve result of the export query in tgz format. The tar file may contain one or more files with the results.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param> 
        /// <returns>string</returns>
        public string GetExportResult (string exportId)
        {
             ApiResponse<string> localVarResponse = GetExportResultWithHttpInfo(exportId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Export Result Retrieve result of the export query in tgz format. The tar file may contain one or more files with the results.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GetExportResultWithHttpInfo (string exportId)
        {
            
            // verify the required parameter 'exportId' is set
            if (exportId == null)
                throw new ApiException(400, "Missing required parameter 'exportId' when calling ExportApi->GetExportResult");
            
    
            var localVarPath = "/messages/export/{exportId}/result";
    
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
            if (exportId != null) localVarPathParams.Add("exportId", Configuration.ApiClient.ParameterToString(exportId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetExportResult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExportResult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Get Export Result Retrieve result of the export query in tgz format. The tar file may contain one or more files with the results.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GetExportResultAsync (string exportId)
        {
             ApiResponse<string> localVarResponse = await GetExportResultAsyncWithHttpInfo(exportId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Export Result Retrieve result of the export query in tgz format. The tar file may contain one or more files with the results.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> GetExportResultAsyncWithHttpInfo (string exportId)
        {
            // verify the required parameter 'exportId' is set
            if (exportId == null) throw new ApiException(400, "Missing required parameter 'exportId' when calling GetExportResult");
            
    
            var localVarPath = "/messages/export/{exportId}/result";
    
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
            if (exportId != null) localVarPathParams.Add("exportId", Configuration.ApiClient.ParameterToString(exportId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetExportResult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExportResult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Check Export Status Check status of the export query.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param> 
        /// <returns>ExportStatusResponse</returns>
        public ExportStatusResponse GetExportStatus (string exportId)
        {
             ApiResponse<ExportStatusResponse> localVarResponse = GetExportStatusWithHttpInfo(exportId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Check Export Status Check status of the export query.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param> 
        /// <returns>ApiResponse of ExportStatusResponse</returns>
        public ApiResponse< ExportStatusResponse > GetExportStatusWithHttpInfo (string exportId)
        {
            
            // verify the required parameter 'exportId' is set
            if (exportId == null)
                throw new ApiException(400, "Missing required parameter 'exportId' when calling ExportApi->GetExportStatus");
            
    
            var localVarPath = "/messages/export/{exportId}/status";
    
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
            if (exportId != null) localVarPathParams.Add("exportId", Configuration.ApiClient.ParameterToString(exportId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetExportStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExportStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ExportStatusResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExportStatusResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportStatusResponse)));
            
        }

        
        /// <summary>
        /// Check Export Status Check status of the export query.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param>
        /// <returns>Task of ExportStatusResponse</returns>
        public async System.Threading.Tasks.Task<ExportStatusResponse> GetExportStatusAsync (string exportId)
        {
             ApiResponse<ExportStatusResponse> localVarResponse = await GetExportStatusAsyncWithHttpInfo(exportId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Check Export Status Check status of the export query.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportId">Export ID of the export query.</param>
        /// <returns>Task of ApiResponse (ExportStatusResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExportStatusResponse>> GetExportStatusAsyncWithHttpInfo (string exportId)
        {
            // verify the required parameter 'exportId' is set
            if (exportId == null) throw new ApiException(400, "Missing required parameter 'exportId' when calling GetExportStatus");
            
    
            var localVarPath = "/messages/export/{exportId}/status";
    
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
            if (exportId != null) localVarPathParams.Add("exportId", Configuration.ApiClient.ParameterToString(exportId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetExportStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExportStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExportStatusResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExportStatusResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportStatusResponse)));
            
        }
        
    }
    
}
