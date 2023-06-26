using System.Xml.Serialization;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Business;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Recurring;
using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Entities.Requests.Referential
{
    [XmlRoot("payment_transaction", Namespace = "RecurringSale")]
    public class RecurringSale : QuantitativeReferentialRequest
    {
        [XmlElement(ElementName = "business_attributes")]
        public BusinessAttributes BusinessAttributes { get; set; }

        [XmlElement(ElementName = "managed_recurring")]
        public ManagedRecurring ManagedRecurring { get; set; }

        public RecurringSale()
        {
            TransactionType = TransactionTypes.RecurringSale;
        }
    }
}