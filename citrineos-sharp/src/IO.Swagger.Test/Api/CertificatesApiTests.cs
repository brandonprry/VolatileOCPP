/* 
 * CitrineOS Central System API
 *
 * Central System API for OCPP 2.0.1 messaging.
 *
 * OpenAPI spec version: 1.4.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing CertificatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CertificatesApiTests
    {
        private CertificatesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CertificatesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CertificatesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CertificatesApi
            //Assert.IsInstanceOfType(typeof(CertificatesApi), instance, "instance is a CertificatesApi");
        }

        /// <summary>
        /// Test DataCertificatesSystemConfigGet
        /// </summary>
        [Test]
        public void DataCertificatesSystemConfigGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.DataCertificatesSystemConfigGet();
            
        }
        /// <summary>
        /// Test DataCertificatesSystemConfigPut
        /// </summary>
        [Test]
        public void DataCertificatesSystemConfigPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.DataCertificatesSystemConfigPut();
            
        }
        /// <summary>
        /// Test OcppCertificatesCertificateSignedPost
        /// </summary>
        [Test]
        public void OcppCertificatesCertificateSignedPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CertificatesCertificateSignedBody body = null;
            //string identifier = null;
            //string tenantId = null;
            //string callbackUrl = null;
            //instance.OcppCertificatesCertificateSignedPost(body, identifier, tenantId, callbackUrl);
            
        }
        /// <summary>
        /// Test OcppCertificatesDeleteCertificatePost
        /// </summary>
        [Test]
        public void OcppCertificatesDeleteCertificatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CertificatesDeleteCertificateBody body = null;
            //string identifier = null;
            //string tenantId = null;
            //string callbackUrl = null;
            //instance.OcppCertificatesDeleteCertificatePost(body, identifier, tenantId, callbackUrl);
            
        }
        /// <summary>
        /// Test OcppCertificatesGetInstalledCertificateIdsPost
        /// </summary>
        [Test]
        public void OcppCertificatesGetInstalledCertificateIdsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tenantId = null;
            //CertificatesGetInstalledCertificateIdsBody body = null;
            //string callbackUrl = null;
            //instance.OcppCertificatesGetInstalledCertificateIdsPost(identifier, tenantId, body, callbackUrl);
            
        }
        /// <summary>
        /// Test OcppCertificatesInstallCertificatePost
        /// </summary>
        [Test]
        public void OcppCertificatesInstallCertificatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CertificatesInstallCertificateBody body = null;
            //string identifier = null;
            //string tenantId = null;
            //string callbackUrl = null;
            //instance.OcppCertificatesInstallCertificatePost(body, identifier, tenantId, callbackUrl);
            
        }
    }

}