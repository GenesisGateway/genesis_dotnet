using System;
using System.Text;

namespace Genesis.NetCore
{
    public class Configuration
    {
        public readonly Environments Environment;
        public readonly string TerminalToken;
        public readonly string ApiLogin;
        public readonly string ApiPassword;
        public readonly Endpoints Endpoint;

        private string authorization;

        public string Authorization
        {
            get
            {
                if (string.IsNullOrEmpty(authorization))
                {
                    string authInfo = String.Format("{0}:{1}", ApiLogin, ApiPassword);
                    authorization = String.Format("Basic {0}", Convert.ToBase64String(Encoding.Default.GetBytes(authInfo)));
                }
                return authorization;
            }
        }

        public Configuration(Environments environment, string terminalToken, string apiLogin, string apiPassword, Endpoints endpoint)
        {
            Environment = environment;
            TerminalToken = terminalToken;
            ApiLogin = apiLogin;
            ApiPassword = apiPassword;
            Endpoint = endpoint;
        }

        public string getEndpointURL()
        {
            switch (Endpoint)
            {
                case Endpoints.eMerchantPay:
                    return "emerchantpay.net";
                case Endpoints.EComProcessing:
                    return "e-comprocessing.net";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
