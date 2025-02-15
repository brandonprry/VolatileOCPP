/* 
 * MaEVe CSMS
 *
 * Internal API to interact with the MaEVe CSMS, external clients should use OCPI.
 *
 * OpenAPI spec version: 0.0.0
 * Contact: maeve-team@thoughtworks.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ocpp.maeve.Api;
using ocpp.maeve.Model;
using ocpp.maeve.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace ocpp.maeve.Test
{
    /// <summary>
    ///  Class for testing Registration
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RegistrationTests
    {
        // TODO uncomment below to declare an instance variable for Registration
        //private Registration instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Registration
            //instance = new Registration();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Registration
        /// </summary>
        [Test]
        public void RegistrationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Registration
            //Assert.IsInstanceOfType<Registration> (instance, "variable 'instance' is a Registration");
        }


        /// <summary>
        /// Test the property 'Token'
        /// </summary>
        [Test]
        public void TokenTest()
        {
            // TODO unit test for the property 'Token'
        }
        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Test]
        public void UrlTest()
        {
            // TODO unit test for the property 'Url'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }

    }

}
