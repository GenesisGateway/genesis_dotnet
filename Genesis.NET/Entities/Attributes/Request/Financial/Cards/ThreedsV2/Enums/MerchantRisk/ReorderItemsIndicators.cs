using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums
{
    /// <summary>
    /// Indicates whether the cardholder is reordering previously purchased merchandise.
    /// </summary>
    public enum ReorderItemsIndicators
    {
        /// <remarks/>
        [XmlEnum("first_time")]
        FirstTime,

        /// <remarks/>
        [XmlEnum("reordered")]
        Reordered
    }
}
