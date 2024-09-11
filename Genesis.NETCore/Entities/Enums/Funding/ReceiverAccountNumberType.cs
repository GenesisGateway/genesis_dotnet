using System;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Enums.Funding
{
    /// <summary>
    /// Funding Transaction Receiver Account types
    /// </summary>
    [Serializable]
    public enum ReceiverAccountNumberType
    {
        /// <summary>
        /// Routing Transit Number and Bank Account Number
        /// </summary>
        [XmlEnum("rtn_and_bank_account_number")]
        RtnAndBankAccountNumber,

        /// <summary>
        /// International Bank Account Number
        /// </summary>
        [XmlEnum("iban")]
        Iban,

        /// <summary>
        /// Card Account
        /// </summary>
        [XmlEnum("card_account")]
        CardAccount,

        /// <summary>
        /// Electronic Mail
        /// </summary>
        [XmlEnum("email")]
        Email,

        /// <summary>
        /// Phone Number
        /// </summary>
        [XmlEnum("phone_number")]
        PhoneNumber,

        /// <summary>
        /// Bank Account Number and Business Identifier Code
        /// </summary>
        [XmlEnum("bank_account_number_and_bic")]
        BankAccountNumberAndBic,

        /// <summary>
        /// Wallet ID
        /// </summary>
        [XmlEnum("wallet_id")]
        WalletId,

        /// <summary>
        /// Unique Identifier for Social Network Application
        /// </summary>
        [XmlEnum("social_network_id")]
        SocialNetworkId,

        /// <summary>
        /// Any other type
        /// </summary>
        [XmlEnum("wallet_id")]
        Other,


    }
}
