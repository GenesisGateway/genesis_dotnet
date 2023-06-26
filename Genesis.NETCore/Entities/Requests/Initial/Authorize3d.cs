using Genesis.NetCore.Entities.Attributes.Request.Financial.Recurring;
using Genesis.NetCore.Entities.Enums.Recurring;
using Genesis.NetCore.Validations;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "Authorize3d")]
    public class Authorize3d : CardTransaction3d
    {
        public Authorize3d() : base(TransactionTypes.Authorize3d)
        {
        }

        [XmlElement(ElementName = "managed_recurring")]
        public ManagedRecurring ManagedRecurring { get; set; }

        [PropertyNotNull("ManagedRecurring", "managed")]
        [XmlElement(ElementName = "recurring_type")]
        public RecurringType? RecurringType { get; set; }

        public bool ShouldSerializeRecurringType() { return RecurringType != null; }
    }
}