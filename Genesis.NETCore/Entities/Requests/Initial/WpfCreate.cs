using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Genesis.NetCore.Common;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Business;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2;
using Genesis.NetCore.Entities.Requests.Referential;
using Genesis.NetCore.Validations;
using Genesis.NetCore.Entities.Enums.Recurring;

namespace Genesis.NetCore.Entities.Requests.Initial
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
        [XmlIgnore]
        public decimal Amount
        {
            get { return money.MajorAmount; }
            set { money.MajorAmount = value; }
        }

        [XmlElement(ElementName = "amount")]
        public string ProxyAmount
        {
            get { return money.MinorAmount.ToString(); }
            set { money.NativeAmount = value; }
        }

        [XmlElement(ElementName = "currency")]
        public Iso4217CurrencyCodes Currency
        {
            get { return money.CurrencyCode; }
            set { money.CurrencyCode = value; }
        }

        [StringLength(10)]
        [XmlElement(ElementName = "consumer_id")]
        public string ConsumerId { get; set; }

        [StringLength(255)]
        [XmlElement(ElementName = "usage")]
        public string Usage { get; set; }

        [Required]
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "card_holder")]
        public string CardHolder { get; set; }

        [EmailAddress]
        [XmlElement(ElementName = "customer_email")]
        public string CustomerEmail { get; set; }

        [StringLength(32)]
        [XmlElement(ElementName = "customer_phone")]
        public string CustomerPhone { get; set; }

        [UrlAddress]
        [Required]
        [XmlElement(ElementName = "notification_url")]
        public string NotificationUrl { get; set; }

        [UrlAddress]
        [Required]
        [XmlElement(ElementName = "return_success_url")]
        public string ReturnSuccessUrl { get; set; }

        [UrlAddress]
        [Required]
        [XmlElement(ElementName = "return_failure_url")]
        public string ReturnFailureUrl { get; set; }

        [UrlAddress]
        [Required]
        [XmlElement(ElementName = "return_cancel_url")]
        public string ReturnCancelUrl { get; set; }

        [XmlElement(ElementName = "billing_address")]
        public Address BillingAddress { get; set; }

        [XmlElement(ElementName = "shipping_address")]
        public Address ShippingAddress { get; set; }

        [XmlArray(ElementName = "transaction_types")]
        [XmlArrayItem(ElementName = "transaction_type")]
        public Composite[] TransactionTypes { get; set; }

        [XmlElement(ElementName = "remember_card")]
        public string RememberCard { get; set; }

        private int? _Lifetime;
        [XmlElement(ElementName = "lifetime")]
        public int? Lifetime
        {
            get { return _Lifetime; }
            set
            {
                _Lifetime = value > 0 ? value : null;
            }
        }

        [XmlElement(ElementName = "risk_params")]
        public RiskParams RiskParams { get; set; }

        [XmlElement(ElementName = "dynamic_descriptor_params")]
        public DynamicDescriptor DynamicDescriptorParams { get; set; }

        [XmlElement(ElementName = "business_attributes")]
        public BusinessAttributes BusinessAttributes { get; set; }        

        [XmlElement(ElementName = "recurring_type")]
        public RecurringType? RecurringType { get; set; }

        public bool ShouldSerializeRecurringType() { return RecurringType != null; }

        /// <summary>
        /// 3DSv2 async parameters. They must be submitted in order to use the 3DSv2 authentication protocol in asynchronous workflow.
        /// </summary>
        [XmlElement(ElementName = "threeds_v2_params")]
        public ThreeDSv2 ThreeDSv2 { get; set; }

        [XmlElement(ElementName = "pay_later")]
        public string PayLater { get; set; }

        [XmlElement(ElementName = "reminder_language")]
        public WpfLocales ReminderLanguage { get; set; }

        [XmlArray("reminders")]
        [XmlArrayItem(typeof(Reminder), ElementName = "reminder")]
        public List<Reminder> Reminders { get; set; }

        /// <summary>
        /// An exemption from Strong Customer Authentication (SCA) can be requested by submitting an exemption with <code>low_risk</code> under SCA params.
        /// In case the issuer accepts the exemption, a step up in the authentication flow might not be required because the transaction's risk analysis has already been performed by acquirer.
        /// Note, the requested exemption might not be accepted due to internal risk validations.
        /// For example, to be able to utilize the low risk exemption, the BIN country of the card must be part of the European Economic Area (EEA).
        /// Furthermore, the acquirer could accept the merchant low-risk exemption request only if the transaction amount does not exceed the acquirer low-risk exemption threshold.
        /// Finally, the ACS might not acknowledge the merchant/acquirer's exemption request and may still require a step up in the cardholder authentication.
        /// </summary>
        [XmlElement(ElementName = "sca_params")]
        public Sca Sca { get; set; }

        [XmlElement(ElementName = "web_payment_form_id")]
        public string WebPaymentFormId { get; set; }
    }
}