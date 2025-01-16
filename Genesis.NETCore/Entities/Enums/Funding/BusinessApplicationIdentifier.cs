using System;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Enums.Funding
{
    /// <summary>
    /// Types of VISA Funding Transaction
    /// </summary>
    [Serializable]
    public enum BusinessApplicationIdentifier
    {
        [XmlEnum("funds_disbursement")]
        FundsDisbursement,

        [XmlEnum("pension_disbursement")]
        PensionDisbursement,

        [XmlEnum("account_to_account")]
        AccountToAccount,

        [XmlEnum("bank_initiated")]
        BankInitiated,

        [XmlEnum("fund_transfer")]
        FundTransfer,

        [XmlEnum("person_to_person")]
        PersonToPerson,

        [XmlEnum("prepaid_card_load")]
        PrepaidCardLoad,

        [XmlEnum("wallet_transfer")]
        WalletTransfer,

        [XmlEnum("liquid_assets")]
        LiquidAssets
    }
}
