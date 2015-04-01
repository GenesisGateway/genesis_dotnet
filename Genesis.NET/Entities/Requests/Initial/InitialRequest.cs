using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Serialization;
using Genesis.Net.Common;
using Genesis.Net.Validations;

namespace Genesis.Net.Entities.Requests.Initial
{
    public abstract class InitialRequest : Request
    {
        private readonly Money money = new Money();

        public override string ApiPath
        {
            get
            {
                return "process";
            }
        }

        [XmlIgnore]
        public TransactionTypes Type { get; set; }

        [XmlElement(ElementName = "transaction_type")]
        public string ProxyType
        {
            get
            {
                if (Type == null)
                    return string.Empty;
                else
                    return Type.ToString();
            }
            set
            {
                Type = TransactionTypes.TransactionTypesByName.Value[value];
            }
        }

        [StringLength(255)]
        [Required]
        [XmlElement(ElementName = "transaction_id")]
        public string Id { get; set; }

        [StringLength(255)]
        [XmlElement(ElementName = "usage")]
        public string Usage { get; set; }

        /// <summary>
        /// Represents the amount of money in major currency units
        /// </summary>
        [MoneyRange]
        [Required]
        [XmlIgnore]
        public decimal Amount
        {
            get
            {
                return money.MajorAmount;
            }
            set
            {
                money.MajorAmount = value;
            }
        }

        [XmlElement(ElementName = "amount")]
#if GenerateXmlSerializers
        public string ProxyAmount
#else
        internal string ProxyAmount
#endif
        {
            get
            {
                return money.MinorAmount.ToString();
            }
            set
            {
                money.NativeAmount = value;
            }
        }

        [Required]
        [XmlElement(ElementName = "currency")]
        public Iso4217CurrencyCodes Currency
        {
            get
            {
                return money.CurrencyCode;
            }
            set
            {
                money.CurrencyCode = value;
            }
        }

        [IPv4Address]
        [Required]
        [XmlElement(ElementName = "remote_ip")]
        public string RemoteIp { get; set; }

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