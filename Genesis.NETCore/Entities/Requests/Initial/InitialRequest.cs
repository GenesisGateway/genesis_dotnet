using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Genesis.NetCore.Common;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    public abstract class InitialRequest : ProcessRequest
    {
        private string expirationMonth;

        [XmlElement(ElementName = "moto")]
        public bool? Moto { get; set; }

        public bool ShouldSerializeMoto()
        {
            return Moto.HasValue;
        }

        [XmlIgnore]
        public bool ClientSideEncryption { get; set; } = false;

        [StringLengthOnPropertyValue(nameof(ClientSideEncryption), false, 255)]
        [Required]
        [XmlElement(ElementName = "card_holder")]
        public string CardHolder { get; set; }

        [RangeOnPropertyValue(nameof(ClientSideEncryption), false, Constants.MinMonthValue, Constants.MaxMonthValue)]
        [Required]
        [XmlElement(ElementName = "expiration_month")]
        public string ExpirationMonth
        {
            get
            {
                return expirationMonth;
            }
            set
            {
                if (value!= null && value.Length == 1)
                {
                    expirationMonth = string.Concat("0", value);
                }
                else
                {
                    expirationMonth = value;
                }
            }
        }

        [RangeOnPropertyValue(nameof(ClientSideEncryption), false, Constants.MinYearValue, Constants.MaxYearValue)]
        [Required]
        [XmlElement(ElementName = "expiration_year")]
        public string ExpirationYear { get; set; }

        [EmailAddress]
        [XmlElement(ElementName = "customer_email")]
        public string CustomerEmail { get; set; }

        [StringLength(32)]
        [XmlElement(ElementName = "customer_phone")]
        public string CustomerPhone { get; set; }

        [CreditCardOnPropertyValue(nameof(ClientSideEncryption), false)]
        [Required]
        [XmlElement(ElementName = "card_number")]
        public string CardNumber { get; set; }

        [StringLengthOnPropertyValue(nameof(ClientSideEncryption), false, Constants.MaxCvvCodeLength, Constants.MinCvvCodeLength)]
        [XmlElement(ElementName = "cvv")]
        public string Cvv { get; set; }

        [XmlElement(ElementName = "billing_address")]
        public Address BillingAddress { get; set; }

        [XmlElement(ElementName = "shipping_address")]
        public Address ShippingAddress { get; set; }
    }
}