using System;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "AccountVerification")]
    public class AccountVerification : InitialRequest
    {
        [XmlElement(ElementName="risk_params")]
        public RiskParams RiskParams { get; set; }

        public AccountVerification()
        {
            Type = TransactionTypes.AccountVerification;
        }
    }
}
