using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs
{
    [TestClass]
    public class GatewayPingSpecs
    {
        public const string GATE_SUBBDOMAIN = "gate";
        public const string WPF_SUBBDOMAIN = "wpf";

        public GatewayPingSpecs()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        [TestMethod]
        [DataRow(GATE_SUBBDOMAIN, Environments.Staging, Endpoints.eMerchantPay)]
        [DataRow(WPF_SUBBDOMAIN, Environments.Staging, Endpoints.eMerchantPay)]
        [DataRow(GATE_SUBBDOMAIN, Environments.Production, Endpoints.eMerchantPay)]
        [DataRow(WPF_SUBBDOMAIN, Environments.Production, Endpoints.eMerchantPay)]
        [DataRow(GATE_SUBBDOMAIN, Environments.Staging, Endpoints.EComProcessing)]
        [DataRow(WPF_SUBBDOMAIN, Environments.Staging, Endpoints.EComProcessing)]
        [DataRow(GATE_SUBBDOMAIN, Environments.Production, Endpoints.EComProcessing)]
        [DataRow(WPF_SUBBDOMAIN, Environments.Production, Endpoints.EComProcessing)]
        public void ConnectsSuccessfullyTo(string subdomain, Environments environment, Endpoints endpoint)
        {
            var config = new Configuration(
                    environment: environment,
                    terminalToken: string.Empty,
                    apiLogin: string.Empty,
                    apiPassword: string.Empty,
                    endpoint: endpoint);

            var canConnect = CanConnectTo(subdomain, config.getEndpointURL());
            Assert.IsTrue(canConnect);
        }

        private bool CanConnectTo(string subDomain, string domain)
        {
            return SpecHelper.CheckForInternetConnection(
                string.Format("https://{0}.{1}", subDomain, domain)
            );
        }
    }
}