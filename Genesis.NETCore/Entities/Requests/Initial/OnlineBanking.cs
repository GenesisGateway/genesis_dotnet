using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Genesis.NetCore.Common;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [SupportedValuesValidation(
        nameof(Currency),
        Iso4217CurrencyCodes.AUD,
        Iso4217CurrencyCodes.BRL,
        Iso4217CurrencyCodes.CAD,
        Iso4217CurrencyCodes.CHF,
        Iso4217CurrencyCodes.CLP,
        Iso4217CurrencyCodes.CNY,
        Iso4217CurrencyCodes.COP,
        Iso4217CurrencyCodes.EUR,
        Iso4217CurrencyCodes.GBP,
        Iso4217CurrencyCodes.INR,
        Iso4217CurrencyCodes.IDR,
        Iso4217CurrencyCodes.JPY,
        Iso4217CurrencyCodes.KRW,
        Iso4217CurrencyCodes.MXN,
        Iso4217CurrencyCodes.MYR,
        Iso4217CurrencyCodes.NZD,
        Iso4217CurrencyCodes.PEN,
        Iso4217CurrencyCodes.PLN,
        Iso4217CurrencyCodes.PYG,
        Iso4217CurrencyCodes.PHP,
        Iso4217CurrencyCodes.SGD,
        Iso4217CurrencyCodes.THB,
        Iso4217CurrencyCodes.USD,
        Iso4217CurrencyCodes.UYU,
        Iso4217CurrencyCodes.VND
    )]
    [XmlRoot("payment_transaction", Namespace = "OnlineBanking")]
    public class OnlineBanking : ProcessRequest
    {
        public OnlineBanking()
        {
            TransactionType = TransactionTypes.OnlineBanking;
        }

        [Required]
        [UrlAddress]
        [XmlElement(ElementName = "return_success_url")]
        public string ReturnSuccessUrl { get; set; }

        [Required]
        [UrlAddress]
        [XmlElement(ElementName = "return_failure_url")]
        public string ReturnFailureUrl { get; set; }

        [XmlElement(ElementName = "customer_email")]
        public string CustomerEmail { get; set; }

        [StringLength(32)]
        [XmlElement(ElementName = "customer_phone")]
        public string CustomerPhone { get; set; }

        [Required]
        [StringLength(8)]
        [XmlElement(ElementName = "bank_code")]
        public string BankCode { get; set; }

        [XmlElement(ElementName = "payment_type")]
        public OnlineBankingPaymentType PaymentType { get; set; }

        [StringLength(255)]
        [XmlElement(ElementName = "document_id")]
        public string DocumentId { get; set; }

        [XmlElement(ElementName = "virtual_payment_address")]
        public string VirtualPaymentAddress { get; set; }

        [XmlElement(ElementName = "consumer_reference")]
        public string ConsumerReference { get; set; }

        [XmlElement(ElementName = "user_category")]
        public string UserCategory { get; set; }

        [XmlElement(ElementName = "auth_code")]
        public string AuthCode { get; set; }

        [XmlElement(ElementName = "billing_address")]
        public Address BillingAddress { get; set; }
    }
}
