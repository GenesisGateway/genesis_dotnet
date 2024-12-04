using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Genesis.NetCore.Common;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [SupportedValuesValidation(
        nameof(Currency),
        Iso4217CurrencyCodes.ARS,
        Iso4217CurrencyCodes.BRL,
        Iso4217CurrencyCodes.CAD,
        Iso4217CurrencyCodes.CLP,
        Iso4217CurrencyCodes.CNY,
        Iso4217CurrencyCodes.COP,
        Iso4217CurrencyCodes.IDR,
        Iso4217CurrencyCodes.INR,
        Iso4217CurrencyCodes.MYR,
        Iso4217CurrencyCodes.MXN,
        Iso4217CurrencyCodes.PEN,
        Iso4217CurrencyCodes.THB,
        Iso4217CurrencyCodes.UYU
    )]
    [XmlRoot("payment_transaction", Namespace = "BankPayout")]
    public class BankPayout : ProcessRequest
    {
        public BankPayout()
        {
            TransactionType = TransactionTypes.BankPayout;
        }

        /// <summary>
        /// URL at merchant where gateway sends outcome of transaction.
        /// </summary>
        [Required]
        [UrlAddress]
        [XmlElement(ElementName = "notification_url")]
        public string NotificationUrl { get; set; }

        /// <summary>
        /// URL where customer is sent to after successful payment
        /// </summary>
        [Required]
        [UrlAddress]
        [XmlElement(ElementName = "return_success_url")]
        public string ReturnSuccessUrl { get; set; }

        /// <summary>
        /// URL where customer is sent to after unsuccessful payment
        /// </summary>
        [Required]
        [UrlAddress]
        [XmlElement(ElementName = "return_failure_url")]
        public string ReturnFailureUrl { get; set; }

        /// <summary>
        /// Name of the bank. If specified, it must be one of the supported Bank Names
        /// </summary>
        [XmlElement(ElementName = "bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The bank code used to process the transaction. Must be one of the supported Bank codes.
        /// </summary>
        [Required]
        [StringLength(8)]
        [XmlElement(ElementName = "bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// Must contain valid e-mail of customer
        /// </summary>
        [EmailAddress]
        [XmlElement(ElementName = "customer_email")]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// Must contain valid phone number of customer
        /// </summary>
        [StringLength(32)]
        [XmlElement(ElementName = "customer_phone")]
        public string CustomerPhone { get; set; }

        /// <summary>
        /// Name of the Bank branch
        /// </summary>
        [XmlElement(ElementName = "bank_branch")]
        public string BankBranch { get; set; }

        /// <summary>
        /// Bank account name is required, for CNY currency and should be in Simplified Chinese. For other currency, must be in English Language.
        /// </summary>
        [XmlElement(ElementName = "bank_account_name")]
        public string BankAccountName { get; set; }

        /// <summary>
        /// Bank account number of the customer.
        /// </summary>
        [XmlElement(ElementName = "bank_account_number")]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Name of the province that the bank is located.
        /// </summary>
        [XmlElement(ElementName = "bank_province")]
        public string BankProvince { get; set; }

        /// <summary>
        /// ID card number.
        /// </summary>
        [XmlElement(ElementName = "id_card_number")]
        public string IdCardNumber { get; set; }

        /// <summary>
        /// Payer bank phone number
        /// </summary>
        [StringLength(11)]
        [XmlElement(ElementName = "payer_bank_phone_number")]
        public string PayerBankPhoneNumber { get; set; }

        /// <summary>
        /// The type of account. C: for Checking accounts S: for Savings accounts M: for Maestra accounts(Only Peru) P: for Payment accounts
        /// </summary>
        [XmlElement(ElementName = "bank_account_type")]
        public BankAccountType? BankAccountType { get; set; }

        /// <summary>
        /// Verifier digit. Given by external provider, used to verify transaction.
        /// </summary>
        [MaxLength(1)]
        [XmlElement(ElementName = "bank_account_verification_digit")]
        public string BankAccountVerificationDigit { get; set; }

        /// <summary>
        /// ID card/document type
        /// </summary>
        [MaxLength(10)]
        [XmlElement(ElementName = "document_type")]
        public string DocumentType { get; set; }

        /// <summary>
        /// Unique account identifier in Trustly's system. You will receive this after Select Account call and after Trustly Sale on the notification URL.
        /// </summary>
        [MaxLength(255)]
        [XmlElement(ElementName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Unique user identifier defined by merchant in their own system. ID, username, hash or anything uniquely identifying the consumer requesting the deposit. Must be static per each consumer for any type of transaction where this consumer is involved (trustly_sale, bank pay_out, register_account, select account).
        /// </summary>
        [MaxLength(255)]
        [XmlElement(ElementName = "user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Required for Visa only when MCC is a Financial Services one (e.g. MCC 6012)
        /// </summary>
        [XmlIgnore]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// dd-mm-yyyy - <see cref="BirthDate"/>
        /// </summary>
        [XmlElement(ElementName = "birth_date")]
        public string BirthDateMetadata
        {
            get
            {
                return BirthDate?.Date.ToApiDate();
            }

            set
            {
                BirthDate = value?.ParseApiDate();
            }
        }

        /// <summary>
        /// Bank payout subtype.
        /// </summary>
        [XmlElement(ElementName = "payment_type")]
        public BankPayoutSubtype? PaymentType { get; set; }

        /// <summary>
        /// Company type of the customer. For Legal Person.
        /// </summary>
        [MaxLength(255)]
        [XmlElement(ElementName = "company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// Company activity of the customer. For Legal Person.
        /// </summary>
        [MaxLength(255)]
        [XmlElement(ElementName = "company_activity")]
        public string CompanyActivity { get; set; }

        /// <summary>
        /// The incorporation date of the customer. For Legal Person.
        /// </summary>
        [XmlIgnore]
        public DateTime? IncorporationDate { get; set; }

        /// <summary>
        /// dd-mm-yyyy - <see cref="IncorporationDate"/>
        /// </summary>
        [XmlElement(ElementName = "incorporation_date")]
        public string IncorporationDateMetadata
        {
            get
            {
                return IncorporationDate?.Date.ToApiDate();
            }

            set
            {
                IncorporationDate = value?.ParseApiDate();
            }
        }

        /// <summary>
        /// Mother's name of the customer.
        /// </summary>
        [MaxLength(255)]
        [XmlElement(ElementName = "mothers_name")]
        public string MothersName { get; set; }

        /// <summary>
        /// PIX key of the customer.
        /// </summary>
        [MaxLength(255)]
        [XmlElement(ElementName = "pix_key")]
        public string PixKey { get; set; }


        [XmlElement(ElementName = "billing_address")]
        public Address BillingAddress { get; set; }
    }
}
