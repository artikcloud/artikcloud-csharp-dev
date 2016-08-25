ARTIK Cloud C# SDK
==================
[![Build Status](https://travis-ci.org/artikcloud/artikcloud-csharp.svg?branch=master)](https://travis-ci.org/artikcloud/artikcloud-csharp)

This SDK helps you connect your C# applications to ARTIK Cloud. It exposes a number of methods to easily execute REST API calls to ARTIK Cloud.

## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using Model;
```

## Getting Started

```csharp
using System;
using System.Diagnostics;
using CLOUD.Artik.Api;
using CLOUD.Artik.Client;
using Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: artikcloud_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeviceTypesApi();
            var deviceTypeId = "YOUR_DEVICE_TYPE_ID";  

            try
            {
                // Get Available Manifest Versions
                ManifestVersionsEnvelope result = apiInstance.GetAvailableManifestVersions(deviceTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceTypesApi.GetAvailableManifestVersions: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.artik.cloud/v1.1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DeviceTypesApi* | [**GetAvailableManifestVersions**](docs/DeviceTypesApi.md#getavailablemanifestversions) | **GET** /devicetypes/{deviceTypeId}/availablemanifestversions | Get Available Manifest Versions
*DeviceTypesApi* | [**GetDeviceType**](docs/DeviceTypesApi.md#getdevicetype) | **GET** /devicetypes/{deviceTypeId} | Get Device Type
*DeviceTypesApi* | [**GetDeviceTypes**](docs/DeviceTypesApi.md#getdevicetypes) | **GET** /devicetypes | Get Device Types
*DeviceTypesApi* | [**GetLatestManifestProperties**](docs/DeviceTypesApi.md#getlatestmanifestproperties) | **GET** /devicetypes/{deviceTypeId}/manifests/latest/properties | Get Latest Manifest Properties
*DeviceTypesApi* | [**GetManifestProperties**](docs/DeviceTypesApi.md#getmanifestproperties) | **GET** /devicetypes/{deviceTypeId}/manifests/{version}/properties | Get manifest properties
*DevicesApi* | [**AddDevice**](docs/DevicesApi.md#adddevice) | **POST** /devices | Add Device
*DevicesApi* | [**DeleteDevice**](docs/DevicesApi.md#deletedevice) | **DELETE** /devices/{deviceId} | Delete Device
*DevicesApi* | [**DeleteDeviceToken**](docs/DevicesApi.md#deletedevicetoken) | **DELETE** /devices/{deviceId}/tokens | Delete Device Token
*DevicesApi* | [**GetDevice**](docs/DevicesApi.md#getdevice) | **GET** /devices/{deviceId} | Get Device
*DevicesApi* | [**GetDevicePresence**](docs/DevicesApi.md#getdevicepresence) | **GET** /devices/{deviceId}/presence | Get device presence information
*DevicesApi* | [**GetDeviceToken**](docs/DevicesApi.md#getdevicetoken) | **GET** /devices/{deviceId}/tokens | Get Device Token
*DevicesApi* | [**UpdateDevice**](docs/DevicesApi.md#updatedevice) | **PUT** /devices/{deviceId} | Update Device
*DevicesApi* | [**UpdateDeviceToken**](docs/DevicesApi.md#updatedevicetoken) | **PUT** /devices/{deviceId}/tokens | Update Device Token
*ExportApi* | [**ExportRequest**](docs/ExportApi.md#exportrequest) | **POST** /messages/export | Create Export Request
*ExportApi* | [**GetExportHistory**](docs/ExportApi.md#getexporthistory) | **GET** /messages/export/history | Get Export History
*ExportApi* | [**GetExportResult**](docs/ExportApi.md#getexportresult) | **GET** /messages/export/{exportId}/result | Get Export Result
*ExportApi* | [**GetExportStatus**](docs/ExportApi.md#getexportstatus) | **GET** /messages/export/{exportId}/status | Check Export Status
*MessagesApi* | [**GetAggregatesHistogram**](docs/MessagesApi.md#getaggregateshistogram) | **GET** /messages/analytics/histogram | Get Normalized Message Histogram
*MessagesApi* | [**GetFieldPresence**](docs/MessagesApi.md#getfieldpresence) | **GET** /messages/presence | Get normalized message presence
*MessagesApi* | [**GetLastNormalizedMessages**](docs/MessagesApi.md#getlastnormalizedmessages) | **GET** /messages/last | Get Last Normalized Message
*MessagesApi* | [**GetMessageAggregates**](docs/MessagesApi.md#getmessageaggregates) | **GET** /messages/analytics/aggregates | Get Normalized Message Aggregates
*MessagesApi* | [**GetMessageSnapshots**](docs/MessagesApi.md#getmessagesnapshots) | **GET** /messages/snapshots | Get Message Snapshots
*MessagesApi* | [**GetNormalizedActions**](docs/MessagesApi.md#getnormalizedactions) | **GET** /actions | Get Normalized Actions
*MessagesApi* | [**GetNormalizedMessages**](docs/MessagesApi.md#getnormalizedmessages) | **GET** /messages | Get Normalized Messages
*MessagesApi* | [**SendActions**](docs/MessagesApi.md#sendactions) | **POST** /actions | Send Actions
*MessagesApi* | [**SendMessage**](docs/MessagesApi.md#sendmessage) | **POST** /messages | Send Message
*RegistrationsApi* | [**ConfirmUser**](docs/RegistrationsApi.md#confirmuser) | **PUT** /devices/registrations/pin | Confirm User
*RegistrationsApi* | [**GetRequestStatusForUser**](docs/RegistrationsApi.md#getrequeststatusforuser) | **GET** /devices/registrations/{requestId}/status | Get Request Status For User
*RegistrationsApi* | [**UnregisterDevice**](docs/RegistrationsApi.md#unregisterdevice) | **DELETE** /devices/{deviceId}/registrations | Unregister Device
*RulesApi* | [**CreateRule**](docs/RulesApi.md#createrule) | **POST** /rules | Create Rule
*RulesApi* | [**DeleteRule**](docs/RulesApi.md#deleterule) | **DELETE** /rules/{ruleId} | Delete Rule
*RulesApi* | [**GetRule**](docs/RulesApi.md#getrule) | **GET** /rules/{ruleId} | Get Rule
*RulesApi* | [**UpdateRule**](docs/RulesApi.md#updaterule) | **PUT** /rules/{ruleId} | Update Rule
*TagsApi* | [**GetTagCategories**](docs/TagsApi.md#gettagcategories) | **GET** /tags/categories | Get all categories
*TagsApi* | [**GetTagSuggestions**](docs/TagsApi.md#gettagsuggestions) | **GET** /tags/suggestions | Get tag suggestions
*TagsApi* | [**GetTagsByCategories**](docs/TagsApi.md#gettagsbycategories) | **GET** /tags | Get all tags of categories
*TokensApi* | [**CheckToken**](docs/TokensApi.md#checktoken) | **POST** /accounts/checkToken | Check Token
*TokensApi* | [**RefreshToken**](docs/TokensApi.md#refreshtoken) | **POST** /accounts/token | Refresh Token
*TokensApi* | [**TokenInfo**](docs/TokensApi.md#tokeninfo) | **GET** /accounts/tokenInfo | Token Info
*UsersApi* | [**CreateUserProperties**](docs/UsersApi.md#createuserproperties) | **POST** /users/{userId}/properties | Create User Application Properties
*UsersApi* | [**DeleteUserProperties**](docs/UsersApi.md#deleteuserproperties) | **DELETE** /users/{userId}/properties | Delete User Application Properties
*UsersApi* | [**GetSelf**](docs/UsersApi.md#getself) | **GET** /users/self | Get Current User Profile
*UsersApi* | [**GetUserDeviceTypes**](docs/UsersApi.md#getuserdevicetypes) | **GET** /users/{userId}/devicetypes | Get User Device Types
*UsersApi* | [**GetUserDevices**](docs/UsersApi.md#getuserdevices) | **GET** /users/{userId}/devices | Get User Devices
*UsersApi* | [**GetUserProperties**](docs/UsersApi.md#getuserproperties) | **GET** /users/{userId}/properties | Get User application properties
*UsersApi* | [**GetUserRules**](docs/UsersApi.md#getuserrules) | **GET** /users/{userId}/rules | Get User Rules
*UsersApi* | [**UpdateUserProperties**](docs/UsersApi.md#updateuserproperties) | **PUT** /users/{userId}/properties | Update User Application Properties


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AckEnvelope](docs/AckEnvelope.md)
 - [Model.Acknowledgement](docs/Acknowledgement.md)
 - [Model.Action](docs/Action.md)
 - [Model.ActionArray](docs/ActionArray.md)
 - [Model.ActionDetails](docs/ActionDetails.md)
 - [Model.ActionDetailsArray](docs/ActionDetailsArray.md)
 - [Model.ActionIn](docs/ActionIn.md)
 - [Model.ActionOut](docs/ActionOut.md)
 - [Model.Actions](docs/Actions.md)
 - [Model.AggregateData](docs/AggregateData.md)
 - [Model.AggregatesHistogramData](docs/AggregatesHistogramData.md)
 - [Model.AggregatesHistogramResponse](docs/AggregatesHistogramResponse.md)
 - [Model.AggregatesResponse](docs/AggregatesResponse.md)
 - [Model.AppProperties](docs/AppProperties.md)
 - [Model.CheckTokenMessage](docs/CheckTokenMessage.md)
 - [Model.CheckTokenResponse](docs/CheckTokenResponse.md)
 - [Model.Device](docs/Device.md)
 - [Model.DeviceArray](docs/DeviceArray.md)
 - [Model.DeviceEnvelope](docs/DeviceEnvelope.md)
 - [Model.DeviceRegCompleteRequest](docs/DeviceRegCompleteRequest.md)
 - [Model.DeviceRegConfirmUserRequest](docs/DeviceRegConfirmUserRequest.md)
 - [Model.DeviceRegConfirmUserResponse](docs/DeviceRegConfirmUserResponse.md)
 - [Model.DeviceRegConfirmUserResponseEnvelope](docs/DeviceRegConfirmUserResponseEnvelope.md)
 - [Model.DeviceRegStatusResponse](docs/DeviceRegStatusResponse.md)
 - [Model.DeviceRegStatusResponseEnvelope](docs/DeviceRegStatusResponseEnvelope.md)
 - [Model.DeviceToken](docs/DeviceToken.md)
 - [Model.DeviceTokenEnvelope](docs/DeviceTokenEnvelope.md)
 - [Model.DeviceType](docs/DeviceType.md)
 - [Model.DeviceTypeArray](docs/DeviceTypeArray.md)
 - [Model.DeviceTypeEnvelope](docs/DeviceTypeEnvelope.md)
 - [Model.DeviceTypesEnvelope](docs/DeviceTypesEnvelope.md)
 - [Model.DevicesEnvelope](docs/DevicesEnvelope.md)
 - [Model.ErrorEnvelope](docs/ErrorEnvelope.md)
 - [Model.ExportData](docs/ExportData.md)
 - [Model.ExportDataArray](docs/ExportDataArray.md)
 - [Model.ExportHistoryResponse](docs/ExportHistoryResponse.md)
 - [Model.ExportNormalizedMessagesResponse](docs/ExportNormalizedMessagesResponse.md)
 - [Model.ExportRequest](docs/ExportRequest.md)
 - [Model.ExportRequestData](docs/ExportRequestData.md)
 - [Model.ExportRequestInfo](docs/ExportRequestInfo.md)
 - [Model.ExportRequestResponse](docs/ExportRequestResponse.md)
 - [Model.ExportResponse](docs/ExportResponse.md)
 - [Model.ExportStatusResponse](docs/ExportStatusResponse.md)
 - [Model.FieldPath](docs/FieldPath.md)
 - [Model.FieldPresence](docs/FieldPresence.md)
 - [Model.FieldPresenceEnvelope](docs/FieldPresenceEnvelope.md)
 - [Model.FieldsActions](docs/FieldsActions.md)
 - [Model.ManifestProperties](docs/ManifestProperties.md)
 - [Model.ManifestPropertiesEnvelope](docs/ManifestPropertiesEnvelope.md)
 - [Model.ManifestVersions](docs/ManifestVersions.md)
 - [Model.ManifestVersionsEnvelope](docs/ManifestVersionsEnvelope.md)
 - [Model.Message](docs/Message.md)
 - [Model.MessageAction](docs/MessageAction.md)
 - [Model.MessageID](docs/MessageID.md)
 - [Model.MessageIDEnvelope](docs/MessageIDEnvelope.md)
 - [Model.MessageIn](docs/MessageIn.md)
 - [Model.MessageOut](docs/MessageOut.md)
 - [Model.NonEmptyString](docs/NonEmptyString.md)
 - [Model.NormalizedAction](docs/NormalizedAction.md)
 - [Model.NormalizedActionsEnvelope](docs/NormalizedActionsEnvelope.md)
 - [Model.NormalizedMessage](docs/NormalizedMessage.md)
 - [Model.NormalizedMessagesEnvelope](docs/NormalizedMessagesEnvelope.md)
 - [Model.OutputRule](docs/OutputRule.md)
 - [Model.PresenceEnvelope](docs/PresenceEnvelope.md)
 - [Model.PresenceModel](docs/PresenceModel.md)
 - [Model.PropertiesEnvelope](docs/PropertiesEnvelope.md)
 - [Model.RefreshTokenResponse](docs/RefreshTokenResponse.md)
 - [Model.RegisterMessage](docs/RegisterMessage.md)
 - [Model.RuleArray](docs/RuleArray.md)
 - [Model.RuleCreationInfo](docs/RuleCreationInfo.md)
 - [Model.RuleEnvelope](docs/RuleEnvelope.md)
 - [Model.RuleError](docs/RuleError.md)
 - [Model.RuleUpdateInfo](docs/RuleUpdateInfo.md)
 - [Model.RuleWarningOutput](docs/RuleWarningOutput.md)
 - [Model.RulesEnvelope](docs/RulesEnvelope.md)
 - [Model.SnapshotResponse](docs/SnapshotResponse.md)
 - [Model.SnapshotResponses](docs/SnapshotResponses.md)
 - [Model.SnapshotsResponseEnvelope](docs/SnapshotsResponseEnvelope.md)
 - [Model.Tag](docs/Tag.md)
 - [Model.TagArray](docs/TagArray.md)
 - [Model.TagsEnvelope](docs/TagsEnvelope.md)
 - [Model.Token](docs/Token.md)
 - [Model.TokenInfo](docs/TokenInfo.md)
 - [Model.TokenInfoSuccessResponse](docs/TokenInfoSuccessResponse.md)
 - [Model.TokenRequest](docs/TokenRequest.md)
 - [Model.TokenResponse](docs/TokenResponse.md)
 - [Model.UnregisterDeviceResponse](docs/UnregisterDeviceResponse.md)
 - [Model.UnregisterDeviceResponseEnvelope](docs/UnregisterDeviceResponseEnvelope.md)
 - [Model.User](docs/User.md)
 - [Model.UserEnvelope](docs/UserEnvelope.md)
 - [Model.WebSocketError](docs/WebSocketError.md)


## Documentation for Authorization

### artikcloud_oauth

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: https://accounts.artik.cloud/authorize
- **Scopes**: 
  - read:artikcloud: Read from ARTIK Cloud
  - write:artikcloud: Write from ARTIK Cloud

Usage
------

Peek into [tests](https://github.com/artikcloud/artikcloud-csharp/tree/master/src/CLOUD.Artik.Test/Api) for examples about how to use the SDK.

More about ARTIK Cloud
----------------------

If you are not familiar with ARTIK Cloud, we have extensive documentation at https://developer.artik.cloud/documentation

The full ARTIK Cloud API specification can be found at https://developer.artik.cloud/documentation/api-reference/

Check out advanced sample applications at https://developer.artik.cloud/documentation/samples/

To create and manage your services and devices on ARTIK Cloud, create an account at https://developer.artik.cloud

Also see the ARTIK Cloud blog for tutorials, updates, and more: http://artik.io/blog/cloud

License and Copyright
---------------------

Licensed under the Apache License. See [LICENSE](https://github.com/artikcloud/artikcloud-java/blob/master/LICENSE).

Copyright (c) 2016 Samsung Electronics Co., Ltd.
