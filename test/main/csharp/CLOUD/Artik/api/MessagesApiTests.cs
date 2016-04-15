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
    ///  Class for testing MessagesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MessagesApiTests
    {
        private MessagesApi instance;
        private static readonly DateTime UnixEpoch =
          new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
          String deviceToken = "1eef3e3251e147d1ac707a57f6779c49";
          Configuration c1 = new Configuration (timeout: 10000, accessToken: deviceToken);
          instance = new MessagesApi(c1);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        public static long GetCurrentUnixTimestampMillis()
        {
            return (long) (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
        }

        /// <summary>
        /// Test SendMessageAction and GetNormalizedMessages
        /// </summary>
        [Test]
        public void SendMessageActionTest()
        {
            Dictionary<String, Object> data = new Dictionary<String, Object> {{ "volume", 5}};
            long milliseconds = GetCurrentUnixTimestampMillis();

            MessageAction message = new MessageAction (Sdid: "993925c3cd994bf7a51c620884be65e9", Type: "Message", Data: data, Ts: milliseconds);

            var response = instance.SendMessageAction(message);
            var messageId = response.Data.Mid;

            Assert.IsNotNull (messageId);

            var normalizedMessageEnvelope = instance.GetNormalizedMessages(mid: messageId);
            Assert.AreEqual(1, normalizedMessageEnvelope.Size);

            NormalizedMessage normalized = normalizedMessageEnvelope.Data[0];
            Assert.AreEqual (messageId, normalized.Mid);

            Object volume = normalized.Data["volume"];
            Assert.IsNotNull(volume);
            Assert.AreEqual(5, volume);
        }

    }

}