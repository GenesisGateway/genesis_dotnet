using Genesis.Net.Entities.Attributes.Request.Financial.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "ApplePay")]
    public class ApplePay : ProcessRequest
    {
        public ApplePay()
        {
            Type = TransactionTypes.ApplePay;
        }

        [Required]
        [XmlElement(ElementName = "payment_token")]
        public string PaymentToken { get; set; }

        [Required]
        [XmlIgnore]
        public TransactionSubTypes Subtype { get; set; }

        [XmlElement(ElementName = "payment_subtype")]
        public string PaymentSubtype
        {
            get
            {
                if (Subtype == null)
                    return string.Empty;
                else
                    return Subtype.ToString();
            }
            set
            {
                Subtype = TransactionSubTypes.TransactionTypesByName.Value[value];
            }
        }

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
