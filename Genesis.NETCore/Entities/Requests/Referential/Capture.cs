using System.Xml.Serialization;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Business;

namespace Genesis.NetCore.Entities.Requests.Referential
{
    [XmlRoot("payment_transaction", Namespace = "Capture")]
    public class Capture : QuantitativeReferentialRequest
    {
        public Capture()
        {
            TransactionType = TransactionTypes.Capture;
        }

        [XmlElement(ElementName = "business_attributes")]
        public BusinessAttributes BusinessAttributes { get; set; }
    }
}