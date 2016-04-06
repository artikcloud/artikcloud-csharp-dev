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
    public interface IRegistrationsApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Confirm User
        /// </summary>
        /// <remarks>
        /// This call updates the registration request issued earlier by associating it with an authenticated user and captures all additional information required to add a new device.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationInfo">Device Registration information.</param>
        /// <returns>DeviceRegConfirmUserResponseEnvelope</returns>
        DeviceRegConfirmUserResponseEnvelope ConfirmUser (DeviceRegConfirmUserRequest registrationInfo);
  
        /// <summary>
        /// Confirm User
        /// </summary>
        /// <remarks>
        /// This call updates the registration request issued earlier by associating it with an authenticated user and captures all additional information required to add a new device.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationInfo">Device Registration information.</param>
        /// <returns>ApiResponse of DeviceRegConfirmUserResponseEnvelope</returns>
        ApiResponse<DeviceRegConfirmUserResponseEnvelope> ConfirmUserWithHttpInfo (DeviceRegConfirmUserRequest registrationInfo);
        
        /// <summary>
        /// Get Request Status For User
        /// </summary>
        /// <remarks>
        /// This call checks the status of the request so users can poll and know when registration is complete.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID.</param>
        /// <returns>DeviceRegStatusResponseEnvelope</returns>
        DeviceRegStatusResponseEnvelope GetRequestStatusForUser (string requestId);
  
        /// <summary>
        /// Get Request Status For User
        /// </summary>
        /// <remarks>
        /// This call checks the status of the request so users can poll and know when registration is complete.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID.</param>
        /// <returns>ApiResponse of DeviceRegStatusResponseEnvelope</returns>
        ApiResponse<DeviceRegStatusResponseEnvelope> GetRequestStatusForUserWithHttpInfo (string requestId);
        
        /// <summary>
        /// Unregister Device
        /// </summary>
        /// <remarks>
        /// This call clears any associations from the secure device registration.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID.</param>
        /// <returns>UnregisterDeviceResponseEnvelope</returns>
        UnregisterDeviceResponseEnvelope UnregisterDevice (string deviceId);
  
        /// <summary>
        /// Unregister Device
        /// </summary>
        /// <remarks>
        /// This call clears any associations from the secure device registration.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID.</param>
        /// <returns>ApiResponse of UnregisterDeviceResponseEnvelope</returns>
        ApiResponse<UnregisterDeviceResponseEnvelope> UnregisterDeviceWithHttpInfo (string deviceId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Confirm User
        /// </summary>
        /// <remarks>
        /// This call updates the registration request issued earlier by associating it with an authenticated user and captures all additional information required to add a new device.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationInfo">Device Registration information.</param>
        /// <returns>Task of DeviceRegConfirmUserResponseEnvelope</returns>
        System.Threading.Tasks.Task<DeviceRegConfirmUserResponseEnvelope> ConfirmUserAsync (DeviceRegConfirmUserRequest registrationInfo);

        /// <summary>
        /// Confirm User
        /// </summary>
        /// <remarks>
        /// This call updates the registration request issued earlier by associating it with an authenticated user and captures all additional information required to add a new device.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationInfo">Device Registration information.</param>
        /// <returns>Task of ApiResponse (DeviceRegConfirmUserResponseEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceRegConfirmUserResponseEnvelope>> ConfirmUserAsyncWithHttpInfo (DeviceRegConfirmUserRequest registrationInfo);
        
        /// <summary>
        /// Get Request Status For User
        /// </summary>
        /// <remarks>
        /// This call checks the status of the request so users can poll and know when registration is complete.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID.</param>
        /// <returns>Task of DeviceRegStatusResponseEnvelope</returns>
        System.Threading.Tasks.Task<DeviceRegStatusResponseEnvelope> GetRequestStatusForUserAsync (string requestId);

        /// <summary>
        /// Get Request Status For User
        /// </summary>
        /// <remarks>
        /// This call checks the status of the request so users can poll and know when registration is complete.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID.</param>
        /// <returns>Task of ApiResponse (DeviceRegStatusResponseEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceRegStatusResponseEnvelope>> GetRequestStatusForUserAsyncWithHttpInfo (string requestId);
        
        /// <summary>
        /// Unregister Device
        /// </summary>
        /// <remarks>
        /// This call clears any associations from the secure device registration.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID.</param>
        /// <returns>Task of UnregisterDeviceResponseEnvelope</returns>
        System.Threading.Tasks.Task<UnregisterDeviceResponseEnvelope> UnregisterDeviceAsync (string deviceId);

        /// <summary>
        /// Unregister Device
        /// </summary>
        /// <remarks>
        /// This call clears any associations from the secure device registration.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID.</param>
        /// <returns>Task of ApiResponse (UnregisterDeviceResponseEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<UnregisterDeviceResponseEnvelope>> UnregisterDeviceAsyncWithHttpInfo (string deviceId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RegistrationsApi : IRegistrationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RegistrationsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RegistrationsApi(Configuration configuration = null)
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
        /// Confirm User This call updates the registration request issued earlier by associating it with an authenticated user and captures all additional information required to add a new device.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationInfo">Device Registration information.</param> 
        /// <returns>DeviceRegConfirmUserResponseEnvelope</returns>
        public DeviceRegConfirmUserResponseEnvelope ConfirmUser (DeviceRegConfirmUserRequest registrationInfo)
        {
             ApiResponse<DeviceRegConfirmUserResponseEnvelope> localVarResponse = ConfirmUserWithHttpInfo(registrationInfo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Confirm User This call updates the registration request issued earlier by associating it with an authenticated user and captures all additional information required to add a new device.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationInfo">Device Registration information.</param> 
        /// <returns>ApiResponse of DeviceRegConfirmUserResponseEnvelope</returns>
        public ApiResponse< DeviceRegConfirmUserResponseEnvelope > ConfirmUserWithHttpInfo (DeviceRegConfirmUserRequest registrationInfo)
        {
            
            // verify the required parameter 'registrationInfo' is set
            if (registrationInfo == null)
                throw new ApiException(400, "Missing required parameter 'registrationInfo' when calling RegistrationsApi->ConfirmUser");
            
    
            var localVarPath = "/devices/registrations/pin";
    
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
            
            
            
            
            if (registrationInfo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(registrationInfo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = registrationInfo; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling ConfirmUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceRegConfirmUserResponseEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceRegConfirmUserResponseEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceRegConfirmUserResponseEnvelope)));
            
        }

        
        /// <summary>
        /// Confirm User This call updates the registration request issued earlier by associating it with an authenticated user and captures all additional information required to add a new device.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationInfo">Device Registration information.</param>
        /// <returns>Task of DeviceRegConfirmUserResponseEnvelope</returns>
        public async System.Threading.Tasks.Task<DeviceRegConfirmUserResponseEnvelope> ConfirmUserAsync (DeviceRegConfirmUserRequest registrationInfo)
        {
             ApiResponse<DeviceRegConfirmUserResponseEnvelope> localVarResponse = await ConfirmUserAsyncWithHttpInfo(registrationInfo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Confirm User This call updates the registration request issued earlier by associating it with an authenticated user and captures all additional information required to add a new device.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationInfo">Device Registration information.</param>
        /// <returns>Task of ApiResponse (DeviceRegConfirmUserResponseEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceRegConfirmUserResponseEnvelope>> ConfirmUserAsyncWithHttpInfo (DeviceRegConfirmUserRequest registrationInfo)
        {
            // verify the required parameter 'registrationInfo' is set
            if (registrationInfo == null) throw new ApiException(400, "Missing required parameter 'registrationInfo' when calling ConfirmUser");
            
    
            var localVarPath = "/devices/registrations/pin";
    
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
            
            
            
            
            if (registrationInfo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(registrationInfo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = registrationInfo; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling ConfirmUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceRegConfirmUserResponseEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceRegConfirmUserResponseEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceRegConfirmUserResponseEnvelope)));
            
        }
        
        /// <summary>
        /// Get Request Status For User This call checks the status of the request so users can poll and know when registration is complete.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID.</param> 
        /// <returns>DeviceRegStatusResponseEnvelope</returns>
        public DeviceRegStatusResponseEnvelope GetRequestStatusForUser (string requestId)
        {
             ApiResponse<DeviceRegStatusResponseEnvelope> localVarResponse = GetRequestStatusForUserWithHttpInfo(requestId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Request Status For User This call checks the status of the request so users can poll and know when registration is complete.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID.</param> 
        /// <returns>ApiResponse of DeviceRegStatusResponseEnvelope</returns>
        public ApiResponse< DeviceRegStatusResponseEnvelope > GetRequestStatusForUserWithHttpInfo (string requestId)
        {
            
            // verify the required parameter 'requestId' is set
            if (requestId == null)
                throw new ApiException(400, "Missing required parameter 'requestId' when calling RegistrationsApi->GetRequestStatusForUser");
            
    
            var localVarPath = "/devices/registrations/{requestId}/status";
    
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
            if (requestId != null) localVarPathParams.Add("requestId", Configuration.ApiClient.ParameterToString(requestId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetRequestStatusForUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRequestStatusForUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceRegStatusResponseEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceRegStatusResponseEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceRegStatusResponseEnvelope)));
            
        }

        
        /// <summary>
        /// Get Request Status For User This call checks the status of the request so users can poll and know when registration is complete.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID.</param>
        /// <returns>Task of DeviceRegStatusResponseEnvelope</returns>
        public async System.Threading.Tasks.Task<DeviceRegStatusResponseEnvelope> GetRequestStatusForUserAsync (string requestId)
        {
             ApiResponse<DeviceRegStatusResponseEnvelope> localVarResponse = await GetRequestStatusForUserAsyncWithHttpInfo(requestId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Request Status For User This call checks the status of the request so users can poll and know when registration is complete.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Request ID.</param>
        /// <returns>Task of ApiResponse (DeviceRegStatusResponseEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceRegStatusResponseEnvelope>> GetRequestStatusForUserAsyncWithHttpInfo (string requestId)
        {
            // verify the required parameter 'requestId' is set
            if (requestId == null) throw new ApiException(400, "Missing required parameter 'requestId' when calling GetRequestStatusForUser");
            
    
            var localVarPath = "/devices/registrations/{requestId}/status";
    
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
            if (requestId != null) localVarPathParams.Add("requestId", Configuration.ApiClient.ParameterToString(requestId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetRequestStatusForUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRequestStatusForUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceRegStatusResponseEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceRegStatusResponseEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceRegStatusResponseEnvelope)));
            
        }
        
        /// <summary>
        /// Unregister Device This call clears any associations from the secure device registration.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID.</param> 
        /// <returns>UnregisterDeviceResponseEnvelope</returns>
        public UnregisterDeviceResponseEnvelope UnregisterDevice (string deviceId)
        {
             ApiResponse<UnregisterDeviceResponseEnvelope> localVarResponse = UnregisterDeviceWithHttpInfo(deviceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Unregister Device This call clears any associations from the secure device registration.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID.</param> 
        /// <returns>ApiResponse of UnregisterDeviceResponseEnvelope</returns>
        public ApiResponse< UnregisterDeviceResponseEnvelope > UnregisterDeviceWithHttpInfo (string deviceId)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling RegistrationsApi->UnregisterDevice");
            
    
            var localVarPath = "/devices/{deviceId}/registrations";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UnregisterDevice: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UnregisterDevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UnregisterDeviceResponseEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnregisterDeviceResponseEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnregisterDeviceResponseEnvelope)));
            
        }

        
        /// <summary>
        /// Unregister Device This call clears any associations from the secure device registration.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID.</param>
        /// <returns>Task of UnregisterDeviceResponseEnvelope</returns>
        public async System.Threading.Tasks.Task<UnregisterDeviceResponseEnvelope> UnregisterDeviceAsync (string deviceId)
        {
             ApiResponse<UnregisterDeviceResponseEnvelope> localVarResponse = await UnregisterDeviceAsyncWithHttpInfo(deviceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Unregister Device This call clears any associations from the secure device registration.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">Device ID.</param>
        /// <returns>Task of ApiResponse (UnregisterDeviceResponseEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UnregisterDeviceResponseEnvelope>> UnregisterDeviceAsyncWithHttpInfo (string deviceId)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling UnregisterDevice");
            
    
            var localVarPath = "/devices/{deviceId}/registrations";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UnregisterDevice: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UnregisterDevice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnregisterDeviceResponseEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnregisterDeviceResponseEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnregisterDeviceResponseEnvelope)));
            
        }
        
    }
    
}
