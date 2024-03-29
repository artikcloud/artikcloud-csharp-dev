/* 
 * ARTIK Cloud API
 *
 * No descripton provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CLOUD.Artik.Client;
using CLOUD.Artik.Api;
using CLOUD.Artik.Model;

namespace CLOUD.Artik.Test
{
    /// <summary>
    ///  Class for testing DevicesManagementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DevicesManagementApiTests
    {
        private DevicesManagementApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DevicesManagementApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DevicesManagementApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DevicesManagementApi
            //Assert.IsInstanceOfType(typeof(DevicesManagementApi), instance, "instance is a DevicesManagementApi");
        }

        
        /// <summary>
        /// Test CreateTasks
        /// </summary>
        [Test]
        public void CreateTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TaskRequest taskPayload = null;
            //var response = instance.CreateTasks(taskPayload);
            //Assert.IsInstanceOf<TaskEnvelope> (response, "response is TaskEnvelope");
        }
        
        /// <summary>
        /// Test DeleteServerProperties
        /// </summary>
        [Test]
        public void DeleteServerPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string did = null;
            //var response = instance.DeleteServerProperties(did);
            //Assert.IsInstanceOf<MetadataEnvelope> (response, "response is MetadataEnvelope");
        }
        
        /// <summary>
        /// Test GetAllByDid
        /// </summary>
        [Test]
        public void GetAllByDidTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string did = null;
            //int? count = null;
            //int? offset = null;
            //string status = null;
            //string order = null;
            //string sort = null;
            //var response = instance.GetAllByDid(did, count, offset, status, order, sort);
            //Assert.IsInstanceOf<TaskByDidListEnvelope> (response, "response is TaskByDidListEnvelope");
        }
        
        /// <summary>
        /// Test GetDeviceTypesInfo
        /// </summary>
        [Test]
        public void GetDeviceTypesInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dtid = null;
            //var response = instance.GetDeviceTypesInfo(dtid);
            //Assert.IsInstanceOf<DeviceTypesInfoEnvelope> (response, "response is DeviceTypesInfoEnvelope");
        }
        
        /// <summary>
        /// Test GetManifestProperties
        /// </summary>
        [Test]
        public void GetManifestPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dtid = null;
            //var response = instance.GetManifestProperties(dtid);
            //Assert.IsInstanceOf<MetadataPropertiesEnvelope> (response, "response is MetadataPropertiesEnvelope");
        }
        
        /// <summary>
        /// Test GetProperties
        /// </summary>
        [Test]
        public void GetPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string did = null;
            //bool? includeTimestamp = null;
            //var response = instance.GetProperties(did, includeTimestamp);
            //Assert.IsInstanceOf<MetadataEnvelope> (response, "response is MetadataEnvelope");
        }
        
        /// <summary>
        /// Test GetStatuses
        /// </summary>
        [Test]
        public void GetStatusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tid = null;
            //int? count = null;
            //int? offset = null;
            //string status = null;
            //string dids = null;
            //var response = instance.GetStatuses(tid, count, offset, status, dids);
            //Assert.IsInstanceOf<TaskStatusesEnvelope> (response, "response is TaskStatusesEnvelope");
        }
        
        /// <summary>
        /// Test GetStatusesHistory
        /// </summary>
        [Test]
        public void GetStatusesHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tid = null;
            //string did = null;
            //var response = instance.GetStatusesHistory(tid, did);
            //Assert.IsInstanceOf<TaskStatusesHistoryEnvelope> (response, "response is TaskStatusesHistoryEnvelope");
        }
        
        /// <summary>
        /// Test GetTaskByID
        /// </summary>
        [Test]
        public void GetTaskByIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tid = null;
            //var response = instance.GetTaskByID(tid);
            //Assert.IsInstanceOf<TaskEnvelope> (response, "response is TaskEnvelope");
        }
        
        /// <summary>
        /// Test GetTasks
        /// </summary>
        [Test]
        public void GetTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dtid = null;
            //int? count = null;
            //int? offset = null;
            //string status = null;
            //string order = null;
            //string sort = null;
            //var response = instance.GetTasks(dtid, count, offset, status, order, sort);
            //Assert.IsInstanceOf<TaskListEnvelope> (response, "response is TaskListEnvelope");
        }
        
        /// <summary>
        /// Test QueryProperties
        /// </summary>
        [Test]
        public void QueryPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dtid = null;
            //int? count = null;
            //int? offset = null;
            //string filter = null;
            //bool? includeTimestamp = null;
            //var response = instance.QueryProperties(dtid, count, offset, filter, includeTimestamp);
            //Assert.IsInstanceOf<MetadataQueryEnvelope> (response, "response is MetadataQueryEnvelope");
        }
        
        /// <summary>
        /// Test UpdateDeviceTypesInfo
        /// </summary>
        [Test]
        public void UpdateDeviceTypesInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dtid = null;
            //DeviceTypesInfo deviceTypeInfo = null;
            //var response = instance.UpdateDeviceTypesInfo(dtid, deviceTypeInfo);
            //Assert.IsInstanceOf<DeviceTypesInfoEnvelope> (response, "response is DeviceTypesInfoEnvelope");
        }
        
        /// <summary>
        /// Test UpdateServerProperties
        /// </summary>
        [Test]
        public void UpdateServerPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string did = null;
            //MetadataRequest deviceProperties = null;
            //var response = instance.UpdateServerProperties(did, deviceProperties);
            //Assert.IsInstanceOf<MetadataEnvelope> (response, "response is MetadataEnvelope");
        }
        
        /// <summary>
        /// Test UpdateTask
        /// </summary>
        [Test]
        public void UpdateTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tid = null;
            //TaskUpdateRequest taskUpdateRequest = null;
            //var response = instance.UpdateTask(tid, taskUpdateRequest);
            //Assert.IsInstanceOf<TaskUpdateResponse> (response, "response is TaskUpdateResponse");
        }
        
        /// <summary>
        /// Test UpdateTaskForDevice
        /// </summary>
        [Test]
        public void UpdateTaskForDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tid = null;
            //string did = null;
            //DeviceTaskUpdateRequest deviceTaskUpdateRequest = null;
            //var response = instance.UpdateTaskForDevice(tid, did, deviceTaskUpdateRequest);
            //Assert.IsInstanceOf<DeviceTaskUpdateResponse> (response, "response is DeviceTaskUpdateResponse");
        }
        
    }

}
