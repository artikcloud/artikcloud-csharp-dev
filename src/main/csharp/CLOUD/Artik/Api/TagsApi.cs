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
    public interface ITagsApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get all categories
        /// </summary>
        /// <remarks>
        /// Get all tags marked as categories
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TagsEnvelope</returns>
        TagsEnvelope GetTagCategories ();
  
        /// <summary>
        /// Get all categories
        /// </summary>
        /// <remarks>
        /// Get all tags marked as categories
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TagsEnvelope</returns>
        ApiResponse<TagsEnvelope> GetTagCategoriesWithHttpInfo ();
        
        /// <summary>
        /// Get tag suggestions
        /// </summary>
        /// <remarks>
        /// Get tag suggestions for applications, device types that have been most used with a group of tags.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type name. (optional)</param>
        /// <param name="tags">Comma separated list of tags. (optional)</param>
        /// <param name="name">Name of tags used for type ahead. (optional)</param>
        /// <param name="count">Number of results to return. Max 10. (optional)</param>
        /// <returns>TagsEnvelope</returns>
        TagsEnvelope GetTagSuggestions (string entityType = null, string tags = null, string name = null, int? count = null);
  
        /// <summary>
        /// Get tag suggestions
        /// </summary>
        /// <remarks>
        /// Get tag suggestions for applications, device types that have been most used with a group of tags.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type name. (optional)</param>
        /// <param name="tags">Comma separated list of tags. (optional)</param>
        /// <param name="name">Name of tags used for type ahead. (optional)</param>
        /// <param name="count">Number of results to return. Max 10. (optional)</param>
        /// <returns>ApiResponse of TagsEnvelope</returns>
        ApiResponse<TagsEnvelope> GetTagSuggestionsWithHttpInfo (string entityType = null, string tags = null, string name = null, int? count = null);
        
        /// <summary>
        /// Get all tags of categories
        /// </summary>
        /// <remarks>
        /// Get all tags related to the list of categories
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categories">Comma separated list of categories. (optional)</param>
        /// <returns>TagsEnvelope</returns>
        TagsEnvelope GetTagsByCategories (string categories = null);
  
        /// <summary>
        /// Get all tags of categories
        /// </summary>
        /// <remarks>
        /// Get all tags related to the list of categories
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categories">Comma separated list of categories. (optional)</param>
        /// <returns>ApiResponse of TagsEnvelope</returns>
        ApiResponse<TagsEnvelope> GetTagsByCategoriesWithHttpInfo (string categories = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get all categories
        /// </summary>
        /// <remarks>
        /// Get all tags marked as categories
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TagsEnvelope</returns>
        System.Threading.Tasks.Task<TagsEnvelope> GetTagCategoriesAsync ();

        /// <summary>
        /// Get all categories
        /// </summary>
        /// <remarks>
        /// Get all tags marked as categories
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TagsEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagsEnvelope>> GetTagCategoriesAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get tag suggestions
        /// </summary>
        /// <remarks>
        /// Get tag suggestions for applications, device types that have been most used with a group of tags.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type name. (optional)</param>
        /// <param name="tags">Comma separated list of tags. (optional)</param>
        /// <param name="name">Name of tags used for type ahead. (optional)</param>
        /// <param name="count">Number of results to return. Max 10. (optional)</param>
        /// <returns>Task of TagsEnvelope</returns>
        System.Threading.Tasks.Task<TagsEnvelope> GetTagSuggestionsAsync (string entityType = null, string tags = null, string name = null, int? count = null);

        /// <summary>
        /// Get tag suggestions
        /// </summary>
        /// <remarks>
        /// Get tag suggestions for applications, device types that have been most used with a group of tags.
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type name. (optional)</param>
        /// <param name="tags">Comma separated list of tags. (optional)</param>
        /// <param name="name">Name of tags used for type ahead. (optional)</param>
        /// <param name="count">Number of results to return. Max 10. (optional)</param>
        /// <returns>Task of ApiResponse (TagsEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagsEnvelope>> GetTagSuggestionsAsyncWithHttpInfo (string entityType = null, string tags = null, string name = null, int? count = null);
        
        /// <summary>
        /// Get all tags of categories
        /// </summary>
        /// <remarks>
        /// Get all tags related to the list of categories
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categories">Comma separated list of categories. (optional)</param>
        /// <returns>Task of TagsEnvelope</returns>
        System.Threading.Tasks.Task<TagsEnvelope> GetTagsByCategoriesAsync (string categories = null);

        /// <summary>
        /// Get all tags of categories
        /// </summary>
        /// <remarks>
        /// Get all tags related to the list of categories
        /// </remarks>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categories">Comma separated list of categories. (optional)</param>
        /// <returns>Task of ApiResponse (TagsEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagsEnvelope>> GetTagsByCategoriesAsyncWithHttpInfo (string categories = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TagsApi : ITagsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TagsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TagsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TagsApi(Configuration configuration = null)
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
        /// Get all categories Get all tags marked as categories
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TagsEnvelope</returns>
        public TagsEnvelope GetTagCategories ()
        {
             ApiResponse<TagsEnvelope> localVarResponse = GetTagCategoriesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all categories Get all tags marked as categories
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TagsEnvelope</returns>
        public ApiResponse< TagsEnvelope > GetTagCategoriesWithHttpInfo ()
        {
            
    
            var localVarPath = "/tags/categories";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetTagCategories: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTagCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TagsEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagsEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagsEnvelope)));
            
        }

        
        /// <summary>
        /// Get all categories Get all tags marked as categories
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TagsEnvelope</returns>
        public async System.Threading.Tasks.Task<TagsEnvelope> GetTagCategoriesAsync ()
        {
             ApiResponse<TagsEnvelope> localVarResponse = await GetTagCategoriesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all categories Get all tags marked as categories
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TagsEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagsEnvelope>> GetTagCategoriesAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/tags/categories";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetTagCategories: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTagCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagsEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagsEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagsEnvelope)));
            
        }
        
        /// <summary>
        /// Get tag suggestions Get tag suggestions for applications, device types that have been most used with a group of tags.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type name. (optional)</param> 
        /// <param name="tags">Comma separated list of tags. (optional)</param> 
        /// <param name="name">Name of tags used for type ahead. (optional)</param> 
        /// <param name="count">Number of results to return. Max 10. (optional)</param> 
        /// <returns>TagsEnvelope</returns>
        public TagsEnvelope GetTagSuggestions (string entityType = null, string tags = null, string name = null, int? count = null)
        {
             ApiResponse<TagsEnvelope> localVarResponse = GetTagSuggestionsWithHttpInfo(entityType, tags, name, count);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get tag suggestions Get tag suggestions for applications, device types that have been most used with a group of tags.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type name. (optional)</param> 
        /// <param name="tags">Comma separated list of tags. (optional)</param> 
        /// <param name="name">Name of tags used for type ahead. (optional)</param> 
        /// <param name="count">Number of results to return. Max 10. (optional)</param> 
        /// <returns>ApiResponse of TagsEnvelope</returns>
        public ApiResponse< TagsEnvelope > GetTagSuggestionsWithHttpInfo (string entityType = null, string tags = null, string name = null, int? count = null)
        {
            
    
            var localVarPath = "/tags/suggestions";
    
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
            
            if (entityType != null) localVarQueryParams.Add("entity_type", Configuration.ApiClient.ParameterToString(entityType)); // query parameter
            if (tags != null) localVarQueryParams.Add("tags", Configuration.ApiClient.ParameterToString(tags)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetTagSuggestions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTagSuggestions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TagsEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagsEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagsEnvelope)));
            
        }

        
        /// <summary>
        /// Get tag suggestions Get tag suggestions for applications, device types that have been most used with a group of tags.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type name. (optional)</param>
        /// <param name="tags">Comma separated list of tags. (optional)</param>
        /// <param name="name">Name of tags used for type ahead. (optional)</param>
        /// <param name="count">Number of results to return. Max 10. (optional)</param>
        /// <returns>Task of TagsEnvelope</returns>
        public async System.Threading.Tasks.Task<TagsEnvelope> GetTagSuggestionsAsync (string entityType = null, string tags = null, string name = null, int? count = null)
        {
             ApiResponse<TagsEnvelope> localVarResponse = await GetTagSuggestionsAsyncWithHttpInfo(entityType, tags, name, count);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get tag suggestions Get tag suggestions for applications, device types that have been most used with a group of tags.
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityType">Entity type name. (optional)</param>
        /// <param name="tags">Comma separated list of tags. (optional)</param>
        /// <param name="name">Name of tags used for type ahead. (optional)</param>
        /// <param name="count">Number of results to return. Max 10. (optional)</param>
        /// <returns>Task of ApiResponse (TagsEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagsEnvelope>> GetTagSuggestionsAsyncWithHttpInfo (string entityType = null, string tags = null, string name = null, int? count = null)
        {
            
    
            var localVarPath = "/tags/suggestions";
    
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
            
            if (entityType != null) localVarQueryParams.Add("entity_type", Configuration.ApiClient.ParameterToString(entityType)); // query parameter
            if (tags != null) localVarQueryParams.Add("tags", Configuration.ApiClient.ParameterToString(tags)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetTagSuggestions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTagSuggestions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagsEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagsEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagsEnvelope)));
            
        }
        
        /// <summary>
        /// Get all tags of categories Get all tags related to the list of categories
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categories">Comma separated list of categories. (optional)</param> 
        /// <returns>TagsEnvelope</returns>
        public TagsEnvelope GetTagsByCategories (string categories = null)
        {
             ApiResponse<TagsEnvelope> localVarResponse = GetTagsByCategoriesWithHttpInfo(categories);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all tags of categories Get all tags related to the list of categories
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categories">Comma separated list of categories. (optional)</param> 
        /// <returns>ApiResponse of TagsEnvelope</returns>
        public ApiResponse< TagsEnvelope > GetTagsByCategoriesWithHttpInfo (string categories = null)
        {
            
    
            var localVarPath = "/tags";
    
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
            
            if (categories != null) localVarQueryParams.Add("categories", Configuration.ApiClient.ParameterToString(categories)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetTagsByCategories: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTagsByCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TagsEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagsEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagsEnvelope)));
            
        }

        
        /// <summary>
        /// Get all tags of categories Get all tags related to the list of categories
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categories">Comma separated list of categories. (optional)</param>
        /// <returns>Task of TagsEnvelope</returns>
        public async System.Threading.Tasks.Task<TagsEnvelope> GetTagsByCategoriesAsync (string categories = null)
        {
             ApiResponse<TagsEnvelope> localVarResponse = await GetTagsByCategoriesAsyncWithHttpInfo(categories);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all tags of categories Get all tags related to the list of categories
        /// </summary>
        /// <exception cref="CLOUD.Artik.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categories">Comma separated list of categories. (optional)</param>
        /// <returns>Task of ApiResponse (TagsEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagsEnvelope>> GetTagsByCategoriesAsyncWithHttpInfo (string categories = null)
        {
            
    
            var localVarPath = "/tags";
    
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
            
            if (categories != null) localVarQueryParams.Add("categories", Configuration.ApiClient.ParameterToString(categories)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetTagsByCategories: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTagsByCategories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagsEnvelope>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagsEnvelope) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagsEnvelope)));
            
        }
        
    }
    
}
