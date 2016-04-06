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
    public interface IDevicesApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add Device
        /// </summary>
        /// <remarks>
        /// Create a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="device">Device to be added to the user</param>
        /// <returns>DeviceEnvelope</returns>
        DeviceEnvelope AddDevice (Device device);
  
        /// <summary>
        /// Add Device
        /// </summary>
        /// <remarks>
        /// Create a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="device">Device to be added to the user</param>
        /// <returns>ApiResponse of DeviceEnvelope</returns>
        ApiResponse<DeviceEnvelope> AddDeviceWithHttpInfo (Device device);
        
        /// <summary>
        /// Delete Device
        /// </summary>
        /// <remarks>
        /// Deletes a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>DeviceEnvelope</returns>
        DeviceEnvelope DeleteDevice (string deviceId);
  
        /// <summary>
        /// Delete Device
        /// </summary>
        /// <remarks>
        /// Deletes a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>ApiResponse of DeviceEnvelope</returns>
        ApiResponse<DeviceEnvelope> DeleteDeviceWithHttpInfo (string deviceId);
        
        /// <summary>
        /// Delete Device Token
        /// </summary>
        /// <remarks>
        /// Deletes a device&#39;s token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>DeviceTokenEnvelope</returns>
        DeviceTokenEnvelope DeleteDeviceToken (string deviceId);
  
        /// <summary>
        /// Delete Device Token
        /// </summary>
        /// <remarks>
        /// Deletes a device&#39;s token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>ApiResponse of DeviceTokenEnvelope</returns>
        ApiResponse<DeviceTokenEnvelope> DeleteDeviceTokenWithHttpInfo (string deviceId);
        
        /// <summary>
        /// Get Device
        /// </summary>
        /// <remarks>
        /// Retrieves a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>DeviceEnvelope</returns>
        DeviceEnvelope GetDevice (string deviceId);
  
        /// <summary>
        /// Get Device
        /// </summary>
        /// <remarks>
        /// Retrieves a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>ApiResponse of DeviceEnvelope</returns>
        ApiResponse<DeviceEnvelope> GetDeviceWithHttpInfo (string deviceId);
        
        /// <summary>
        /// Get Device Token
        /// </summary>
        /// <remarks>
        /// Retrieves a device&#39;s token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>DeviceTokenEnvelope</returns>
        DeviceTokenEnvelope GetDeviceToken (string deviceId);
  
        /// <summary>
        /// Get Device Token
        /// </summary>
        /// <remarks>
        /// Retrieves a device&#39;s token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>ApiResponse of DeviceTokenEnvelope</returns>
        ApiResponse<DeviceTokenEnvelope> GetDeviceTokenWithHttpInfo (string deviceId);
        
        /// <summary>
        /// Update Device
        /// </summary>
        /// <remarks>
        /// Updates a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <param name="device">Device to be updated</param>
        /// <returns>DeviceEnvelope</returns>
        DeviceEnvelope UpdateDevice (string deviceId, Device device);
  
        /// <summary>
        /// Update Device
        /// </summary>
        /// <remarks>
        /// Updates a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <param name="device">Device to be updated</param>
        /// <returns>ApiResponse of DeviceEnvelope</returns>
        ApiResponse<DeviceEnvelope> UpdateDeviceWithHttpInfo (string deviceId, Device device);
        
        /// <summary>
        /// Update Device Token
        /// </summary>
        /// <remarks>
        /// Updates a device&#39;s token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>DeviceTokenEnvelope</returns>
        DeviceTokenEnvelope UpdateDeviceToken (string deviceId);
  
        /// <summary>
        /// Update Device Token
        /// </summary>
        /// <remarks>
        /// Updates a device&#39;s token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>ApiResponse of DeviceTokenEnvelope</returns>
        ApiResponse<DeviceTokenEnvelope> UpdateDeviceTokenWithHttpInfo (string deviceId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add Device
        /// </summary>
        /// <remarks>
        /// Create a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="device">Device to be added to the user</param>
        /// <returns>Task of DeviceEnvelope</returns>
        System.Threading.Tasks.Task<DeviceEnvelope> AddDeviceAsync (Device device);

        /// <summary>
        /// Add Device
        /// </summary>
        /// <remarks>
        /// Create a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="device">Device to be added to the user</param>
        /// <returns>Task of ApiResponse (DeviceEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceEnvelope>> AddDeviceAsyncWithHttpInfo (Device device);
        
        /// <summary>
        /// Delete Device
        /// </summary>
        /// <remarks>
        /// Deletes a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of DeviceEnvelope</returns>
        System.Threading.Tasks.Task<DeviceEnvelope> DeleteDeviceAsync (string deviceId);

        /// <summary>
        /// Delete Device
        /// </summary>
        /// <remarks>
        /// Deletes a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of ApiResponse (DeviceEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceEnvelope>> DeleteDeviceAsyncWithHttpInfo (string deviceId);
        
        /// <summary>
        /// Delete Device Token
        /// </summary>
        /// <remarks>
        /// Deletes a device&#39;s token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of DeviceTokenEnvelope</returns>
        System.Threading.Tasks.Task<DeviceTokenEnvelope> DeleteDeviceTokenAsync (string deviceId);

        /// <summary>
        /// Delete Device Token
        /// </summary>
        /// <remarks>
        /// Deletes a device&#39;s token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of ApiResponse (DeviceTokenEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceTokenEnvelope>> DeleteDeviceTokenAsyncWithHttpInfo (string deviceId);
        
        /// <summary>
        /// Get Device
        /// </summary>
        /// <remarks>
        /// Retrieves a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of DeviceEnvelope</returns>
        System.Threading.Tasks.Task<DeviceEnvelope> GetDeviceAsync (string deviceId);

        /// <summary>
        /// Get Device
        /// </summary>
        /// <remarks>
        /// Retrieves a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of ApiResponse (DeviceEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceEnvelope>> GetDeviceAsyncWithHttpInfo (string deviceId);
        
        /// <summary>
        /// Get Device Token
        /// </summary>
        /// <remarks>
        /// Retrieves a device&#39;s token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of DeviceTokenEnvelope</returns>
        System.Threading.Tasks.Task<DeviceTokenEnvelope> GetDeviceTokenAsync (string deviceId);

        /// <summary>
        /// Get Device Token
        /// </summary>
        /// <remarks>
        /// Retrieves a device&#39;s token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of ApiResponse (DeviceTokenEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceTokenEnvelope>> GetDeviceTokenAsyncWithHttpInfo (string deviceId);
        
        /// <summary>
        /// Update Device
        /// </summary>
        /// <remarks>
        /// Updates a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <param name="device">Device to be updated</param>
        /// <returns>Task of DeviceEnvelope</returns>
        System.Threading.Tasks.Task<DeviceEnvelope> UpdateDeviceAsync (string deviceId, Device device);

        /// <summary>
        /// Update Device
        /// </summary>
        /// <remarks>
        /// Updates a device
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <param name="device">Device to be updated</param>
        /// <returns>Task of ApiResponse (DeviceEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceEnvelope>> UpdateDeviceAsyncWithHttpInfo (string deviceId, Device device);
        
        /// <summary>
        /// Update Device Token
        /// </summary>
        /// <remarks>
        /// Updates a device&#39;s token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of DeviceTokenEnvelope</returns>
        System.Threading.Tasks.Task<DeviceTokenEnvelope> UpdateDeviceTokenAsync (string deviceId);

        /// <summary>
        /// Update Device Token
        /// </summary>
        /// <remarks>
        /// Updates a device&#39;s token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of ApiResponse (DeviceTokenEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceTokenEnvelope>> UpdateDeviceTokenAsyncWithHttpInfo (string deviceId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DevicesApi : IDevicesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DevicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DevicesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DevicesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DevicesApi(Configuration configuration = null)
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
        /// Add Device Create a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="device">Device to be added to the user</param> 
        /// <returns>DeviceEnvelope</returns>
        public DeviceEnvelope AddDevice (Device device)
        {
             ApiResponse<DeviceEnvelope> localVarResponse = AddDeviceWithHttpInfo(device);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add Device Create a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="device">Device to be added to the user</param> 
        /// <returns>ApiResponse of DeviceEnvelope</returns>
        public ApiResponse< DeviceEnvelope > AddDeviceWithHttpInfo (Device device)
        {
            
            // verify the required parameter 'device' is set
            if (device == null)
                throw new ApiException(400, "Missing required parameter 'device' when calling DevicesApi->AddDevice");
            
    
            var localVarPath = "/devices";
    
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
            
            
            
            
            if (device.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(device); // http body (model) parameter
            }
            else
            {
                localVarPostBody = device; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling AddDevice: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddDevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceEnvelope)));
            
        }

        
        /// <summary>
        /// Add Device Create a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="device">Device to be added to the user</param>
        /// <returns>Task of DeviceEnvelope</returns>
        public async System.Threading.Tasks.Task<DeviceEnvelope> AddDeviceAsync (Device device)
        {
             ApiResponse<DeviceEnvelope> localVarResponse = await AddDeviceAsyncWithHttpInfo(device);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add Device Create a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="device">Device to be added to the user</param>
        /// <returns>Task of ApiResponse (DeviceEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceEnvelope>> AddDeviceAsyncWithHttpInfo (Device device)
        {
            // verify the required parameter 'device' is set
            if (device == null) throw new ApiException(400, "Missing required parameter 'device' when calling AddDevice");
            
    
            var localVarPath = "/devices";
    
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
            
            
            
            
            if (device.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(device); // http body (model) parameter
            }
            else
            {
                localVarPostBody = device; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling AddDevice: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddDevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceEnvelope)));
            
        }
        
        /// <summary>
        /// Delete Device Deletes a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param> 
        /// <returns>DeviceEnvelope</returns>
        public DeviceEnvelope DeleteDevice (string deviceId)
        {
             ApiResponse<DeviceEnvelope> localVarResponse = DeleteDeviceWithHttpInfo(deviceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Device Deletes a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param> 
        /// <returns>ApiResponse of DeviceEnvelope</returns>
        public ApiResponse< DeviceEnvelope > DeleteDeviceWithHttpInfo (string deviceId)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling DevicesApi->DeleteDevice");
            
    
            var localVarPath = "/devices/{deviceId}";
    
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
            if (deviceId != null) localVarPathParams.Add("deviceId", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteDevice: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceEnvelope)));
            
        }

        
        /// <summary>
        /// Delete Device Deletes a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of DeviceEnvelope</returns>
        public async System.Threading.Tasks.Task<DeviceEnvelope> DeleteDeviceAsync (string deviceId)
        {
             ApiResponse<DeviceEnvelope> localVarResponse = await DeleteDeviceAsyncWithHttpInfo(deviceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete Device Deletes a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of ApiResponse (DeviceEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceEnvelope>> DeleteDeviceAsyncWithHttpInfo (string deviceId)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling DeleteDevice");
            
    
            var localVarPath = "/devices/{deviceId}";
    
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
            if (deviceId != null) localVarPathParams.Add("deviceId", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteDevice: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceEnvelope)));
            
        }
        
        /// <summary>
        /// Delete Device Token Deletes a device&#39;s token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param> 
        /// <returns>DeviceTokenEnvelope</returns>
        public DeviceTokenEnvelope DeleteDeviceToken (string deviceId)
        {
             ApiResponse<DeviceTokenEnvelope> localVarResponse = DeleteDeviceTokenWithHttpInfo(deviceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Device Token Deletes a device&#39;s token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param> 
        /// <returns>ApiResponse of DeviceTokenEnvelope</returns>
        public ApiResponse< DeviceTokenEnvelope > DeleteDeviceTokenWithHttpInfo (string deviceId)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling DevicesApi->DeleteDeviceToken");
            
    
            var localVarPath = "/devices/{deviceId}/tokens";
    
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
            if (deviceId != null) localVarPathParams.Add("deviceId", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteDeviceToken: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDeviceToken: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceTokenEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceTokenEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceTokenEnvelope)));
            
        }

        
        /// <summary>
        /// Delete Device Token Deletes a device&#39;s token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of DeviceTokenEnvelope</returns>
        public async System.Threading.Tasks.Task<DeviceTokenEnvelope> DeleteDeviceTokenAsync (string deviceId)
        {
             ApiResponse<DeviceTokenEnvelope> localVarResponse = await DeleteDeviceTokenAsyncWithHttpInfo(deviceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete Device Token Deletes a device&#39;s token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of ApiResponse (DeviceTokenEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceTokenEnvelope>> DeleteDeviceTokenAsyncWithHttpInfo (string deviceId)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling DeleteDeviceToken");
            
    
            var localVarPath = "/devices/{deviceId}/tokens";
    
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
            if (deviceId != null) localVarPathParams.Add("deviceId", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteDeviceToken: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDeviceToken: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceTokenEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceTokenEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceTokenEnvelope)));
            
        }
        
        /// <summary>
        /// Get Device Retrieves a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param> 
        /// <returns>DeviceEnvelope</returns>
        public DeviceEnvelope GetDevice (string deviceId)
        {
             ApiResponse<DeviceEnvelope> localVarResponse = GetDeviceWithHttpInfo(deviceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Device Retrieves a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param> 
        /// <returns>ApiResponse of DeviceEnvelope</returns>
        public ApiResponse< DeviceEnvelope > GetDeviceWithHttpInfo (string deviceId)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling DevicesApi->GetDevice");
            
    
            var localVarPath = "/devices/{deviceId}";
    
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
            if (deviceId != null) localVarPathParams.Add("deviceId", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDevice: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceEnvelope)));
            
        }

        
        /// <summary>
        /// Get Device Retrieves a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of DeviceEnvelope</returns>
        public async System.Threading.Tasks.Task<DeviceEnvelope> GetDeviceAsync (string deviceId)
        {
             ApiResponse<DeviceEnvelope> localVarResponse = await GetDeviceAsyncWithHttpInfo(deviceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Device Retrieves a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of ApiResponse (DeviceEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceEnvelope>> GetDeviceAsyncWithHttpInfo (string deviceId)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling GetDevice");
            
    
            var localVarPath = "/devices/{deviceId}";
    
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
            if (deviceId != null) localVarPathParams.Add("deviceId", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDevice: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceEnvelope)));
            
        }
        
        /// <summary>
        /// Get Device Token Retrieves a device&#39;s token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param> 
        /// <returns>DeviceTokenEnvelope</returns>
        public DeviceTokenEnvelope GetDeviceToken (string deviceId)
        {
             ApiResponse<DeviceTokenEnvelope> localVarResponse = GetDeviceTokenWithHttpInfo(deviceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Device Token Retrieves a device&#39;s token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param> 
        /// <returns>ApiResponse of DeviceTokenEnvelope</returns>
        public ApiResponse< DeviceTokenEnvelope > GetDeviceTokenWithHttpInfo (string deviceId)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling DevicesApi->GetDeviceToken");
            
    
            var localVarPath = "/devices/{deviceId}/tokens";
    
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
            if (deviceId != null) localVarPathParams.Add("deviceId", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDeviceToken: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDeviceToken: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceTokenEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceTokenEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceTokenEnvelope)));
            
        }

        
        /// <summary>
        /// Get Device Token Retrieves a device&#39;s token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of DeviceTokenEnvelope</returns>
        public async System.Threading.Tasks.Task<DeviceTokenEnvelope> GetDeviceTokenAsync (string deviceId)
        {
             ApiResponse<DeviceTokenEnvelope> localVarResponse = await GetDeviceTokenAsyncWithHttpInfo(deviceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Device Token Retrieves a device&#39;s token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of ApiResponse (DeviceTokenEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceTokenEnvelope>> GetDeviceTokenAsyncWithHttpInfo (string deviceId)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling GetDeviceToken");
            
    
            var localVarPath = "/devices/{deviceId}/tokens";
    
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
            if (deviceId != null) localVarPathParams.Add("deviceId", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDeviceToken: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDeviceToken: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceTokenEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceTokenEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceTokenEnvelope)));
            
        }
        
        /// <summary>
        /// Update Device Updates a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param> 
        /// <param name="device">Device to be updated</param> 
        /// <returns>DeviceEnvelope</returns>
        public DeviceEnvelope UpdateDevice (string deviceId, Device device)
        {
             ApiResponse<DeviceEnvelope> localVarResponse = UpdateDeviceWithHttpInfo(deviceId, device);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Device Updates a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param> 
        /// <param name="device">Device to be updated</param> 
        /// <returns>ApiResponse of DeviceEnvelope</returns>
        public ApiResponse< DeviceEnvelope > UpdateDeviceWithHttpInfo (string deviceId, Device device)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling DevicesApi->UpdateDevice");
            
            // verify the required parameter 'device' is set
            if (device == null)
                throw new ApiException(400, "Missing required parameter 'device' when calling DevicesApi->UpdateDevice");
            
    
            var localVarPath = "/devices/{deviceId}";
    
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
            if (deviceId != null) localVarPathParams.Add("deviceId", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            if (device.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(device); // http body (model) parameter
            }
            else
            {
                localVarPostBody = device; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateDevice: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateDevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceEnvelope)));
            
        }

        
        /// <summary>
        /// Update Device Updates a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <param name="device">Device to be updated</param>
        /// <returns>Task of DeviceEnvelope</returns>
        public async System.Threading.Tasks.Task<DeviceEnvelope> UpdateDeviceAsync (string deviceId, Device device)
        {
             ApiResponse<DeviceEnvelope> localVarResponse = await UpdateDeviceAsyncWithHttpInfo(deviceId, device);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Device Updates a device
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <param name="device">Device to be updated</param>
        /// <returns>Task of ApiResponse (DeviceEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceEnvelope>> UpdateDeviceAsyncWithHttpInfo (string deviceId, Device device)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling UpdateDevice");
            // verify the required parameter 'device' is set
            if (device == null) throw new ApiException(400, "Missing required parameter 'device' when calling UpdateDevice");
            
    
            var localVarPath = "/devices/{deviceId}";
    
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
            if (deviceId != null) localVarPathParams.Add("deviceId", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            if (device.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(device); // http body (model) parameter
            }
            else
            {
                localVarPostBody = device; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateDevice: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateDevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceEnvelope)));
            
        }
        
        /// <summary>
        /// Update Device Token Updates a device&#39;s token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param> 
        /// <returns>DeviceTokenEnvelope</returns>
        public DeviceTokenEnvelope UpdateDeviceToken (string deviceId)
        {
             ApiResponse<DeviceTokenEnvelope> localVarResponse = UpdateDeviceTokenWithHttpInfo(deviceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Device Token Updates a device&#39;s token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param> 
        /// <returns>ApiResponse of DeviceTokenEnvelope</returns>
        public ApiResponse< DeviceTokenEnvelope > UpdateDeviceTokenWithHttpInfo (string deviceId)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling DevicesApi->UpdateDeviceToken");
            
    
            var localVarPath = "/devices/{deviceId}/tokens";
    
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
            if (deviceId != null) localVarPathParams.Add("deviceId", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling UpdateDeviceToken: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateDeviceToken: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceTokenEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceTokenEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceTokenEnvelope)));
            
        }

        
        /// <summary>
        /// Update Device Token Updates a device&#39;s token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of DeviceTokenEnvelope</returns>
        public async System.Threading.Tasks.Task<DeviceTokenEnvelope> UpdateDeviceTokenAsync (string deviceId)
        {
             ApiResponse<DeviceTokenEnvelope> localVarResponse = await UpdateDeviceTokenAsyncWithHttpInfo(deviceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Device Token Updates a device&#39;s token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">deviceId</param>
        /// <returns>Task of ApiResponse (DeviceTokenEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceTokenEnvelope>> UpdateDeviceTokenAsyncWithHttpInfo (string deviceId)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling UpdateDeviceToken");
            
    
            var localVarPath = "/devices/{deviceId}/tokens";
    
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
            if (deviceId != null) localVarPathParams.Add("deviceId", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateDeviceToken: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateDeviceToken: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceTokenEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceTokenEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceTokenEnvelope)));
            
        }
        
    }
    
}
