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
    public interface IRulesApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create Rule
        /// </summary>
        /// <remarks>
        /// Create a new Rule
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleInfo">Rule object that needs to be added</param>
        /// <param name="userId">User ID</param>
        /// <returns>RuleEnvelope</returns>
        RuleEnvelope CreateRule (RuleCreationInfo ruleInfo, string userId);
  
        /// <summary>
        /// Create Rule
        /// </summary>
        /// <remarks>
        /// Create a new Rule
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleInfo">Rule object that needs to be added</param>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of RuleEnvelope</returns>
        ApiResponse<RuleEnvelope> CreateRuleWithHttpInfo (RuleCreationInfo ruleInfo, string userId);
        
        /// <summary>
        /// Delete Rule
        /// </summary>
        /// <remarks>
        /// Delete a Rule
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <returns>RuleEnvelope</returns>
        RuleEnvelope DeleteRule (string ruleId);
  
        /// <summary>
        /// Delete Rule
        /// </summary>
        /// <remarks>
        /// Delete a Rule
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <returns>ApiResponse of RuleEnvelope</returns>
        ApiResponse<RuleEnvelope> DeleteRuleWithHttpInfo (string ruleId);
        
        /// <summary>
        /// Get Rule
        /// </summary>
        /// <remarks>
        /// Get a rule using the Rule ID
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <returns>RuleEnvelope</returns>
        RuleEnvelope GetRule (string ruleId);
  
        /// <summary>
        /// Get Rule
        /// </summary>
        /// <remarks>
        /// Get a rule using the Rule ID
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <returns>ApiResponse of RuleEnvelope</returns>
        ApiResponse<RuleEnvelope> GetRuleWithHttpInfo (string ruleId);
        
        /// <summary>
        /// Update Rule
        /// </summary>
        /// <remarks>
        /// Update an existing Rule
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <param name="ruleInfo">Rule object that needs to be updated</param>
        /// <returns>RuleEnvelope</returns>
        RuleEnvelope UpdateRule (string ruleId, RuleUpdateInfo ruleInfo);
  
        /// <summary>
        /// Update Rule
        /// </summary>
        /// <remarks>
        /// Update an existing Rule
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <param name="ruleInfo">Rule object that needs to be updated</param>
        /// <returns>ApiResponse of RuleEnvelope</returns>
        ApiResponse<RuleEnvelope> UpdateRuleWithHttpInfo (string ruleId, RuleUpdateInfo ruleInfo);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create Rule
        /// </summary>
        /// <remarks>
        /// Create a new Rule
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleInfo">Rule object that needs to be added</param>
        /// <param name="userId">User ID</param>
        /// <returns>Task of RuleEnvelope</returns>
        System.Threading.Tasks.Task<RuleEnvelope> CreateRuleAsync (RuleCreationInfo ruleInfo, string userId);

        /// <summary>
        /// Create Rule
        /// </summary>
        /// <remarks>
        /// Create a new Rule
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleInfo">Rule object that needs to be added</param>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (RuleEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleEnvelope>> CreateRuleAsyncWithHttpInfo (RuleCreationInfo ruleInfo, string userId);
        
        /// <summary>
        /// Delete Rule
        /// </summary>
        /// <remarks>
        /// Delete a Rule
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <returns>Task of RuleEnvelope</returns>
        System.Threading.Tasks.Task<RuleEnvelope> DeleteRuleAsync (string ruleId);

        /// <summary>
        /// Delete Rule
        /// </summary>
        /// <remarks>
        /// Delete a Rule
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <returns>Task of ApiResponse (RuleEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleEnvelope>> DeleteRuleAsyncWithHttpInfo (string ruleId);
        
        /// <summary>
        /// Get Rule
        /// </summary>
        /// <remarks>
        /// Get a rule using the Rule ID
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <returns>Task of RuleEnvelope</returns>
        System.Threading.Tasks.Task<RuleEnvelope> GetRuleAsync (string ruleId);

        /// <summary>
        /// Get Rule
        /// </summary>
        /// <remarks>
        /// Get a rule using the Rule ID
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <returns>Task of ApiResponse (RuleEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleEnvelope>> GetRuleAsyncWithHttpInfo (string ruleId);
        
        /// <summary>
        /// Update Rule
        /// </summary>
        /// <remarks>
        /// Update an existing Rule
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <param name="ruleInfo">Rule object that needs to be updated</param>
        /// <returns>Task of RuleEnvelope</returns>
        System.Threading.Tasks.Task<RuleEnvelope> UpdateRuleAsync (string ruleId, RuleUpdateInfo ruleInfo);

        /// <summary>
        /// Update Rule
        /// </summary>
        /// <remarks>
        /// Update an existing Rule
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <param name="ruleInfo">Rule object that needs to be updated</param>
        /// <returns>Task of ApiResponse (RuleEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleEnvelope>> UpdateRuleAsyncWithHttpInfo (string ruleId, RuleUpdateInfo ruleInfo);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RulesApi : IRulesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RulesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RulesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RulesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RulesApi(Configuration configuration = null)
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
        /// Create Rule Create a new Rule
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleInfo">Rule object that needs to be added</param> 
        /// <param name="userId">User ID</param> 
        /// <returns>RuleEnvelope</returns>
        public RuleEnvelope CreateRule (RuleCreationInfo ruleInfo, string userId)
        {
             ApiResponse<RuleEnvelope> localVarResponse = CreateRuleWithHttpInfo(ruleInfo, userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Rule Create a new Rule
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleInfo">Rule object that needs to be added</param> 
        /// <param name="userId">User ID</param> 
        /// <returns>ApiResponse of RuleEnvelope</returns>
        public ApiResponse< RuleEnvelope > CreateRuleWithHttpInfo (RuleCreationInfo ruleInfo, string userId)
        {
            
            // verify the required parameter 'ruleInfo' is set
            if (ruleInfo == null)
                throw new ApiException(400, "Missing required parameter 'ruleInfo' when calling RulesApi->CreateRule");
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RulesApi->CreateRule");
            
    
            var localVarPath = "/rules";
    
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
            
            if (userId != null) localVarQueryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            
            
            
            if (ruleInfo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(ruleInfo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = ruleInfo; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling CreateRule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RuleEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleEnvelope)));
            
        }

        
        /// <summary>
        /// Create Rule Create a new Rule
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleInfo">Rule object that needs to be added</param>
        /// <param name="userId">User ID</param>
        /// <returns>Task of RuleEnvelope</returns>
        public async System.Threading.Tasks.Task<RuleEnvelope> CreateRuleAsync (RuleCreationInfo ruleInfo, string userId)
        {
             ApiResponse<RuleEnvelope> localVarResponse = await CreateRuleAsyncWithHttpInfo(ruleInfo, userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Rule Create a new Rule
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleInfo">Rule object that needs to be added</param>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (RuleEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleEnvelope>> CreateRuleAsyncWithHttpInfo (RuleCreationInfo ruleInfo, string userId)
        {
            // verify the required parameter 'ruleInfo' is set
            if (ruleInfo == null) throw new ApiException(400, "Missing required parameter 'ruleInfo' when calling CreateRule");
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling CreateRule");
            
    
            var localVarPath = "/rules";
    
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
            
            if (userId != null) localVarQueryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            
            
            
            if (ruleInfo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(ruleInfo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = ruleInfo; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling CreateRule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleEnvelope)));
            
        }
        
        /// <summary>
        /// Delete Rule Delete a Rule
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param> 
        /// <returns>RuleEnvelope</returns>
        public RuleEnvelope DeleteRule (string ruleId)
        {
             ApiResponse<RuleEnvelope> localVarResponse = DeleteRuleWithHttpInfo(ruleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Rule Delete a Rule
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param> 
        /// <returns>ApiResponse of RuleEnvelope</returns>
        public ApiResponse< RuleEnvelope > DeleteRuleWithHttpInfo (string ruleId)
        {
            
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling RulesApi->DeleteRule");
            
    
            var localVarPath = "/rules/{ruleId}";
    
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
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RuleEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleEnvelope)));
            
        }

        
        /// <summary>
        /// Delete Rule Delete a Rule
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <returns>Task of RuleEnvelope</returns>
        public async System.Threading.Tasks.Task<RuleEnvelope> DeleteRuleAsync (string ruleId)
        {
             ApiResponse<RuleEnvelope> localVarResponse = await DeleteRuleAsyncWithHttpInfo(ruleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete Rule Delete a Rule
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <returns>Task of ApiResponse (RuleEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleEnvelope>> DeleteRuleAsyncWithHttpInfo (string ruleId)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling DeleteRule");
            
    
            var localVarPath = "/rules/{ruleId}";
    
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
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleEnvelope)));
            
        }
        
        /// <summary>
        /// Get Rule Get a rule using the Rule ID
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param> 
        /// <returns>RuleEnvelope</returns>
        public RuleEnvelope GetRule (string ruleId)
        {
             ApiResponse<RuleEnvelope> localVarResponse = GetRuleWithHttpInfo(ruleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Rule Get a rule using the Rule ID
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param> 
        /// <returns>ApiResponse of RuleEnvelope</returns>
        public ApiResponse< RuleEnvelope > GetRuleWithHttpInfo (string ruleId)
        {
            
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling RulesApi->GetRule");
            
    
            var localVarPath = "/rules/{ruleId}";
    
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
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetRule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RuleEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleEnvelope)));
            
        }

        
        /// <summary>
        /// Get Rule Get a rule using the Rule ID
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <returns>Task of RuleEnvelope</returns>
        public async System.Threading.Tasks.Task<RuleEnvelope> GetRuleAsync (string ruleId)
        {
             ApiResponse<RuleEnvelope> localVarResponse = await GetRuleAsyncWithHttpInfo(ruleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Rule Get a rule using the Rule ID
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <returns>Task of ApiResponse (RuleEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleEnvelope>> GetRuleAsyncWithHttpInfo (string ruleId)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling GetRule");
            
    
            var localVarPath = "/rules/{ruleId}";
    
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
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetRule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleEnvelope)));
            
        }
        
        /// <summary>
        /// Update Rule Update an existing Rule
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param> 
        /// <param name="ruleInfo">Rule object that needs to be updated</param> 
        /// <returns>RuleEnvelope</returns>
        public RuleEnvelope UpdateRule (string ruleId, RuleUpdateInfo ruleInfo)
        {
             ApiResponse<RuleEnvelope> localVarResponse = UpdateRuleWithHttpInfo(ruleId, ruleInfo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Rule Update an existing Rule
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param> 
        /// <param name="ruleInfo">Rule object that needs to be updated</param> 
        /// <returns>ApiResponse of RuleEnvelope</returns>
        public ApiResponse< RuleEnvelope > UpdateRuleWithHttpInfo (string ruleId, RuleUpdateInfo ruleInfo)
        {
            
            // verify the required parameter 'ruleId' is set
            if (ruleId == null)
                throw new ApiException(400, "Missing required parameter 'ruleId' when calling RulesApi->UpdateRule");
            
            // verify the required parameter 'ruleInfo' is set
            if (ruleInfo == null)
                throw new ApiException(400, "Missing required parameter 'ruleInfo' when calling RulesApi->UpdateRule");
            
    
            var localVarPath = "/rules/{ruleId}";
    
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
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
            
            
            
            
            if (ruleInfo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(ruleInfo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = ruleInfo; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateRule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RuleEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleEnvelope)));
            
        }

        
        /// <summary>
        /// Update Rule Update an existing Rule
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <param name="ruleInfo">Rule object that needs to be updated</param>
        /// <returns>Task of RuleEnvelope</returns>
        public async System.Threading.Tasks.Task<RuleEnvelope> UpdateRuleAsync (string ruleId, RuleUpdateInfo ruleInfo)
        {
             ApiResponse<RuleEnvelope> localVarResponse = await UpdateRuleAsyncWithHttpInfo(ruleId, ruleInfo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Rule Update an existing Rule
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleId">Rule ID.</param>
        /// <param name="ruleInfo">Rule object that needs to be updated</param>
        /// <returns>Task of ApiResponse (RuleEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleEnvelope>> UpdateRuleAsyncWithHttpInfo (string ruleId, RuleUpdateInfo ruleInfo)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling UpdateRule");
            // verify the required parameter 'ruleInfo' is set
            if (ruleInfo == null) throw new ApiException(400, "Missing required parameter 'ruleInfo' when calling UpdateRule");
            
    
            var localVarPath = "/rules/{ruleId}";
    
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
            if (ruleId != null) localVarPathParams.Add("ruleId", Configuration.ApiClient.ParameterToString(ruleId)); // path parameter
            
            
            
            
            if (ruleInfo.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(ruleInfo); // http body (model) parameter
            }
            else
            {
                localVarPostBody = ruleInfo; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateRule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleEnvelope)));
            
        }
        
    }
    
}
