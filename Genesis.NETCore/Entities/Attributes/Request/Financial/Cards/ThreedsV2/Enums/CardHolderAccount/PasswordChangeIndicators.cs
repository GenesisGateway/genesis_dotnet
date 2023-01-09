using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums
{
    /// <summary>
    /// Length of time since the cardholder account with the 3DS Requestor had a password change or account reset.
    /// </summary>
    public enum PasswordChangeIndicators
    {
        /// <remarks/>
        [XmlEnum("no_change")]
        NoChange,

        /// <remarks/>
        [XmlEnum("during_transaction")]
        DuringTransaction,

        /// <remarks/>
        [XmlEnum("less_than_30days")]
        LessThan30Days,

        /// <remarks/>
        [XmlEnum("30_to_60_days")]
        From30To60Days,

        /// <remarks/>
        [XmlEnum("more_than_60days")]
        MoreThan60Days,
    }
}
