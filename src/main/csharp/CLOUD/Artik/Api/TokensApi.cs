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
    public interface ITokensApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Check Token
        /// </summary>
        /// <remarks>
        /// Check Token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenInfo">Token object to be checked</param>
        /// <returns>CheckTokenResponse</returns>
        CheckTokenResponse CheckToken (TokenRequest tokenInfo);
  
        /// <summary>
        /// Check Token
        /// </summary>
        /// <remarks>
        /// Check Token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenInfo">Token object to be checked</param>
        /// <returns>ApiResponse of CheckTokenResponse</returns>
        ApiResponse<CheckTokenResponse> CheckTokenWithHttpInfo (TokenRequest tokenInfo);
        
        /// <summary>
        /// Refresh Token
        /// </summary>
        /// <remarks>
        /// Refresh Token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Grant Type.</param>
        /// <param name="refreshToken">Refresh Token.</param>
        /// <returns>RefreshTokenResponse</returns>
        RefreshTokenResponse RefreshToken (string grantType, string refreshToken);
  
        /// <summary>
        /// Refresh Token
        /// </summary>
        /// <remarks>
        /// Refresh Token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Grant Type.</param>
        /// <param name="refreshToken">Refresh Token.</param>
        /// <returns>ApiResponse of RefreshTokenResponse</returns>
        ApiResponse<RefreshTokenResponse> RefreshTokenWithHttpInfo (string grantType, string refreshToken);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Check Token
        /// </summary>
        /// <remarks>
        /// Check Token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenInfo">Token object to be checked</param>
        /// <returns>Task of CheckTokenResponse</returns>
        System.Threading.Tasks.Task<CheckTokenResponse> CheckTokenAsync (TokenRequest tokenInfo);

        /// <summary>
        /// Check Token
        /// </summary>
        /// <remarks>
        /// Check Token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenInfo">Token object to be checked</param>
        /// <returns>Task of ApiResponse (CheckTokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CheckTokenResponse>> CheckTokenAsyncWithHttpInfo (TokenRequest tokenInfo);
        
        /// <summary>
        /// Refresh Token
        /// </summary>
        /// <remarks>
        /// Refresh Token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Grant Type.</param>
        /// <param name="refreshToken">Refresh Token.</param>
        /// <returns>Task of RefreshTokenResponse</returns>
        System.Threading.Tasks.Task<RefreshTokenResponse> RefreshTokenAsync (string grantType, string refreshToken);

        /// <summary>
        /// Refresh Token
        /// </summary>
        /// <remarks>
        /// Refresh Token
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Grant Type.</param>
        /// <param name="refreshToken">Refresh Token.</param>
        /// <returns>Task of ApiResponse (RefreshTokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RefreshTokenResponse>> RefreshTokenAsyncWithHttpInfo (string grantType, string refreshToken);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TokensApi : ITokensApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokensApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TokensApi(Configuration configuration = null)
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
        /// Check Token Check Token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenInfo">Token object to be checked</param> 
        /// <returns>CheckTokenResponse</returns>
        public CheckTokenResponse CheckToken (TokenRequest tokenInfo)
        {
             ApiResponse<CheckTokenResponse> localVarResponse = CheckTokenWithHttpInfo(tokenInfo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Check Token Check Token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenInfo">Token object to be checked</param> 
        /// <returns>ApiResponse of CheckTokenResponse</returns>
        public ApiResponse< CheckTokenResponse > CheckTokenWithHttpInfo (TokenRequest tokenInfo)
        {
            
            // verify the required parameter 'tokenInfo' is set
            if (tokenInfo == null)
                throw new ApiException(400, "Missing required parameter 'tokenInfo' when calling TokensApi->CheckToken");
            
    
            var localVarPath = "/checkToken";
    
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
            
            
            
            
            if (tokenInfo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tokenInfo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tokenInfo; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling CheckToken: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CheckToken: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CheckTokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CheckTokenResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CheckTokenResponse)));
            
        }

        
        /// <summary>
        /// Check Token Check Token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenInfo">Token object to be checked</param>
        /// <returns>Task of CheckTokenResponse</returns>
        public async System.Threading.Tasks.Task<CheckTokenResponse> CheckTokenAsync (TokenRequest tokenInfo)
        {
             ApiResponse<CheckTokenResponse> localVarResponse = await CheckTokenAsyncWithHttpInfo(tokenInfo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Check Token Check Token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenInfo">Token object to be checked</param>
        /// <returns>Task of ApiResponse (CheckTokenResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CheckTokenResponse>> CheckTokenAsyncWithHttpInfo (TokenRequest tokenInfo)
        {
            // verify the required parameter 'tokenInfo' is set
            if (tokenInfo == null) throw new ApiException(400, "Missing required parameter 'tokenInfo' when calling CheckToken");
            
    
            var localVarPath = "/checkToken";
    
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
            
            
            
            
            if (tokenInfo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tokenInfo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tokenInfo; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling CheckToken: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CheckToken: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CheckTokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CheckTokenResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CheckTokenResponse)));
            
        }
        
        /// <summary>
        /// Refresh Token Refresh Token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Grant Type.</param> 
        /// <param name="refreshToken">Refresh Token.</param> 
        /// <returns>RefreshTokenResponse</returns>
        public RefreshTokenResponse RefreshToken (string grantType, string refreshToken)
        {
             ApiResponse<RefreshTokenResponse> localVarResponse = RefreshTokenWithHttpInfo(grantType, refreshToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Refresh Token Refresh Token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Grant Type.</param> 
        /// <param name="refreshToken">Refresh Token.</param> 
        /// <returns>ApiResponse of RefreshTokenResponse</returns>
        public ApiResponse< RefreshTokenResponse > RefreshTokenWithHttpInfo (string grantType, string refreshToken)
        {
            
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new ApiException(400, "Missing required parameter 'grantType' when calling TokensApi->RefreshToken");
            
            // verify the required parameter 'refreshToken' is set
            if (refreshToken == null)
                throw new ApiException(400, "Missing required parameter 'refreshToken' when calling TokensApi->RefreshToken");
            
    
            var localVarPath = "/token";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
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
            
            
            
            if (grantType != null) localVarFormParams.Add("grant_type", Configuration.ApiClient.ParameterToString(grantType)); // form parameter
            if (refreshToken != null) localVarFormParams.Add("refresh_token", Configuration.ApiClient.ParameterToString(refreshToken)); // form parameter
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling RefreshToken: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RefreshToken: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RefreshTokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RefreshTokenResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RefreshTokenResponse)));
            
        }

        
        /// <summary>
        /// Refresh Token Refresh Token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Grant Type.</param>
        /// <param name="refreshToken">Refresh Token.</param>
        /// <returns>Task of RefreshTokenResponse</returns>
        public async System.Threading.Tasks.Task<RefreshTokenResponse> RefreshTokenAsync (string grantType, string refreshToken)
        {
             ApiResponse<RefreshTokenResponse> localVarResponse = await RefreshTokenAsyncWithHttpInfo(grantType, refreshToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Refresh Token Refresh Token
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Grant Type.</param>
        /// <param name="refreshToken">Refresh Token.</param>
        /// <returns>Task of ApiResponse (RefreshTokenResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RefreshTokenResponse>> RefreshTokenAsyncWithHttpInfo (string grantType, string refreshToken)
        {
            // verify the required parameter 'grantType' is set
            if (grantType == null) throw new ApiException(400, "Missing required parameter 'grantType' when calling RefreshToken");
            // verify the required parameter 'refreshToken' is set
            if (refreshToken == null) throw new ApiException(400, "Missing required parameter 'refreshToken' when calling RefreshToken");
            
    
            var localVarPath = "/token";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
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
            
            
            
            if (grantType != null) localVarFormParams.Add("grant_type", Configuration.ApiClient.ParameterToString(grantType)); // form parameter
            if (refreshToken != null) localVarFormParams.Add("refresh_token", Configuration.ApiClient.ParameterToString(refreshToken)); // form parameter
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling RefreshToken: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RefreshToken: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RefreshTokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RefreshTokenResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RefreshTokenResponse)));
            
        }
        
    }
    
}
