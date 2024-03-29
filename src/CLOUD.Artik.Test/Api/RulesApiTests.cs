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

using CLOUD.Artik.Api;
using NUnit.Framework;

namespace CLOUD.Artik.Test
{
    /// <summary>
    ///     Class for testing RulesApi
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by Swagger Codegen.
    ///     Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RulesApiTests
    {
        private RulesApi instance;

        /// <summary>
        ///     Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RulesApi();
        }

        /// <summary>
        ///     Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        ///     Test CreateRule
        /// </summary>
        [Test]
        public void CreateRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RuleCreationInfo ruleInfo = null;
            //string userId = null;
            //var response = instance.CreateRule(ruleInfo, userId);
            //Assert.IsInstanceOf<RuleEnvelope> (response, "response is RuleEnvelope");
        }

        /// <summary>
        ///     Test DeleteRule
        /// </summary>
        [Test]
        public void DeleteRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ruleId = null;
            //var response = instance.DeleteRule(ruleId);
            //Assert.IsInstanceOf<RuleEnvelope> (response, "response is RuleEnvelope");
        }

        /// <summary>
        ///     Test GetRule
        /// </summary>
        [Test]
        public void GetRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ruleId = null;
            //var response = instance.GetRule(ruleId);
            //Assert.IsInstanceOf<RuleEnvelope> (response, "response is RuleEnvelope");
        }

        /// <summary>
        ///     Test UpdateRule
        /// </summary>
        [Test]
        public void UpdateRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ruleId = null;
            //RuleUpdateInfo ruleInfo = null;
            //var response = instance.UpdateRule(ruleId, ruleInfo);
            //Assert.IsInstanceOf<RuleEnvelope> (response, "response is RuleEnvelope");
        }
    }
}