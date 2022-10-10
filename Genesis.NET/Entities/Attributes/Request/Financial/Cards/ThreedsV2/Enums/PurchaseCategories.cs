using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums
{
    /// <summary>
    /// Identifies the type of transaction being authenticated.
    /// </summary>
    public enum PurchaseCategories
    {
        ///<remarks />
        [XmlEnum("goods")]
        Goods,

        ///<remarks />
        [XmlEnum("service")]
        Service,

        ///<remarks />
        [XmlEnum("check_acceptance")]
        CheckAcceptance,

        ///<remarks />
        [XmlEnum("account_funding")]
        AccountFunding,

        ///<remarks />
        [XmlEnum("quasi_cash")]
        QuasiCash,

        ///<remarks />
        [XmlEnum("prepaid_activation")]
        PrepaidActivation,

        ///<remarks />
        [XmlEnum("loan")]
        Loan
    }
}
