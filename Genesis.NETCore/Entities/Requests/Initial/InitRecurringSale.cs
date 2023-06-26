using Genesis.NetCore.Entities.Attributes.Request.Financial.Recurring;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "InitRecurringSale")]
    public class InitRecurringSale : CardTransaction
    {
        public InitRecurringSale() : base(TransactionTypes.InitRecurringSale)
        {
        }

        [XmlElement(ElementName = "managed_recurring")]
        public ManagedRecurring ManagedRecurring { get; set; }
    }
}
