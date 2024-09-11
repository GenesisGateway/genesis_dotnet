using System;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Enums.Funding
{
    /// <summary>
    /// Funding Transaction identifier types
    /// </summary>
    [Serializable]
    public enum IdentifierType
    {
        /// <summary>
        /// Required MCCs: 4829, 6538, 6540
        /// </summary>
        [XmlEnum("general_person_to_person")]
        GeneralPersonToPerson,

        /// <summary>
        /// Required MCCs: 4829
        /// </summary>
        [XmlEnum("person_to_person_card_account")]
        PersonToPersonCardAccount,

        /// <summary>
        /// Required MCCs: 4829, 6051, 6211, 6538, 6540, 7800, 7801, 7802, 7994, 7995, 9406
        /// </summary>
        [XmlEnum("own_account")]
        OwnAccount,

        /// <summary>
        /// Required MCCs: 4829, 6538
        /// </summary>
        [XmlEnum("own_credit_card_bill")]
        OwnCreditCardBill,

        /// <summary>
        /// Required MCCs: any
        /// </summary>
        [XmlEnum("business_disbursement")]
        BusinessDisbursement,

        /// <summary>
        /// Required MCCs: any
        /// </summary>
        [XmlEnum("government_or_non_profit_disbursement")]
        GovernmentOrNonProfitDisbursement,

        /// <summary>
        /// Required MCCs: any
        /// </summary>
        [XmlEnum("rapid_merchant_settlement")]
        RapidMerchantSettlement,

        /// <summary>
        /// Required MCCs: any
        /// </summary>
        [XmlEnum("general_business_to_business")]
        GeneralBusinessToBusiness,

        /// <summary>
        /// Required MCCs: any
        /// </summary>
        [XmlEnum("own_staged_digital_wallet_account")]
        OwnStagedDigitalWalletAccount,

        /// <summary>
        /// Required MCCs: any
        /// </summary>
        [XmlEnum("own_debit_or_prepaid_card_account")]
        OwnDebitOrPrepaidCardAccount
    }
}
