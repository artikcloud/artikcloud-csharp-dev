# CLOUD.Artik.Api.TokensApi

All URIs are relative to *https://api.artik.cloud/v1.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckToken**](TokensApi.md#checktoken) | **POST** /accounts/checkToken | Check Token
[**RefreshToken**](TokensApi.md#refreshtoken) | **POST** /accounts/token | Refresh Token


<a name="checktoken"></a>
# **CheckToken**
> CheckTokenResponse CheckToken (TokenRequest tokenInfo)

Check Token

Check Token

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class CheckTokenExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi();
            var tokenInfo = new TokenRequest(); // TokenRequest | Token object to be checked

            try
            {
                // Check Token
                CheckTokenResponse result = apiInstance.CheckToken(tokenInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokensApi.CheckToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenInfo** | [**TokenRequest**](TokenRequest.md)| Token object to be checked | 

### Return type

[**CheckTokenResponse**](CheckTokenResponse.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refreshtoken"></a>
# **RefreshToken**
> RefreshTokenResponse RefreshToken (string grantType, string refreshToken)

Refresh Token

Refresh Token

### Example
```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using CLOUD.Artik.Model;

namespace Example
{
    public class RefreshTokenExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi();
            var grantType = grantType_example;  // string | Grant Type.
            var refreshToken = refreshToken_example;  // string | Refresh Token.

            try
            {
                // Refresh Token
                RefreshTokenResponse result = apiInstance.RefreshToken(grantType, refreshToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokensApi.RefreshToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **grantType** | **string**| Grant Type. | 
 **refreshToken** | **string**| Refresh Token. | 

### Return type

[**RefreshTokenResponse**](RefreshTokenResponse.md)

### Authorization

[artikcloud_oauth](../README.md#artikcloud_oauth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

