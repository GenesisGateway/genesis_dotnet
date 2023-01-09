using System;
using System.Xml.Serialization;
using Genesis.NetCore.Common;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums;

namespace Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2
{
    /// <summary>
    /// Cardholder account additional information. They are all optional, but recommended, because they have a significant impact on approval rates.
    /// </summary>
    [XmlRoot(ElementName = "card_holder_account")]
    public partial class CardHolderAccount : IEntity
    {
        /// <summary>
        /// Used for serialization. To set value use field <see cref="CreationDate"/>.
        /// </summary>
        [XmlElement(ElementName = "creation_date")]
        public string CreationDateMetadata
        {
            get
            {
                return CreationDate.Date.ToApiDate();
            }

            set
            {
                CreationDate = value.ParseApiDate();
            }
        }

        /// <summary>
        /// Date that the cardholder opened the account with the 3DS Requester.
        /// </summary>
        [XmlIgnore]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Length of time since the cardholder’s account information with the 3DS Requestor was last changed. Includes Billing or Shipping address, new payment account, or new user(s) added.
        /// </summary>
        [XmlElement(ElementName = "update_indicator")]
        public UpdateIndicators UpdateIndicator { get; set; }

        /// <summary>
        /// Used for serialization. To set value use field <see cref="LastChangeDate"/>.
        /// </summary>
        [XmlElement(ElementName = "last_change_date")]
        public string LastChangeDateMetadata
        {
            get
            {
                return LastChangeDate.Date.ToApiDate();
            }

            set
            {
                LastChangeDate = value.ParseApiDate();
            }
        }

        /// <summary>
        /// Date that the cardholder’s account with the 3DS Requestor was last changed. Including Billing or Shipping address, new payment account, or new user(s) added.
        /// </summary>
        [XmlIgnore]
        public DateTime LastChangeDate { get; set; }

        /// <summary>
        /// Length of time since the cardholder account with the 3DS Requestor had a password change or account reset.
        /// </summary>
        [XmlElement(ElementName = "password_change_indicator")]
        public PasswordChangeIndicators PasswordChangeIndicator { get; set; }

        /// <summary>
        /// Used for serialization. To set value use field <see cref="PasswordChangeDate"/>.
        /// </summary>
        [XmlElement(ElementName = "password_change_date")]
        public string PasswordChangeDateMetadata
        {
            get
            {
                return PasswordChangeDate.Date.ToApiDate();
            }

            set
            {
                PasswordChangeDate = value.ParseApiDate();
            }
        }

        /// <summary>
        /// Date that cardholder’s account with the 3DS Requestor had a password change or account reset.
        /// </summary>
        [XmlIgnore]
        public DateTime PasswordChangeDate { get; set; }

        /// <summary>
        /// Indicates when the shipping address used for this transaction was first used with the 3DS Requestor.
        /// </summary>
        [XmlElement(ElementName = "shipping_address_usage_indicator")]
        public ShippingAddressUsageIndicators ShippingAddressUsageIndicator { get; set; }

        /// <summary>
        /// Used for serialization. To set value use field <see cref="ShippingAddressDateFirstUsed"/>.
        /// </summary>
        [XmlElement(ElementName = "shipping_address_date_first_used")]
        public string ShippingAddressDateFirstUsedMetadata
        {
            get
            {
                return ShippingAddressDateFirstUsed.Date.ToApiDate();
            }

            set
            {
                ShippingAddressDateFirstUsed = value.ParseApiDate();
            }
        }

        /// <summary>
        /// Date when the shipping address used for this transaction was first used with the 3DS Requestor.
        /// </summary>
        [XmlIgnore]
        public DateTime ShippingAddressDateFirstUsed { get; set; }

        /// <summary>
        /// Number of transactions (successful and abandoned) for this cardholder account with the 3DS Requestor across all payment accounts in the previous 24 hours.
        /// </summary>
        [XmlElement(ElementName = "transactions_activity_last_24_hours")]
        public int TransactionsActivityLast24Hours { get; set; }

        /// <summary>
        /// Number of transactions (successful and abandoned) for this cardholder account with the 3DS Requestor across all payment accounts in the previous year.
        /// </summary>
        [XmlElement(ElementName = "transactions_activity_previous_year")]
        public int TransactionsActivityPreviousYear { get; set; }

        /// <summary>
        /// Number of Add Card attempts in the last 24 hours.
        /// </summary>
        [XmlElement(ElementName = "provision_attempts_last_24_hours")]
        public byte ProvisionAttemptsLast24Hours { get; set; }

        /// <summary>
        /// Number of purchases with this cardholder account during the previous six months.
        /// </summary>
        [XmlElement(ElementName = "purchases_count_last_6_months")]
        public byte PurchasesCountLast6Months { get; set; }

        /// <summary>
        /// Indicates whether the 3DS Requestor has experienced suspicious activity (including previous fraud) on the cardholder account.
        /// </summary>
        [XmlElement(ElementName = "suspicious_activity_indicator")]
        public SuspiciousActivityIndicators SuspiciousActivityIndicator { get; set; }

        /// <summary>
        /// Indicates the length of time that the payment account was enrolled in the cardholder’s account with the 3DS Requester.
        /// </summary>
        [XmlElement(ElementName = "registration_indicator")]
        public RegistrationIndicators RegistrationIndicator { get; set; }

        /// <summary>
        /// Used for serialization. To set value use field <see cref="RegistrationDate"/>.
        /// </summary>
        [XmlElement(ElementName = "registration_date")]
        public string RegistrationDateMetadata
        {
            get
            {
                return RegistrationDate.Date.ToApiDate();
            }

            set
            {
                RegistrationDate = value.ParseApiDate();
            }
        }

        /// <summary>
        /// Date that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.
        /// </summary>
        [XmlIgnore]
        public DateTime RegistrationDate { get; set; }
    }
}
