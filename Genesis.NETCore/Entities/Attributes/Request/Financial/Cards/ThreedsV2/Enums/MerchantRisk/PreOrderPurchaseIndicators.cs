using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums
{
    /// <summary>
    /// Indicates whether cardholder is placing an order for merchandise with a future-availability or release date.
    /// </summary>
    public enum PreOrderPurchaseIndicators
    {
        /// <remarks/>
        [XmlEnum("merchandise_available")]
        MerchandiseAvailable,

        /// <remarks/>
        [XmlEnum("future_availability")]
        FutureAvailability
    }
}
