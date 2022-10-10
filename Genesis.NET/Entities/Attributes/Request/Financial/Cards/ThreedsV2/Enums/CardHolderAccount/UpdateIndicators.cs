using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums
{
    /// <summary>
    /// Length of time since the cardholder’s account information with the 3DS Requestor was last changed. Includes Billing or Shipping address, new payment account, or new user(s) added.
    /// </summary>
    public enum UpdateIndicators
    {
        /// <remarks/>
        [XmlEnum("current_transaction")]
        CurrentTransaction,

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
