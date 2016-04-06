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
    public interface IDeviceTypesApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get Available Manifest Versions
        /// </summary>
        /// <remarks>
        /// Get a Device Type&#39;s available manifest versions
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param>
        /// <returns>ManifestVersionsEnvelope</returns>
        ManifestVersionsEnvelope GetAvailableManifestVersions (string deviceTypeId);
  
        /// <summary>
        /// Get Available Manifest Versions
        /// </summary>
        /// <remarks>
        /// Get a Device Type&#39;s available manifest versions
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param>
        /// <returns>ApiResponse of ManifestVersionsEnvelope</returns>
        ApiResponse<ManifestVersionsEnvelope> GetAvailableManifestVersionsWithHttpInfo (string deviceTypeId);
        
        /// <summary>
        /// Get Device Type
        /// </summary>
        /// <remarks>
        /// Retrieves a Device Type
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param>
        /// <returns>DeviceTypeEnvelope</returns>
        DeviceTypeEnvelope GetDeviceType (string deviceTypeId);
  
        /// <summary>
        /// Get Device Type
        /// </summary>
        /// <remarks>
        /// Retrieves a Device Type
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param>
        /// <returns>ApiResponse of DeviceTypeEnvelope</returns>
        ApiResponse<DeviceTypeEnvelope> GetDeviceTypeWithHttpInfo (string deviceTypeId);
        
        /// <summary>
        /// Get Device Types
        /// </summary>
        /// <remarks>
        /// Retrieves Device Types
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Device Type name</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="tags">Elements tagged with the list of tags. (comma separated) (optional)</param>
        /// <returns>DeviceTypesEnvelope</returns>
        DeviceTypesEnvelope GetDeviceTypes (string name, int? offset = null, int? count = null, string tags = null);
  
        /// <summary>
        /// Get Device Types
        /// </summary>
        /// <remarks>
        /// Retrieves Device Types
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Device Type name</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="tags">Elements tagged with the list of tags. (comma separated) (optional)</param>
        /// <returns>ApiResponse of DeviceTypesEnvelope</returns>
        ApiResponse<DeviceTypesEnvelope> GetDeviceTypesWithHttpInfo (string name, int? offset = null, int? count = null, string tags = null);
        
        /// <summary>
        /// Get Latest Manifest Properties
        /// </summary>
        /// <remarks>
        /// Get a Device Type&#39;s manifest properties for the latest version.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param>
        /// <returns>ManifestPropertiesEnvelope</returns>
        ManifestPropertiesEnvelope GetLatestManifestProperties (string deviceTypeId);
  
        /// <summary>
        /// Get Latest Manifest Properties
        /// </summary>
        /// <remarks>
        /// Get a Device Type&#39;s manifest properties for the latest version.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param>
        /// <returns>ApiResponse of ManifestPropertiesEnvelope</returns>
        ApiResponse<ManifestPropertiesEnvelope> GetLatestManifestPropertiesWithHttpInfo (string deviceTypeId);
        
        /// <summary>
        /// Get manifest properties
        /// </summary>
        /// <remarks>
        /// Get a Device Type&#39;s manifest properties for a specific version.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param>
        /// <param name="version">Manifest Version.</param>
        /// <returns>ManifestPropertiesEnvelope</returns>
        ManifestPropertiesEnvelope GetManifestProperties (string deviceTypeId, string version);
  
        /// <summary>
        /// Get manifest properties
        /// </summary>
        /// <remarks>
        /// Get a Device Type&#39;s manifest properties for a specific version.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param>
        /// <param name="version">Manifest Version.</param>
        /// <returns>ApiResponse of ManifestPropertiesEnvelope</returns>
        ApiResponse<ManifestPropertiesEnvelope> GetManifestPropertiesWithHttpInfo (string deviceTypeId, string version);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get Available Manifest Versions
        /// </summary>
        /// <remarks>
        /// Get a Device Type&#39;s available manifest versions
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param>
        /// <returns>Task of ManifestVersionsEnvelope</returns>
        System.Threading.Tasks.Task<ManifestVersionsEnvelope> GetAvailableManifestVersionsAsync (string deviceTypeId);

        /// <summary>
        /// Get Available Manifest Versions
        /// </summary>
        /// <remarks>
        /// Get a Device Type&#39;s available manifest versions
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param>
        /// <returns>Task of ApiResponse (ManifestVersionsEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManifestVersionsEnvelope>> GetAvailableManifestVersionsAsyncWithHttpInfo (string deviceTypeId);
        
        /// <summary>
        /// Get Device Type
        /// </summary>
        /// <remarks>
        /// Retrieves a Device Type
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param>
        /// <returns>Task of DeviceTypeEnvelope</returns>
        System.Threading.Tasks.Task<DeviceTypeEnvelope> GetDeviceTypeAsync (string deviceTypeId);

        /// <summary>
        /// Get Device Type
        /// </summary>
        /// <remarks>
        /// Retrieves a Device Type
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param>
        /// <returns>Task of ApiResponse (DeviceTypeEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceTypeEnvelope>> GetDeviceTypeAsyncWithHttpInfo (string deviceTypeId);
        
        /// <summary>
        /// Get Device Types
        /// </summary>
        /// <remarks>
        /// Retrieves Device Types
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Device Type name</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="tags">Elements tagged with the list of tags. (comma separated) (optional)</param>
        /// <returns>Task of DeviceTypesEnvelope</returns>
        System.Threading.Tasks.Task<DeviceTypesEnvelope> GetDeviceTypesAsync (string name, int? offset = null, int? count = null, string tags = null);

        /// <summary>
        /// Get Device Types
        /// </summary>
        /// <remarks>
        /// Retrieves Device Types
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Device Type name</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="tags">Elements tagged with the list of tags. (comma separated) (optional)</param>
        /// <returns>Task of ApiResponse (DeviceTypesEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceTypesEnvelope>> GetDeviceTypesAsyncWithHttpInfo (string name, int? offset = null, int? count = null, string tags = null);
        
        /// <summary>
        /// Get Latest Manifest Properties
        /// </summary>
        /// <remarks>
        /// Get a Device Type&#39;s manifest properties for the latest version.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param>
        /// <returns>Task of ManifestPropertiesEnvelope</returns>
        System.Threading.Tasks.Task<ManifestPropertiesEnvelope> GetLatestManifestPropertiesAsync (string deviceTypeId);

        /// <summary>
        /// Get Latest Manifest Properties
        /// </summary>
        /// <remarks>
        /// Get a Device Type&#39;s manifest properties for the latest version.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param>
        /// <returns>Task of ApiResponse (ManifestPropertiesEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManifestPropertiesEnvelope>> GetLatestManifestPropertiesAsyncWithHttpInfo (string deviceTypeId);
        
        /// <summary>
        /// Get manifest properties
        /// </summary>
        /// <remarks>
        /// Get a Device Type&#39;s manifest properties for a specific version.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param>
        /// <param name="version">Manifest Version.</param>
        /// <returns>Task of ManifestPropertiesEnvelope</returns>
        System.Threading.Tasks.Task<ManifestPropertiesEnvelope> GetManifestPropertiesAsync (string deviceTypeId, string version);

        /// <summary>
        /// Get manifest properties
        /// </summary>
        /// <remarks>
        /// Get a Device Type&#39;s manifest properties for a specific version.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param>
        /// <param name="version">Manifest Version.</param>
        /// <returns>Task of ApiResponse (ManifestPropertiesEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManifestPropertiesEnvelope>> GetManifestPropertiesAsyncWithHttpInfo (string deviceTypeId, string version);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DeviceTypesApi : IDeviceTypesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceTypesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeviceTypesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceTypesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeviceTypesApi(Configuration configuration = null)
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
        /// Get Available Manifest Versions Get a Device Type&#39;s available manifest versions
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param> 
        /// <returns>ManifestVersionsEnvelope</returns>
        public ManifestVersionsEnvelope GetAvailableManifestVersions (string deviceTypeId)
        {
             ApiResponse<ManifestVersionsEnvelope> localVarResponse = GetAvailableManifestVersionsWithHttpInfo(deviceTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Available Manifest Versions Get a Device Type&#39;s available manifest versions
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param> 
        /// <returns>ApiResponse of ManifestVersionsEnvelope</returns>
        public ApiResponse< ManifestVersionsEnvelope > GetAvailableManifestVersionsWithHttpInfo (string deviceTypeId)
        {
            
            // verify the required parameter 'deviceTypeId' is set
            if (deviceTypeId == null)
                throw new ApiException(400, "Missing required parameter 'deviceTypeId' when calling DeviceTypesApi->GetAvailableManifestVersions");
            
    
            var localVarPath = "/devicetypes/{deviceTypeId}/availablemanifestversions";
    
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
            if (deviceTypeId != null) localVarPathParams.Add("deviceTypeId", Configuration.ApiClient.ParameterToString(deviceTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetAvailableManifestVersions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAvailableManifestVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ManifestVersionsEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManifestVersionsEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManifestVersionsEnvelope)));
            
        }

        
        /// <summary>
        /// Get Available Manifest Versions Get a Device Type&#39;s available manifest versions
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param>
        /// <returns>Task of ManifestVersionsEnvelope</returns>
        public async System.Threading.Tasks.Task<ManifestVersionsEnvelope> GetAvailableManifestVersionsAsync (string deviceTypeId)
        {
             ApiResponse<ManifestVersionsEnvelope> localVarResponse = await GetAvailableManifestVersionsAsyncWithHttpInfo(deviceTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Available Manifest Versions Get a Device Type&#39;s available manifest versions
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param>
        /// <returns>Task of ApiResponse (ManifestVersionsEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManifestVersionsEnvelope>> GetAvailableManifestVersionsAsyncWithHttpInfo (string deviceTypeId)
        {
            // verify the required parameter 'deviceTypeId' is set
            if (deviceTypeId == null) throw new ApiException(400, "Missing required parameter 'deviceTypeId' when calling GetAvailableManifestVersions");
            
    
            var localVarPath = "/devicetypes/{deviceTypeId}/availablemanifestversions";
    
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
            if (deviceTypeId != null) localVarPathParams.Add("deviceTypeId", Configuration.ApiClient.ParameterToString(deviceTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetAvailableManifestVersions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAvailableManifestVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManifestVersionsEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManifestVersionsEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManifestVersionsEnvelope)));
            
        }
        
        /// <summary>
        /// Get Device Type Retrieves a Device Type
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param> 
        /// <returns>DeviceTypeEnvelope</returns>
        public DeviceTypeEnvelope GetDeviceType (string deviceTypeId)
        {
             ApiResponse<DeviceTypeEnvelope> localVarResponse = GetDeviceTypeWithHttpInfo(deviceTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Device Type Retrieves a Device Type
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param> 
        /// <returns>ApiResponse of DeviceTypeEnvelope</returns>
        public ApiResponse< DeviceTypeEnvelope > GetDeviceTypeWithHttpInfo (string deviceTypeId)
        {
            
            // verify the required parameter 'deviceTypeId' is set
            if (deviceTypeId == null)
                throw new ApiException(400, "Missing required parameter 'deviceTypeId' when calling DeviceTypesApi->GetDeviceType");
            
    
            var localVarPath = "/devicetypes/{deviceTypeId}";
    
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
            if (deviceTypeId != null) localVarPathParams.Add("deviceTypeId", Configuration.ApiClient.ParameterToString(deviceTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDeviceType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDeviceType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceTypeEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceTypeEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceTypeEnvelope)));
            
        }

        
        /// <summary>
        /// Get Device Type Retrieves a Device Type
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param>
        /// <returns>Task of DeviceTypeEnvelope</returns>
        public async System.Threading.Tasks.Task<DeviceTypeEnvelope> GetDeviceTypeAsync (string deviceTypeId)
        {
             ApiResponse<DeviceTypeEnvelope> localVarResponse = await GetDeviceTypeAsyncWithHttpInfo(deviceTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Device Type Retrieves a Device Type
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">deviceTypeId</param>
        /// <returns>Task of ApiResponse (DeviceTypeEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceTypeEnvelope>> GetDeviceTypeAsyncWithHttpInfo (string deviceTypeId)
        {
            // verify the required parameter 'deviceTypeId' is set
            if (deviceTypeId == null) throw new ApiException(400, "Missing required parameter 'deviceTypeId' when calling GetDeviceType");
            
    
            var localVarPath = "/devicetypes/{deviceTypeId}";
    
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
            if (deviceTypeId != null) localVarPathParams.Add("deviceTypeId", Configuration.ApiClient.ParameterToString(deviceTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDeviceType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDeviceType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceTypeEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceTypeEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceTypeEnvelope)));
            
        }
        
        /// <summary>
        /// Get Device Types Retrieves Device Types
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Device Type name</param> 
        /// <param name="offset">Offset for pagination. (optional)</param> 
        /// <param name="count">Desired count of items in the result set (optional)</param> 
        /// <param name="tags">Elements tagged with the list of tags. (comma separated) (optional)</param> 
        /// <returns>DeviceTypesEnvelope</returns>
        public DeviceTypesEnvelope GetDeviceTypes (string name, int? offset = null, int? count = null, string tags = null)
        {
             ApiResponse<DeviceTypesEnvelope> localVarResponse = GetDeviceTypesWithHttpInfo(name, offset, count, tags);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Device Types Retrieves Device Types
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Device Type name</param> 
        /// <param name="offset">Offset for pagination. (optional)</param> 
        /// <param name="count">Desired count of items in the result set (optional)</param> 
        /// <param name="tags">Elements tagged with the list of tags. (comma separated) (optional)</param> 
        /// <returns>ApiResponse of DeviceTypesEnvelope</returns>
        public ApiResponse< DeviceTypesEnvelope > GetDeviceTypesWithHttpInfo (string name, int? offset = null, int? count = null, string tags = null)
        {
            
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling DeviceTypesApi->GetDeviceTypes");
            
    
            var localVarPath = "/devicetypes";
    
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
            
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (tags != null) localVarQueryParams.Add("tags", Configuration.ApiClient.ParameterToString(tags)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDeviceTypes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDeviceTypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceTypesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceTypesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceTypesEnvelope)));
            
        }

        
        /// <summary>
        /// Get Device Types Retrieves Device Types
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Device Type name</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="tags">Elements tagged with the list of tags. (comma separated) (optional)</param>
        /// <returns>Task of DeviceTypesEnvelope</returns>
        public async System.Threading.Tasks.Task<DeviceTypesEnvelope> GetDeviceTypesAsync (string name, int? offset = null, int? count = null, string tags = null)
        {
             ApiResponse<DeviceTypesEnvelope> localVarResponse = await GetDeviceTypesAsyncWithHttpInfo(name, offset, count, tags);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Device Types Retrieves Device Types
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Device Type name</param>
        /// <param name="offset">Offset for pagination. (optional)</param>
        /// <param name="count">Desired count of items in the result set (optional)</param>
        /// <param name="tags">Elements tagged with the list of tags. (comma separated) (optional)</param>
        /// <returns>Task of ApiResponse (DeviceTypesEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceTypesEnvelope>> GetDeviceTypesAsyncWithHttpInfo (string name, int? offset = null, int? count = null, string tags = null)
        {
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling GetDeviceTypes");
            
    
            var localVarPath = "/devicetypes";
    
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
            
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (tags != null) localVarQueryParams.Add("tags", Configuration.ApiClient.ParameterToString(tags)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDeviceTypes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDeviceTypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceTypesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceTypesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceTypesEnvelope)));
            
        }
        
        /// <summary>
        /// Get Latest Manifest Properties Get a Device Type&#39;s manifest properties for the latest version.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param> 
        /// <returns>ManifestPropertiesEnvelope</returns>
        public ManifestPropertiesEnvelope GetLatestManifestProperties (string deviceTypeId)
        {
             ApiResponse<ManifestPropertiesEnvelope> localVarResponse = GetLatestManifestPropertiesWithHttpInfo(deviceTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Latest Manifest Properties Get a Device Type&#39;s manifest properties for the latest version.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param> 
        /// <returns>ApiResponse of ManifestPropertiesEnvelope</returns>
        public ApiResponse< ManifestPropertiesEnvelope > GetLatestManifestPropertiesWithHttpInfo (string deviceTypeId)
        {
            
            // verify the required parameter 'deviceTypeId' is set
            if (deviceTypeId == null)
                throw new ApiException(400, "Missing required parameter 'deviceTypeId' when calling DeviceTypesApi->GetLatestManifestProperties");
            
    
            var localVarPath = "/devicetypes/{deviceTypeId}/manifests/latest/properties";
    
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
            if (deviceTypeId != null) localVarPathParams.Add("deviceTypeId", Configuration.ApiClient.ParameterToString(deviceTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetLatestManifestProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLatestManifestProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ManifestPropertiesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManifestPropertiesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManifestPropertiesEnvelope)));
            
        }

        
        /// <summary>
        /// Get Latest Manifest Properties Get a Device Type&#39;s manifest properties for the latest version.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param>
        /// <returns>Task of ManifestPropertiesEnvelope</returns>
        public async System.Threading.Tasks.Task<ManifestPropertiesEnvelope> GetLatestManifestPropertiesAsync (string deviceTypeId)
        {
             ApiResponse<ManifestPropertiesEnvelope> localVarResponse = await GetLatestManifestPropertiesAsyncWithHttpInfo(deviceTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Latest Manifest Properties Get a Device Type&#39;s manifest properties for the latest version.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param>
        /// <returns>Task of ApiResponse (ManifestPropertiesEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManifestPropertiesEnvelope>> GetLatestManifestPropertiesAsyncWithHttpInfo (string deviceTypeId)
        {
            // verify the required parameter 'deviceTypeId' is set
            if (deviceTypeId == null) throw new ApiException(400, "Missing required parameter 'deviceTypeId' when calling GetLatestManifestProperties");
            
    
            var localVarPath = "/devicetypes/{deviceTypeId}/manifests/latest/properties";
    
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
            if (deviceTypeId != null) localVarPathParams.Add("deviceTypeId", Configuration.ApiClient.ParameterToString(deviceTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetLatestManifestProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLatestManifestProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManifestPropertiesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManifestPropertiesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManifestPropertiesEnvelope)));
            
        }
        
        /// <summary>
        /// Get manifest properties Get a Device Type&#39;s manifest properties for a specific version.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param> 
        /// <param name="version">Manifest Version.</param> 
        /// <returns>ManifestPropertiesEnvelope</returns>
        public ManifestPropertiesEnvelope GetManifestProperties (string deviceTypeId, string version)
        {
             ApiResponse<ManifestPropertiesEnvelope> localVarResponse = GetManifestPropertiesWithHttpInfo(deviceTypeId, version);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get manifest properties Get a Device Type&#39;s manifest properties for a specific version.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param> 
        /// <param name="version">Manifest Version.</param> 
        /// <returns>ApiResponse of ManifestPropertiesEnvelope</returns>
        public ApiResponse< ManifestPropertiesEnvelope > GetManifestPropertiesWithHttpInfo (string deviceTypeId, string version)
        {
            
            // verify the required parameter 'deviceTypeId' is set
            if (deviceTypeId == null)
                throw new ApiException(400, "Missing required parameter 'deviceTypeId' when calling DeviceTypesApi->GetManifestProperties");
            
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling DeviceTypesApi->GetManifestProperties");
            
    
            var localVarPath = "/devicetypes/{deviceTypeId}/manifests/{version}/properties";
    
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
            if (deviceTypeId != null) localVarPathParams.Add("deviceTypeId", Configuration.ApiClient.ParameterToString(deviceTypeId)); // path parameter
            if (version != null) localVarPathParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetManifestProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetManifestProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ManifestPropertiesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManifestPropertiesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManifestPropertiesEnvelope)));
            
        }

        
        /// <summary>
        /// Get manifest properties Get a Device Type&#39;s manifest properties for a specific version.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param>
        /// <param name="version">Manifest Version.</param>
        /// <returns>Task of ManifestPropertiesEnvelope</returns>
        public async System.Threading.Tasks.Task<ManifestPropertiesEnvelope> GetManifestPropertiesAsync (string deviceTypeId, string version)
        {
             ApiResponse<ManifestPropertiesEnvelope> localVarResponse = await GetManifestPropertiesAsyncWithHttpInfo(deviceTypeId, version);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get manifest properties Get a Device Type&#39;s manifest properties for a specific version.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceTypeId">Device Type ID.</param>
        /// <param name="version">Manifest Version.</param>
        /// <returns>Task of ApiResponse (ManifestPropertiesEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManifestPropertiesEnvelope>> GetManifestPropertiesAsyncWithHttpInfo (string deviceTypeId, string version)
        {
            // verify the required parameter 'deviceTypeId' is set
            if (deviceTypeId == null) throw new ApiException(400, "Missing required parameter 'deviceTypeId' when calling GetManifestProperties");
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling GetManifestProperties");
            
    
            var localVarPath = "/devicetypes/{deviceTypeId}/manifests/{version}/properties";
    
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
            if (deviceTypeId != null) localVarPathParams.Add("deviceTypeId", Configuration.ApiClient.ParameterToString(deviceTypeId)); // path parameter
            if (version != null) localVarPathParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetManifestProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetManifestProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManifestPropertiesEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManifestPropertiesEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManifestPropertiesEnvelope)));
            
        }
        
    }
    
}
