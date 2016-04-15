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
    ///  Class for testing TokensApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TokensApiTests
    {
        private TokensApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
          // set timeout to 10 seconds
          ApiClient client = new ApiClient (basePath: "https://accounts.artik.cloud");
          Configuration c1 = new Configuration (apiClient: client, timeout: 10000, accessToken: "12d094c0b6294f7f9bdbfcf0d2f6c64b");
           instance = new TokensApi(c1);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test CheckToken
        /// </summary>
        [Test]
        public void CheckTokenTest()
        {
            var userToken = "12d094c0b6294f7f9bdbfcf0d2f6c64b";
            TokenRequest tokenInfo = new TokenRequest(Token: userToken);

            var response = instance.CheckToken(tokenInfo);

            Assert.IsNotNull(response);
            Assert.AreEqual("Valid token", response.Data.Message);
        }

        /// <summary>
        /// Test RefreshToken
        /// </summary>
        [Test]
        [Ignore]
        public void RefreshTokenTest()
        {
            // TODO: add unit test for the method 'RefreshToken'
            string grantType = null; // TODO: replace null with proper value
            string refreshToken = null; // TODO: replace null with proper value

            var response = instance.RefreshToken(grantType, refreshToken);
        }

    }

}