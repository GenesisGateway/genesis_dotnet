using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "Avs")]
    public class Avs : InitialRequest
    {
        [XmlElement(ElementName = "risk_params")]
        public RiskParams RiskParams { get; set; }

        public Avs()
        {
            TransactionType = TransactionTypes.Avs;
        }
    }
}