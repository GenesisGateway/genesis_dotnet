using System.Xml.Serialization;


namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums
{
    /// <summary>
    /// Indicates the merchandise delivery timeframe.
    /// </summary>
    public enum DeliveryTimeframes
    {
        /// <remarks/>
        [XmlEnum("electronic")]
        Electronic,

        /// <remarks/>
        [XmlEnum("same_day")]
        SameDay,

        /// <remarks/>
        [XmlEnum("over_night")]
        OverNight,

        /// <remarks/>
        [XmlEnum("another_day")]
        AnotherDay
    }
}
