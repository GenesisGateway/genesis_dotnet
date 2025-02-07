﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Business;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "ApplePay")]
    public class ApplePay : ProcessRequest
    {
        public ApplePay()
        {
            TransactionType = TransactionTypes.ApplePay;
        }

        [Required]
        [XmlElement(ElementName = "payment_token")]
        public string PaymentToken { get; set; }

        [XmlElement(ElementName = "payment_subtype")]
        public TransactionSubTypes? PaymentSubtype { get; set; }

        [Required]
        [XmlIgnore]
        public TransactionSubTypes? Subtype
        {
            get
            {
                return PaymentSubtype;
            }
            set
            {
                PaymentSubtype = value;
            }
        }

        /// <summary>
        /// Specifies recurring type of the transaction. Use: <b>initial</b>
        /// </summary>
        [XmlElement(ElementName = "recurring_type")]
        public string RecurringType { get; set; }

        [XmlElement(ElementName = "birth_date")]
        public string BirthDate { get; set; }

        [XmlElement(ElementName = "document_id")]
        public string DocumentId { get; set; }

        [XmlElement(ElementName = "billing_address")]
        public Address BillingAddress { get; set; }

        [XmlElement(ElementName = "shipping_address")]
        public Address ShippingAddress { get; set; }

        [XmlElement(ElementName = "business_attributes")]
        public BusinessAttributes BusinessAttributes { get; set; }

        [EmailAddress]
        [XmlElement(ElementName = "customer_email")]
        public string CustomerEmail { get; set; }

        [StringLength(32)]
        [XmlElement(ElementName = "customer_phone")]
        public string CustomerPhone { get; set; }
    }
}
