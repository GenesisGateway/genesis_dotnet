using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2
{
    /// <summary>
    /// Indicates when the shipping address used for this transaction was first used with the 3DS Requestor.
    /// </summary>
    public enum ShippingAddressUsageIndicators
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
