/* 
 * CitrineOS Central System API
 *
 * Central System API for OCPP 2.0.1 messaging.
 *
 * OpenAPI spec version: 1.4.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ocpp.citrineos.Api;
using ocpp.citrineos.Model;
using ocpp.citrineos.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace ocpp.citrineos.Test
{
    /// <summary>
    ///  Class for testing EvdriverAuthorizationRestrictionsBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class EvdriverAuthorizationRestrictionsBodyTests
    {
        // TODO uncomment below to declare an instance variable for EvdriverAuthorizationRestrictionsBody
        //private EvdriverAuthorizationRestrictionsBody instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EvdriverAuthorizationRestrictionsBody
            //instance = new EvdriverAuthorizationRestrictionsBody();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EvdriverAuthorizationRestrictionsBody
        /// </summary>
        [Test]
        public void EvdriverAuthorizationRestrictionsBodyInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EvdriverAuthorizationRestrictionsBody
            //Assert.IsInstanceOfType<EvdriverAuthorizationRestrictionsBody> (instance, "variable 'instance' is a EvdriverAuthorizationRestrictionsBody");
        }


        /// <summary>
        /// Test the property 'AllowedConnectorTypes'
        /// </summary>
        [Test]
        public void AllowedConnectorTypesTest()
        {
            // TODO unit test for the property 'AllowedConnectorTypes'
        }
        /// <summary>
        /// Test the property 'DisallowedEvseIdPrefixes'
        /// </summary>
        [Test]
        public void DisallowedEvseIdPrefixesTest()
        {
            // TODO unit test for the property 'DisallowedEvseIdPrefixes'
        }

    }

}
