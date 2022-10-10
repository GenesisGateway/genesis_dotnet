using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums
{
    /// <summary>
    /// Indicator code that most accurately describes the shipping method for the cardholder specific transaction. If one or more items are included in the sale, use the Shipping Indicator code for the physical goods. If all digital goods, use the code that describes the most expensive item.
    /// </summary>
    public enum ShippingIndicators
    {
        /// <remarks/>
        [XmlEnum("same_as_billing")]
        SameAsBilling,

        /// <remarks/>
        [XmlEnum("stored_address")]
        StoredAddress,

        /// <remarks/>
        [XmlEnum("verified_address")]
        VerifiedAddress,

        /// <remarks/>
        [XmlEnum("pick_up")]
        PickUp,

        /// <remarks/>
        [XmlEnum("digital_goods")]
        DigitalGoods,

        /// <remarks/>
        [XmlEnum("travel")]
        Travel,

        /// <remarks/>
        [XmlEnum("event_tickets")]
        EventTickets,

        /// <remarks/>
        [XmlEnum("other")]
        Other

    }
}
