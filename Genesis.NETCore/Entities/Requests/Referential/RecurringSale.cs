using System.Xml.Serialization;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Business;

namespace Genesis.NetCore.Entities.Requests.Referential
{
    [XmlRoot("payment_transaction", Namespace = "RecurringSale")]
    public class RecurringSale : QuantitativeReferentialRequest
    {
        [XmlElement(ElementName = "business_attributes")]
        public BusinessAttributes BusinessAttributes { get; set; }

        public RecurringSale()
        {
            TransactionType = TransactionTypes.RecurringSale;
        }
    }
}