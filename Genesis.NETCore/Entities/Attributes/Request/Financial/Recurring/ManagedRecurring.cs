using Genesis.NetCore.Entities.Enums.ManagedRecurring;
using Genesis.NetCore.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Attributes.Request.Financial.Recurring
{
    [Serializable]
    [XmlRoot(ElementName = "managed_recurring", Namespace = null)]
    public class ManagedRecurring : IEntity
    {
        // For Standard Managed Recurring AND Indian Cards
        [Required]
        [XmlElement(ElementName = "mode")]
        public Mode Mode { get; set; }

        // For Standard Managed Recurring
        [Required]
        [StringLength(6)]
        [XmlElement(ElementName = "interval")]
        public Interval Interval { get; set; }

        // For Standard Managed Recurring
        [StringLength(10)]
        [XmlElement(ElementName = "first_date")]
        public string FirstDate { get; set; }

        // For Standard Managed Recurring       
        private int? _TimeOfDay;
        [XmlElement(ElementName = "time_of_day")]
        public int? TimeOfDay
        {
            get { return _TimeOfDay; }
            set
            {
                _TimeOfDay = value > 0 ? value : null;
            }
        }

        public bool ShouldSerializeTimeOfDay() { return _TimeOfDay != null; }

        // For Standard Managed Recurring
        private int? _Period;
        [XmlElement(ElementName = "period")]
        public int? Period
        {
            get { return _Period; }
            set
            {
                _Period = value > 0 ? value : null;
            }
        }

        public bool ShouldSerializePeriod() { return _Period != null; }

        [XmlElement(ElementName = "amount")]
        public int Amount { get; set; }

        public bool ShouldSerializeAmount() { return Amount > 0; }

        // For Standard Managed Recurring AND Indian Cards
        [XmlElement(ElementName = "max_count")]
        public int MaxCount { get; set; }

        // For Indian Cards
        [XmlElement(ElementName = "payment_type")]
        public PaymentType? PaymentType { get; set; }
        public bool ShouldSerializePaymentType() { return PaymentType != null; }

        // For Indian Cards
        [XmlElement(ElementName = "amount_type")]
        public AmountType? AmountType { get; set; }

        public bool ShouldSerializeAmountType() { return AmountType != null; }

        // For Indian Cards
        [XmlElement(ElementName = "frequency")]
        public Frequency? Frequency { get; set; }

        public bool ShouldSerializeFrequency() { return Frequency != null; }

        // For Indian Cards
        [StringLength(35)]
        [XmlElement(ElementName = "registration_reference_number")]
        public string RegistrationReferenceNumber { get; set; }
       
        [XmlElement(ElementName = "max_amount")]
        public int MaxAmount { get; set; }

        public bool ShouldSerializeMaxAmount() { return MaxAmount > 0; }

        // For Indian Cards
        [XmlElement(ElementName = "validated")]
        public bool? Validated { get; set; }

        public bool ShouldSerializeValidated() { return Validated != null; }
    }
}