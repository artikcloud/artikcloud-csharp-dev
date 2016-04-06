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
    public interface IUsersApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create User Application Properties
        /// </summary>
        /// <remarks>
        /// Create application properties for a user
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="properties">Properties to be updated</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>PropertiesEnvelope</returns>
        PropertiesEnvelope CreateUserProperties (string userId, AppProperties properties, string aid = null);
  
        /// <summary>
        /// Create User Application Properties
        /// </summary>
        /// <remarks>
        /// Create application properties for a user
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="properties">Properties to be updated</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>ApiResponse of PropertiesEnvelope</returns>
        ApiResponse<PropertiesEnvelope> CreateUserPropertiesWithHttpInfo (string userId, AppProperties properties, string aid = null);
        
        /// <summary>
        /// Delete User Application Properties
        /// </summary>
        /// <remarks>
        /// Deletes a user&#39;s application properties
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>PropertiesEnvelope</returns>
        PropertiesEnvelope DeleteUserProperties (string userId, string aid = null);
  
        /// <summary>
        /// Delete User Application Properties
        /// </summary>
        /// <remarks>
        /// Deletes a user&#39;s application properties
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>ApiResponse of PropertiesEnvelope</returns>
        ApiResponse<PropertiesEnvelope> DeleteUserPropertiesWithHttpInfo (string userId, string aid = null);
        
        /// <summary>
        /// Get Current User Profile
        /// </summary>
        /// <remarks>
        /// Get&#39;s the current user&#39;s profile
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserEnvelope</returns>
        UserEnvelope GetSelf ();
  
        /// <summary>
        /// Get Current User Profile
        /// </summary>
        /// <remarks>
        /// Get&#39;s the current user&#39;s profile
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserEnvelope</returns>
        ApiResponse<UserEnvelope> GetSelfWithHttpInfo ();
        
        /// <summary>
        /// Get User Device Types
        /// </summary>
        /// <remarks>
        /// Retrieve User&#39;s Device Types
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="includeShared">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param>
        /// <returns>DeviceTypesEnvelope</returns>
        DeviceTypesEnvelope GetUserDeviceTypes (string userId, int? offset = null, int? count = null, bool? includeShared = null);
  
        /// <summary>
        /// Get User Device Types
        /// </summary>
        /// <remarks>
        /// Retrieve User&#39;s Device Types
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="includeShared">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param>
        /// <returns>ApiResponse of DeviceTypesEnvelope</returns>
        ApiResponse<DeviceTypesEnvelope> GetUserDeviceTypesWithHttpInfo (string userId, int? offset = null, int? count = null, bool? includeShared = null);
        
        /// <summary>
        /// Get User Devices
        /// </summary>
        /// <remarks>
        /// Retrieve User&#39;s Devices
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="includeProperties">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param>
        /// <returns>DevicesEnvelope</returns>
        DevicesEnvelope GetUserDevices (string userId, int? offset = null, int? count = null, bool? includeProperties = null);
  
        /// <summary>
        /// Get User Devices
        /// </summary>
        /// <remarks>
        /// Retrieve User&#39;s Devices
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="includeProperties">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param>
        /// <returns>ApiResponse of DevicesEnvelope</returns>
        ApiResponse<DevicesEnvelope> GetUserDevicesWithHttpInfo (string userId, int? offset = null, int? count = null, bool? includeProperties = null);
        
        /// <summary>
        /// Get User application properties
        /// </summary>
        /// <remarks>
        /// Get application properties of a user
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>PropertiesEnvelope</returns>
        PropertiesEnvelope GetUserProperties (string userId, string aid = null);
  
        /// <summary>
        /// Get User application properties
        /// </summary>
        /// <remarks>
        /// Get application properties of a user
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>ApiResponse of PropertiesEnvelope</returns>
        ApiResponse<PropertiesEnvelope> GetUserPropertiesWithHttpInfo (string userId, string aid = null);
        
        /// <summary>
        /// Get User Rules
        /// </summary>
        /// <remarks>
        /// Retrieve User&#39;s Rules
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param>
        /// <param name="excludeDisabled">Exclude disabled rules in the result. (optional)</param>
        /// <param name="otherApplications">List rules of other applications if current application id has full read access (optional)</param>
        /// <param name="count">Desired count of items in the result set. (optional)</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <returns>RulesEnvelope</returns>
        RulesEnvelope GetUserRules (string userId, bool? excludeDisabled = null, bool? otherApplications = null, int? count = null, int? offset = null);
  
        /// <summary>
        /// Get User Rules
        /// </summary>
        /// <remarks>
        /// Retrieve User&#39;s Rules
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param>
        /// <param name="excludeDisabled">Exclude disabled rules in the result. (optional)</param>
        /// <param name="otherApplications">List rules of other applications if current application id has full read access (optional)</param>
        /// <param name="count">Desired count of items in the result set. (optional)</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <returns>ApiResponse of RulesEnvelope</returns>
        ApiResponse<RulesEnvelope> GetUserRulesWithHttpInfo (string userId, bool? excludeDisabled = null, bool? otherApplications = null, int? count = null, int? offset = null);
        
        /// <summary>
        /// Update User Application Properties
        /// </summary>
        /// <remarks>
        /// Updates application properties of a user
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="properties">Properties to be updated</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>PropertiesEnvelope</returns>
        PropertiesEnvelope UpdateUserProperties (string userId, AppProperties properties, string aid = null);
  
        /// <summary>
        /// Update User Application Properties
        /// </summary>
        /// <remarks>
        /// Updates application properties of a user
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="properties">Properties to be updated</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>ApiResponse of PropertiesEnvelope</returns>
        ApiResponse<PropertiesEnvelope> UpdateUserPropertiesWithHttpInfo (string userId, AppProperties properties, string aid = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create User Application Properties
        /// </summary>
        /// <remarks>
        /// Create application properties for a user
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="properties">Properties to be updated</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of PropertiesEnvelope</returns>
        System.Threading.Tasks.Task<PropertiesEnvelope> CreateUserPropertiesAsync (string userId, AppProperties properties, string aid = null);

        /// <summary>
        /// Create User Application Properties
        /// </summary>
        /// <remarks>
        /// Create application properties for a user
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="properties">Properties to be updated</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of ApiResponse (PropertiesEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropertiesEnvelope>> CreateUserPropertiesAsyncWithHttpInfo (string userId, AppProperties properties, string aid = null);
        
        /// <summary>
        /// Delete User Application Properties
        /// </summary>
        /// <remarks>
        /// Deletes a user&#39;s application properties
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of PropertiesEnvelope</returns>
        System.Threading.Tasks.Task<PropertiesEnvelope> DeleteUserPropertiesAsync (string userId, string aid = null);

        /// <summary>
        /// Delete User Application Properties
        /// </summary>
        /// <remarks>
        /// Deletes a user&#39;s application properties
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of ApiResponse (PropertiesEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropertiesEnvelope>> DeleteUserPropertiesAsyncWithHttpInfo (string userId, string aid = null);
        
        /// <summary>
        /// Get Current User Profile
        /// </summary>
        /// <remarks>
        /// Get&#39;s the current user&#39;s profile
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserEnvelope</returns>
        System.Threading.Tasks.Task<UserEnvelope> GetSelfAsync ();

        /// <summary>
        /// Get Current User Profile
        /// </summary>
        /// <remarks>
        /// Get&#39;s the current user&#39;s profile
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserEnvelope>> GetSelfAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get User Device Types
        /// </summary>
        /// <remarks>
        /// Retrieve User&#39;s Device Types
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="includeShared">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param>
        /// <returns>Task of DeviceTypesEnvelope</returns>
        System.Threading.Tasks.Task<DeviceTypesEnvelope> GetUserDeviceTypesAsync (string userId, int? offset = null, int? count = null, bool? includeShared = null);

        /// <summary>
        /// Get User Device Types
        /// </summary>
        /// <remarks>
        /// Retrieve User&#39;s Device Types
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="includeShared">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param>
        /// <returns>Task of ApiResponse (DeviceTypesEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceTypesEnvelope>> GetUserDeviceTypesAsyncWithHttpInfo (string userId, int? offset = null, int? count = null, bool? includeShared = null);
        
        /// <summary>
        /// Get User Devices
        /// </summary>
        /// <remarks>
        /// Retrieve User&#39;s Devices
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="includeProperties">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param>
        /// <returns>Task of DevicesEnvelope</returns>
        System.Threading.Tasks.Task<DevicesEnvelope> GetUserDevicesAsync (string userId, int? offset = null, int? count = null, bool? includeProperties = null);

        /// <summary>
        /// Get User Devices
        /// </summary>
        /// <remarks>
        /// Retrieve User&#39;s Devices
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="includeProperties">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param>
        /// <returns>Task of ApiResponse (DevicesEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<DevicesEnvelope>> GetUserDevicesAsyncWithHttpInfo (string userId, int? offset = null, int? count = null, bool? includeProperties = null);
        
        /// <summary>
        /// Get User application properties
        /// </summary>
        /// <remarks>
        /// Get application properties of a user
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of PropertiesEnvelope</returns>
        System.Threading.Tasks.Task<PropertiesEnvelope> GetUserPropertiesAsync (string userId, string aid = null);

        /// <summary>
        /// Get User application properties
        /// </summary>
        /// <remarks>
        /// Get application properties of a user
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of ApiResponse (PropertiesEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropertiesEnvelope>> GetUserPropertiesAsyncWithHttpInfo (string userId, string aid = null);
        
        /// <summary>
        /// Get User Rules
        /// </summary>
        /// <remarks>
        /// Retrieve User&#39;s Rules
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param>
        /// <param name="excludeDisabled">Exclude disabled rules in the result. (optional)</param>
        /// <param name="otherApplications">List rules of other applications if current application id has full read access (optional)</param>
        /// <param name="count">Desired count of items in the result set. (optional)</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <returns>Task of RulesEnvelope</returns>
        System.Threading.Tasks.Task<RulesEnvelope> GetUserRulesAsync (string userId, bool? excludeDisabled = null, bool? otherApplications = null, int? count = null, int? offset = null);

        /// <summary>
        /// Get User Rules
        /// </summary>
        /// <remarks>
        /// Retrieve User&#39;s Rules
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param>
        /// <param name="excludeDisabled">Exclude disabled rules in the result. (optional)</param>
        /// <param name="otherApplications">List rules of other applications if current application id has full read access (optional)</param>
        /// <param name="count">Desired count of items in the result set. (optional)</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <returns>Task of ApiResponse (RulesEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<RulesEnvelope>> GetUserRulesAsyncWithHttpInfo (string userId, bool? excludeDisabled = null, bool? otherApplications = null, int? count = null, int? offset = null);
        
        /// <summary>
        /// Update User Application Properties
        /// </summary>
        /// <remarks>
        /// Updates application properties of a user
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="properties">Properties to be updated</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of PropertiesEnvelope</returns>
        System.Threading.Tasks.Task<PropertiesEnvelope> UpdateUserPropertiesAsync (string userId, AppProperties properties, string aid = null);

        /// <summary>
        /// Update User Application Properties
        /// </summary>
        /// <remarks>
        /// Updates application properties of a user
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="properties">Properties to be updated</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of ApiResponse (PropertiesEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropertiesEnvelope>> UpdateUserPropertiesAsyncWithHttpInfo (string userId, AppProperties properties, string aid = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Configuration configuration = null)
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
        /// Create User Application Properties Create application properties for a user
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param> 
        /// <param name="properties">Properties to be updated</param> 
        /// <param name="aid">Application ID (optional)</param> 
        /// <returns>PropertiesEnvelope</returns>
        public PropertiesEnvelope CreateUserProperties (string userId, AppProperties properties, string aid = null)
        {
             ApiResponse<PropertiesEnvelope> localVarResponse = CreateUserPropertiesWithHttpInfo(userId, properties, aid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create User Application Properties Create application properties for a user
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param> 
        /// <param name="properties">Properties to be updated</param> 
        /// <param name="aid">Application ID (optional)</param> 
        /// <returns>ApiResponse of PropertiesEnvelope</returns>
        public ApiResponse< PropertiesEnvelope > CreateUserPropertiesWithHttpInfo (string userId, AppProperties properties, string aid = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->CreateUserProperties");
            
            // verify the required parameter 'properties' is set
            if (properties == null)
                throw new ApiException(400, "Missing required parameter 'properties' when calling UsersApi->CreateUserProperties");
            
    
            var localVarPath = "/users/{userId}/properties";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (aid != null) localVarQueryParams.Add("aid", Configuration.ApiClient.ParameterToString(aid)); // query parameter
            
            
            
            if (properties.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(properties); // http body (model) parameter
            }
            else
            {
                localVarPostBody = properties; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling CreateUserProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateUserProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PropertiesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropertiesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertiesEnvelope)));
            
        }

        
        /// <summary>
        /// Create User Application Properties Create application properties for a user
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="properties">Properties to be updated</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of PropertiesEnvelope</returns>
        public async System.Threading.Tasks.Task<PropertiesEnvelope> CreateUserPropertiesAsync (string userId, AppProperties properties, string aid = null)
        {
             ApiResponse<PropertiesEnvelope> localVarResponse = await CreateUserPropertiesAsyncWithHttpInfo(userId, properties, aid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create User Application Properties Create application properties for a user
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="properties">Properties to be updated</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of ApiResponse (PropertiesEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropertiesEnvelope>> CreateUserPropertiesAsyncWithHttpInfo (string userId, AppProperties properties, string aid = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling CreateUserProperties");
            // verify the required parameter 'properties' is set
            if (properties == null) throw new ApiException(400, "Missing required parameter 'properties' when calling CreateUserProperties");
            
    
            var localVarPath = "/users/{userId}/properties";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (aid != null) localVarQueryParams.Add("aid", Configuration.ApiClient.ParameterToString(aid)); // query parameter
            
            
            
            if (properties.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(properties); // http body (model) parameter
            }
            else
            {
                localVarPostBody = properties; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling CreateUserProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateUserProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropertiesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropertiesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertiesEnvelope)));
            
        }
        
        /// <summary>
        /// Delete User Application Properties Deletes a user&#39;s application properties
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param> 
        /// <param name="aid">Application ID (optional)</param> 
        /// <returns>PropertiesEnvelope</returns>
        public PropertiesEnvelope DeleteUserProperties (string userId, string aid = null)
        {
             ApiResponse<PropertiesEnvelope> localVarResponse = DeleteUserPropertiesWithHttpInfo(userId, aid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete User Application Properties Deletes a user&#39;s application properties
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param> 
        /// <param name="aid">Application ID (optional)</param> 
        /// <returns>ApiResponse of PropertiesEnvelope</returns>
        public ApiResponse< PropertiesEnvelope > DeleteUserPropertiesWithHttpInfo (string userId, string aid = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->DeleteUserProperties");
            
    
            var localVarPath = "/users/{userId}/properties";
    
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (aid != null) localVarQueryParams.Add("aid", Configuration.ApiClient.ParameterToString(aid)); // query parameter
            
            
            
            

            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PropertiesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropertiesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertiesEnvelope)));
            
        }

        
        /// <summary>
        /// Delete User Application Properties Deletes a user&#39;s application properties
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of PropertiesEnvelope</returns>
        public async System.Threading.Tasks.Task<PropertiesEnvelope> DeleteUserPropertiesAsync (string userId, string aid = null)
        {
             ApiResponse<PropertiesEnvelope> localVarResponse = await DeleteUserPropertiesAsyncWithHttpInfo(userId, aid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete User Application Properties Deletes a user&#39;s application properties
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of ApiResponse (PropertiesEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropertiesEnvelope>> DeleteUserPropertiesAsyncWithHttpInfo (string userId, string aid = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling DeleteUserProperties");
            
    
            var localVarPath = "/users/{userId}/properties";
    
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (aid != null) localVarQueryParams.Add("aid", Configuration.ApiClient.ParameterToString(aid)); // query parameter
            
            
            
            

            
            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropertiesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropertiesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertiesEnvelope)));
            
        }
        
        /// <summary>
        /// Get Current User Profile Get&#39;s the current user&#39;s profile
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserEnvelope</returns>
        public UserEnvelope GetSelf ()
        {
             ApiResponse<UserEnvelope> localVarResponse = GetSelfWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Current User Profile Get&#39;s the current user&#39;s profile
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserEnvelope</returns>
        public ApiResponse< UserEnvelope > GetSelfWithHttpInfo ()
        {
            
    
            var localVarPath = "/users/self";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetSelf: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSelf: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserEnvelope)));
            
        }

        
        /// <summary>
        /// Get Current User Profile Get&#39;s the current user&#39;s profile
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserEnvelope</returns>
        public async System.Threading.Tasks.Task<UserEnvelope> GetSelfAsync ()
        {
             ApiResponse<UserEnvelope> localVarResponse = await GetSelfAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Current User Profile Get&#39;s the current user&#39;s profile
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserEnvelope>> GetSelfAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/users/self";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetSelf: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSelf: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserEnvelope)));
            
        }
        
        /// <summary>
        /// Get User Device Types Retrieve User&#39;s Device Types
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param> 
        /// <param name="offset">Offset for pagination. (optional)</param> 
        /// <param name="count">Desired count of items in the result set (optional)</param> 
        /// <param name="includeShared">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param> 
        /// <returns>DeviceTypesEnvelope</returns>
        public DeviceTypesEnvelope GetUserDeviceTypes (string userId, int? offset = null, int? count = null, bool? includeShared = null)
        {
             ApiResponse<DeviceTypesEnvelope> localVarResponse = GetUserDeviceTypesWithHttpInfo(userId, offset, count, includeShared);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get User Device Types Retrieve User&#39;s Device Types
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param> 
        /// <param name="offset">Offset for pagination. (optional)</param> 
        /// <param name="count">Desired count of items in the result set (optional)</param> 
        /// <param name="includeShared">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param> 
        /// <returns>ApiResponse of DeviceTypesEnvelope</returns>
        public ApiResponse< DeviceTypesEnvelope > GetUserDeviceTypesWithHttpInfo (string userId, int? offset = null, int? count = null, bool? includeShared = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserDeviceTypes");
            
    
            var localVarPath = "/users/{userId}/devicetypes";
    
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (includeShared != null) localVarQueryParams.Add("includeShared", Configuration.ApiClient.ParameterToString(includeShared)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserDeviceTypes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserDeviceTypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceTypesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceTypesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceTypesEnvelope)));
            
        }

        
        /// <summary>
        /// Get User Device Types Retrieve User&#39;s Device Types
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="includeShared">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param>
        /// <returns>Task of DeviceTypesEnvelope</returns>
        public async System.Threading.Tasks.Task<DeviceTypesEnvelope> GetUserDeviceTypesAsync (string userId, int? offset = null, int? count = null, bool? includeShared = null)
        {
             ApiResponse<DeviceTypesEnvelope> localVarResponse = await GetUserDeviceTypesAsyncWithHttpInfo(userId, offset, count, includeShared);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get User Device Types Retrieve User&#39;s Device Types
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="includeShared">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param>
        /// <returns>Task of ApiResponse (DeviceTypesEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceTypesEnvelope>> GetUserDeviceTypesAsyncWithHttpInfo (string userId, int? offset = null, int? count = null, bool? includeShared = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserDeviceTypes");
            
    
            var localVarPath = "/users/{userId}/devicetypes";
    
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (includeShared != null) localVarQueryParams.Add("includeShared", Configuration.ApiClient.ParameterToString(includeShared)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserDeviceTypes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserDeviceTypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceTypesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceTypesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceTypesEnvelope)));
            
        }
        
        /// <summary>
        /// Get User Devices Retrieve User&#39;s Devices
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param> 
        /// <param name="offset">Offset for pagination. (optional)</param> 
        /// <param name="count">Desired count of items in the result set (optional)</param> 
        /// <param name="includeProperties">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param> 
        /// <returns>DevicesEnvelope</returns>
        public DevicesEnvelope GetUserDevices (string userId, int? offset = null, int? count = null, bool? includeProperties = null)
        {
             ApiResponse<DevicesEnvelope> localVarResponse = GetUserDevicesWithHttpInfo(userId, offset, count, includeProperties);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get User Devices Retrieve User&#39;s Devices
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param> 
        /// <param name="offset">Offset for pagination. (optional)</param> 
        /// <param name="count">Desired count of items in the result set (optional)</param> 
        /// <param name="includeProperties">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param> 
        /// <returns>ApiResponse of DevicesEnvelope</returns>
        public ApiResponse< DevicesEnvelope > GetUserDevicesWithHttpInfo (string userId, int? offset = null, int? count = null, bool? includeProperties = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserDevices");
            
    
            var localVarPath = "/users/{userId}/devices";
    
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (includeProperties != null) localVarQueryParams.Add("includeProperties", Configuration.ApiClient.ParameterToString(includeProperties)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserDevices: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserDevices: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DevicesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DevicesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DevicesEnvelope)));
            
        }

        
        /// <summary>
        /// Get User Devices Retrieve User&#39;s Devices
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="includeProperties">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param>
        /// <returns>Task of DevicesEnvelope</returns>
        public async System.Threading.Tasks.Task<DevicesEnvelope> GetUserDevicesAsync (string userId, int? offset = null, int? count = null, bool? includeProperties = null)
        {
             ApiResponse<DevicesEnvelope> localVarResponse = await GetUserDevicesAsyncWithHttpInfo(userId, offset, count, includeProperties);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get User Devices Retrieve User&#39;s Devices
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="includeProperties">Optional. Boolean (true/false) - If false, only return the user&#39;s device types. If true, also return device types shared by other users. (optional)</param>
        /// <returns>Task of ApiResponse (DevicesEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DevicesEnvelope>> GetUserDevicesAsyncWithHttpInfo (string userId, int? offset = null, int? count = null, bool? includeProperties = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserDevices");
            
    
            var localVarPath = "/users/{userId}/devices";
    
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (includeProperties != null) localVarQueryParams.Add("includeProperties", Configuration.ApiClient.ParameterToString(includeProperties)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserDevices: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserDevices: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DevicesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DevicesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DevicesEnvelope)));
            
        }
        
        /// <summary>
        /// Get User application properties Get application properties of a user
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param> 
        /// <param name="aid">Application ID (optional)</param> 
        /// <returns>PropertiesEnvelope</returns>
        public PropertiesEnvelope GetUserProperties (string userId, string aid = null)
        {
             ApiResponse<PropertiesEnvelope> localVarResponse = GetUserPropertiesWithHttpInfo(userId, aid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get User application properties Get application properties of a user
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param> 
        /// <param name="aid">Application ID (optional)</param> 
        /// <returns>ApiResponse of PropertiesEnvelope</returns>
        public ApiResponse< PropertiesEnvelope > GetUserPropertiesWithHttpInfo (string userId, string aid = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserProperties");
            
    
            var localVarPath = "/users/{userId}/properties";
    
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (aid != null) localVarQueryParams.Add("aid", Configuration.ApiClient.ParameterToString(aid)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetUserProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PropertiesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropertiesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertiesEnvelope)));
            
        }

        
        /// <summary>
        /// Get User application properties Get application properties of a user
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of PropertiesEnvelope</returns>
        public async System.Threading.Tasks.Task<PropertiesEnvelope> GetUserPropertiesAsync (string userId, string aid = null)
        {
             ApiResponse<PropertiesEnvelope> localVarResponse = await GetUserPropertiesAsyncWithHttpInfo(userId, aid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get User application properties Get application properties of a user
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of ApiResponse (PropertiesEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropertiesEnvelope>> GetUserPropertiesAsyncWithHttpInfo (string userId, string aid = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserProperties");
            
    
            var localVarPath = "/users/{userId}/properties";
    
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (aid != null) localVarQueryParams.Add("aid", Configuration.ApiClient.ParameterToString(aid)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropertiesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropertiesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertiesEnvelope)));
            
        }
        
        /// <summary>
        /// Get User Rules Retrieve User&#39;s Rules
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param> 
        /// <param name="excludeDisabled">Exclude disabled rules in the result. (optional)</param> 
        /// <param name="otherApplications">List rules of other applications if current application id has full read access (optional)</param> 
        /// <param name="count">Desired count of items in the result set. (optional)</param> 
        /// <param name="offset">Offset for pagination. (optional)</param> 
        /// <returns>RulesEnvelope</returns>
        public RulesEnvelope GetUserRules (string userId, bool? excludeDisabled = null, bool? otherApplications = null, int? count = null, int? offset = null)
        {
             ApiResponse<RulesEnvelope> localVarResponse = GetUserRulesWithHttpInfo(userId, excludeDisabled, otherApplications, count, offset);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get User Rules Retrieve User&#39;s Rules
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param> 
        /// <param name="excludeDisabled">Exclude disabled rules in the result. (optional)</param> 
        /// <param name="otherApplications">List rules of other applications if current application id has full read access (optional)</param> 
        /// <param name="count">Desired count of items in the result set. (optional)</param> 
        /// <param name="offset">Offset for pagination. (optional)</param> 
        /// <returns>ApiResponse of RulesEnvelope</returns>
        public ApiResponse< RulesEnvelope > GetUserRulesWithHttpInfo (string userId, bool? excludeDisabled = null, bool? otherApplications = null, int? count = null, int? offset = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUserRules");
            
    
            var localVarPath = "/users/{userId}/rules";
    
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (excludeDisabled != null) localVarQueryParams.Add("excludeDisabled", Configuration.ApiClient.ParameterToString(excludeDisabled)); // query parameter
            if (otherApplications != null) localVarQueryParams.Add("otherApplications", Configuration.ApiClient.ParameterToString(otherApplications)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserRules: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RulesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RulesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RulesEnvelope)));
            
        }

        
        /// <summary>
        /// Get User Rules Retrieve User&#39;s Rules
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param>
        /// <param name="excludeDisabled">Exclude disabled rules in the result. (optional)</param>
        /// <param name="otherApplications">List rules of other applications if current application id has full read access (optional)</param>
        /// <param name="count">Desired count of items in the result set. (optional)</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <returns>Task of RulesEnvelope</returns>
        public async System.Threading.Tasks.Task<RulesEnvelope> GetUserRulesAsync (string userId, bool? excludeDisabled = null, bool? otherApplications = null, int? count = null, int? offset = null)
        {
             ApiResponse<RulesEnvelope> localVarResponse = await GetUserRulesAsyncWithHttpInfo(userId, excludeDisabled, otherApplications, count, offset);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get User Rules Retrieve User&#39;s Rules
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID.</param>
        /// <param name="excludeDisabled">Exclude disabled rules in the result. (optional)</param>
        /// <param name="otherApplications">List rules of other applications if current application id has full read access (optional)</param>
        /// <param name="count">Desired count of items in the result set. (optional)</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <returns>Task of ApiResponse (RulesEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RulesEnvelope>> GetUserRulesAsyncWithHttpInfo (string userId, bool? excludeDisabled = null, bool? otherApplications = null, int? count = null, int? offset = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserRules");
            
    
            var localVarPath = "/users/{userId}/rules";
    
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (excludeDisabled != null) localVarQueryParams.Add("excludeDisabled", Configuration.ApiClient.ParameterToString(excludeDisabled)); // query parameter
            if (otherApplications != null) localVarQueryParams.Add("otherApplications", Configuration.ApiClient.ParameterToString(otherApplications)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserRules: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserRules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RulesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RulesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RulesEnvelope)));
            
        }
        
        /// <summary>
        /// Update User Application Properties Updates application properties of a user
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param> 
        /// <param name="properties">Properties to be updated</param> 
        /// <param name="aid">Application ID (optional)</param> 
        /// <returns>PropertiesEnvelope</returns>
        public PropertiesEnvelope UpdateUserProperties (string userId, AppProperties properties, string aid = null)
        {
             ApiResponse<PropertiesEnvelope> localVarResponse = UpdateUserPropertiesWithHttpInfo(userId, properties, aid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update User Application Properties Updates application properties of a user
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param> 
        /// <param name="properties">Properties to be updated</param> 
        /// <param name="aid">Application ID (optional)</param> 
        /// <returns>ApiResponse of PropertiesEnvelope</returns>
        public ApiResponse< PropertiesEnvelope > UpdateUserPropertiesWithHttpInfo (string userId, AppProperties properties, string aid = null)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UpdateUserProperties");
            
            // verify the required parameter 'properties' is set
            if (properties == null)
                throw new ApiException(400, "Missing required parameter 'properties' when calling UsersApi->UpdateUserProperties");
            
    
            var localVarPath = "/users/{userId}/properties";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (aid != null) localVarQueryParams.Add("aid", Configuration.ApiClient.ParameterToString(aid)); // query parameter
            
            
            
            if (properties.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(properties); // http body (model) parameter
            }
            else
            {
                localVarPostBody = properties; // byte array
            }

            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUserProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUserProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PropertiesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropertiesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertiesEnvelope)));
            
        }

        
        /// <summary>
        /// Update User Application Properties Updates application properties of a user
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="properties">Properties to be updated</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of PropertiesEnvelope</returns>
        public async System.Threading.Tasks.Task<PropertiesEnvelope> UpdateUserPropertiesAsync (string userId, AppProperties properties, string aid = null)
        {
             ApiResponse<PropertiesEnvelope> localVarResponse = await UpdateUserPropertiesAsyncWithHttpInfo(userId, properties, aid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update User Application Properties Updates application properties of a user
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id</param>
        /// <param name="properties">Properties to be updated</param>
        /// <param name="aid">Application ID (optional)</param>
        /// <returns>Task of ApiResponse (PropertiesEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropertiesEnvelope>> UpdateUserPropertiesAsyncWithHttpInfo (string userId, AppProperties properties, string aid = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateUserProperties");
            // verify the required parameter 'properties' is set
            if (properties == null) throw new ApiException(400, "Missing required parameter 'properties' when calling UpdateUserProperties");
            
    
            var localVarPath = "/users/{userId}/properties";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (aid != null) localVarQueryParams.Add("aid", Configuration.ApiClient.ParameterToString(aid)); // query parameter
            
            
            
            if (properties.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(properties); // http body (model) parameter
            }
            else
            {
                localVarPostBody = properties; // byte array
            }

            
            // authentication (artikcloud_oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUserProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUserProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropertiesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropertiesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertiesEnvelope)));
            
        }
        
    }
    
}
