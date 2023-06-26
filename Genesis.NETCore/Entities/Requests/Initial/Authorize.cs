using Genesis.NetCore.Entities.Attributes.Request.Financial.Recurring;
using Genesis.NetCore.Entities.Enums.Recurring;
using Genesis.NetCore.Validations;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "Authorize")]
    public class Authorize : CardTransaction
    {
        public Authorize() : base(TransactionTypes.Authorize)
        {
        }

        [XmlElement(ElementName = "managed_recurring")]
        public ManagedRecurring ManagedRecurring { get; set; }

        [PropertyNotNull("ManagedRecurring", "managed"), PropertyNotNull("ReferenceId", "subsequent")]
        [XmlElement(ElementName = "recurring_type")]
        public RecurringType? RecurringType { get; set; }

        public bool ShouldSerializeRecurringType() { return RecurringType != null; }


        [XmlElement(ElementName = "reference_id")]
        public string ReferenceId { get; set; }
    }
}