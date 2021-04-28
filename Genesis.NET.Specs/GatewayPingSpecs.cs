using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using NSpec;

namespace Genesis.Net.Specs
{
    class GatewayPingSpecs : nspec
    {
        public const string GATE_SUBBDOMAIN = "gate";
        public const string WPF_SUBBDOMAIN  = "wpf";

        public GatewayPingSpecs()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public void describe_gateway_ping()
        {
            context["when connecting to emerchantpay Staging Gateway"] = () =>
            {
                Configuration empStagingConfig = new Configuration(
                    environment:   Environments.Staging,
                    terminalToken: string.Empty,
                    apiLogin:      string.Empty,
                    apiPassword:   string.Empty,
                    endpoint:      Endpoints.eMerchantPay
                );

                it["connects successfully to the gateway"] = () =>
                {
                    bool canConnect = CanConnectTo(GATE_SUBBDOMAIN, empStagingConfig.getEndpointURL());

                    canConnect.should_be_true();
                };

                it["connects successfully to the web payment form"] = () =>
                {
                    bool canConnect = CanConnectTo(WPF_SUBBDOMAIN, empStagingConfig.getEndpointURL());

                    canConnect.should_be_true();
                };
            };

            context["when connecting to emerchantpay Production Gateway"] = () =>
            {
                Configuration empProdConfig = new Configuration(
                    environment:   Environments.Production,
                    terminalToken: string.Empty,
                    apiLogin:      string.Empty,
                    apiPassword:   string.Empty,
                    endpoint:      Endpoints.eMerchantPay
                );

                it["connects successfully to the gateway"] = () =>
                {
                    bool canConnect = CanConnectTo(GATE_SUBBDOMAIN, empProdConfig.getEndpointURL());

                    canConnect.should_be_true();
                };

                it["connects successfully to the web payment form"] = () =>
                {
                    bool canConnect = CanConnectTo(WPF_SUBBDOMAIN, empProdConfig.getEndpointURL());

                    canConnect.should_be_true();
                };
            };

            context["when connecting to E-ComProcessing Staging Gateway"] = () =>
            {
                Configuration ecpStagingConfig = new Configuration(
                    environment:   Environments.Staging,
                    terminalToken: string.Empty,
                    apiLogin:      string.Empty,
                    apiPassword:   string.Empty,
                    endpoint:      Endpoints.EComProcessing
                );

                it["connects successfully to the gateway"] = () =>
                {
                    bool canConnect = CanConnectTo(GATE_SUBBDOMAIN, ecpStagingConfig.getEndpointURL());

                    canConnect.should_be_true();
                };

                it["connects successfully to the web payment form"] = () =>
                {
                    bool canConnect = CanConnectTo(WPF_SUBBDOMAIN, ecpStagingConfig.getEndpointURL());

                    canConnect.should_be_true();
                };
            };

            context["when connecting to E-ComProcessing Production Gateway"] = () =>
            {
                Configuration ecpProdConfig = new Configuration(
                    environment:   Environments.Production,
                    terminalToken: string.Empty,
                    apiLogin:      string.Empty,
                    apiPassword:   string.Empty,
                    endpoint:      Endpoints.EComProcessing
                );

                it["connects successfully to the gateway"] = () =>
                {
                    bool canConnect = CanConnectTo(GATE_SUBBDOMAIN, ecpProdConfig.getEndpointURL());

                    canConnect.should_be_true();
                };

                it["connects successfully to the web payment form"] = () =>
                {
                    bool canConnect = CanConnectTo(WPF_SUBBDOMAIN, ecpProdConfig.getEndpointURL());

                    canConnect.should_be_true();
                };
            };
        }

        private bool CanConnectTo(string subDomain, string domain)
        {
            return SpecHelper.CheckForInternetConnection(
                String.Format("https://{0}.{1}", subDomain, domain)
            );
        }
    }
}