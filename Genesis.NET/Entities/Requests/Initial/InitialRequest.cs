using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Serialization;
using Genesis.Net.Common;
using Genesis.Net.Validations;

namespace Genesis.Net.Entities.Requests.Initial
{
    public abstract class InitialRequest : ProcessRequest
    {
        [XmlElement(ElementName = "moto")]
        public bool? Moto { get; set; }

        public bool ShouldSerializeMoto()
        {
            return Moto.HasValue;
        }

        [StringLength(255)]
        [Required]
        [XmlElement(ElementName = "card_holder")]
        public string CardHolder { get; set; }

        [Range(Constants.MinMonthValue, Constants.MaxMonthValue)]
        [Required]
        [XmlIgnore]
        public int ExpirationMonth { get; set; }

        [XmlElement(ElementName = "expiration_month")]
#if GenerateXmlSerializers
        public string ProxyExpirationMonth
#else
        internal string ProxyExpirationMonth
#endif
        {
            get
            {
                return Formatter.FormatMonthToString(ExpirationMonth);
            }
            set
            {
                ExpirationMonth = Formatter.FormatStringToMonth(value);
            }
        }

        [Range(Constants.MinYearValue, Constants.MaxYearValue)]
        [Required]
        [XmlIgnore]
        public int ExpirationYear { get; set; }

        [XmlElement(ElementName = "expiration_year")]
        public string ProxyExpirationYear
        {
            get
            {
                return Formatter.FormatYearToString(ExpirationYear);
            }
            set
            {
                ExpirationYear = Formatter.FormatStringToYear(value);
            }
        }

        [EmailAddress]
        [XmlElement(ElementName = "customer_email")]
        public string CustomerEmail { get; set; }

        [StringLength(32)]
        [XmlElement(ElementName = "customer_phone")]
        public string CustomerPhone { get; set; }

        [CreditCard]
        [Required]
        [XmlElement(ElementName = "card_number")]
        public string CardNumber { get; set; }

        [StringLength(Constants.MaxCvvCodeLength, MinimumLength = Constants.MinCvvCodeLength)]
        [XmlElement(ElementName = "cvv")]
        public string Cvv { get; set; }

        [XmlElement(ElementName = "billing_address")]
        public Address BillingAddress { get; set; }

        [XmlElement(ElementName = "shipping_address")]
        public Address ShippingAddress { get; set; }
    }
}