using System.Linq;
using System.Net;
using Genesis.NetCore.Entities.Requests;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs
{
    [TestClass]
    public class GenesisClientUrlSpecs
    {
        private static readonly Request[] requestsWithSmartRoutingRequests = new Request[]
        {
            RequestMocksFactory.CreateValidAuthorize().Instance,
            RequestMocksFactory.CreateValidSale().Instance,
            RequestMocksFactory.CreateValidPayout().Instance,
            RequestMocksFactory.CreateValidFrictionless3dv2With3dSecure().Instance,
            RequestMocksFactory.CreateValidChallenge3dv2With3dSecure().Instance,
        };

        private static readonly Request[] requestsWithoutSmartRoutingRequests = new Request[]
        {
            RequestMocksFactory.CreateValidCredit().Instance,
            RequestMocksFactory.CreateValidWpfCreate().Instance,
            RequestMocksFactory.CreateValidWpfReconcile().Instance,
            RequestMocksFactory.CreateValidSingleReconcile().Instance,
            RequestMocksFactory.CreateValidRefund().Instance,
            RequestMocksFactory.CreateValidCapture().Instance,
        };

        private static readonly string[] SmartRoutingAccceptHeaders = new string[]
        {
            "text/xml",
            "application/xml"
        };

        [TestMethod]
        [DataRow(Environments.Staging, Endpoints.eMerchantPay, true, "text/xml")]
        [DataRow(Environments.Staging, Endpoints.eMerchantPay, false, "text/xml")]
        [DataRow(Environments.Production, Endpoints.eMerchantPay, false, "text/xml")]
        [DataRow(Environments.Staging, Endpoints.EComProcessing, false, "text/xml")]
        [DataRow(Environments.Production, Endpoints.EComProcessing, false, "text/xml")]
        [DataRow(Environments.Production, Endpoints.eMerchantPay, true, "text/xml")]
        [DataRow(Environments.Staging, Endpoints.EComProcessing, true, "text/xml")]
        [DataRow(Environments.Production, Endpoints.EComProcessing, true, "text/xml")]
        public void UrlIsComposedCorrectlyForSmartRoutingRequests(Environments environment, Endpoints endpoint, bool useSmartRouting, string contentType)
        {
            var configuration = new Configuration(
                    environment: environment,
                    terminalToken: "TestToken",
                    apiLogin: string.Empty,
                    apiPassword: string.Empty,
                    endpoint: endpoint,
                    useSmartRouting: useSmartRouting);

            var genesisClient = (GenesisClient)SpecHelper.CreateGenesisClient(configuration, false);

            foreach (var exampleRequest in requestsWithSmartRoutingRequests)
            {
                var webRequest = (HttpWebRequest)genesisClient.CreateWebRequest(exampleRequest);
                string expectedUrl = this.GetExpectedUrl(useSmartRouting, configuration, exampleRequest);

                Assert.AreEqual(expectedUrl, webRequest.RequestUri.ToString(), $"{exampleRequest.GetType().Name} has wrong URL.");
                Assert.AreEqual(contentType, webRequest.ContentType, $"{exampleRequest.GetType().Name} has wrong ContentType.");
                if (useSmartRouting)
                {
                    Assert.IsTrue(webRequest.Headers.AllKeys.Contains("Accept"), $"{exampleRequest.GetType().Name} has no Accept header.");
                    Assert.IsTrue(SmartRoutingAccceptHeaders.Contains(webRequest.Headers["Accept"]), $"{exampleRequest.GetType().Name} has wrong Accept header.");
                }

            }
        }

        [TestMethod]
        [DataRow(Environments.Staging, Endpoints.eMerchantPay, false, "text/xml")]
        [DataRow(Environments.Production, Endpoints.eMerchantPay, false, "text/xml")]
        [DataRow(Environments.Staging, Endpoints.EComProcessing, false, "text/xml")]
        [DataRow(Environments.Production, Endpoints.EComProcessing, false, "text/xml")]
        [DataRow(Environments.Staging, Endpoints.eMerchantPay, true, "text/xml")]
        [DataRow(Environments.Production, Endpoints.eMerchantPay, true, "text/xml")]
        [DataRow(Environments.Staging, Endpoints.EComProcessing, true, "text/xml")]
        [DataRow(Environments.Production, Endpoints.EComProcessing, true, "text/xml")]
        public void UrlIsComposedCorrectlyForNotSmartRoutingRequests(Environments environment, Endpoints endpoint, bool useSmartRouting, string contentType)
        {
            var configuration = new Configuration(
                    environment: environment,
                    terminalToken: "TestToken",
                    apiLogin: string.Empty,
                    apiPassword: string.Empty,
                    endpoint: endpoint,
                    useSmartRouting: useSmartRouting);

            var genesisClient = (GenesisClient)SpecHelper.CreateGenesisClient(configuration, false);

            foreach (var exampleRequest in requestsWithoutSmartRoutingRequests)
            {
                var request = genesisClient.CreateWebRequest(exampleRequest);
                string expectedUrl = this.GetExpectedUrl(false, configuration, exampleRequest);

                Assert.AreEqual(expectedUrl, request.RequestUri.ToString(), $"{exampleRequest.GetType().Name} has wrong URL.");
                Assert.AreEqual(contentType, request.ContentType, $"{exampleRequest.GetType().Name} has wrong ContentType.");
            }
        }

        private string GetExpectedUrl(bool useSmartRouting, Configuration configuration, Request exampleRequest)
        {
            string expectedUrl;
            if (useSmartRouting)
            {
                expectedUrl = string.Format("https://{0}.{1}.{2}/{3}/", configuration.Environment == Environments.Production ? "prod" : "staging", "api", configuration.getEndpointURL(), "transactions");
            }
            else
            {
                if (configuration.Environment == Environments.Production)
                {
                    expectedUrl = string.Format("https://{0}.{1}/{2}/", exampleRequest.SubDomain, configuration.getEndpointURL(), exampleRequest.ApiPath);
                }
                else
                {
                    expectedUrl = string.Format("https://{0}.{1}.{2}/{3}/", "staging", exampleRequest.SubDomain, configuration.getEndpointURL(), exampleRequest.ApiPath);
                }

                if (exampleRequest.AppendTerminalToken)
                {
                    expectedUrl += configuration.TerminalToken;
                }
            }

            return expectedUrl;
        }
    }
}
