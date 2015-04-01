using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Serialization;
using Genesis.Net.Common;
using Genesis.Net.Validations;
using DataAnnotations = DataAnnotationsExtensions;

namespace Genesis.Net.Entities.Requests.Initial
{
    [XmlRoot("wpf_payment", Namespace = "WpfCreate")]
    public class WpfCreate : Wpf
    {
        private readonly Money money = new Money();

        public override string ApiPath
        {
            get
            {
                return String.Format("{0}/wpf", Locale.ToApiPathName());
            }
        }

        [XmlIgnore]
        public WpfLocales Locale { get; set; }

        [Required]
        [XmlElement(ElementName = "transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Represents the amount of money in major currency units
        /// </summary>
        [MoneyRange]
        [Required]
        [XmlIgnore]
        public decimal Amount
        {
            get { return money.MajorAmount; }
            set { money.MajorAmount = value; }
        }

        [XmlElement(ElementName = "amount")]
#if GenerateXmlSerializers
        public string ProxyAmount
#else
        internal string ProxyAmount
#endif
        {
            get { return money.MinorAmount.ToString(); }
            set { money.NativeAmount = value; }
        }

        [Required]
        [XmlElement(ElementName = "currency")]
        public Iso4217CurrencyCodes Currency
        {
            get { return money.CurrencyCode; }
            set { money.CurrencyCode = value; }
        }

        [StringLength(255)]
        [Required]
        [XmlElement(ElementName = "usage")]
        public string Usage { get; set; }

        [Required]
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [EmailAddress]
        [XmlElement(ElementName = "customer_email")]
        public string CustomerEmail { get; set; }

        [StringLength(32)]
        [XmlElement(ElementName = "customer_phone")]
        public string CustomerPhone { get; set; }

        [DataAnnotations.Url(DataAnnotations.UrlOptions.OptionalProtocol)]
        [Required]
        [XmlElement(ElementName = "notification_url")]
        public string NotificationUrl { get; set; }

        [DataAnnotations.Url(DataAnnotations.UrlOptions.OptionalProtocol)]
        [Required]
        [XmlElement(ElementName = "return_success_url")]
        public string ReturnSuccessUrl { get; set; }

        [DataAnnotations.Url(DataAnnotations.UrlOptions.OptionalProtocol)]
        [Required]
        [XmlElement(ElementName = "return_failure_url")]
        public string ReturnFailureUrl { get; set; }

        [DataAnnotations.Url(DataAnnotations.UrlOptions.OptionalProtocol)]
        [Required]
        [XmlElement(ElementName = "return_cancel_url")]
        public string ReturnCancelUrl { get; set; }

        [Required]
        [XmlElement(ElementName = "billing_address")]
        public Address BillingAddress { get; set; }

        [XmlElement(ElementName = "shipping_address")]
        public Address ShippingAddress { get; set; }

        [Required]
        [XmlIgnore]
        public TransactionTypes[] TransactionTypes { get; set; }

        [XmlArray(ElementName = "transaction_types")]
        [XmlArrayItem(ElementName = "transaction_type")]
#if GenerateXmlSerializers
        public string[] ProxyTransactionTypes
#else
        internal string[] ProxyTransactionTypes
#endif
        {
            get
            {
                if (TransactionTypes != null)
                {
                    return TransactionTypes.Select(t => t.Name).ToArray();
                }
                return null;
            }
            set
            {
                if (value != null)
                {
                    TransactionTypes = value.Select(name => Genesis.Net.TransactionTypes.TransactionTypesByName.Value[name]).ToArray();
                }
                else
                {
                    TransactionTypes = null;
                }
            }
        }

        [XmlElement(ElementName = "risk_params")]
        public RiskParams RiskParams { get; set; }
    }
}