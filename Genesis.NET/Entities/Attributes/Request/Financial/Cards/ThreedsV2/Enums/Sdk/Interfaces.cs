using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums
{
    /// <summary>
    /// SDK Interface types that the device of the consumer supports for displaying specific challenge interfaces within the SDK.
    /// </summary>
    public enum Interfaces
    {
        /// <remarks/>
        [XmlEnum("native")]
        Native,

        /// <remarks/>
        [XmlEnum("html")]
        HTML,

        /// <remarks/>
        [XmlEnum("both")]
        Both,
    }
}
