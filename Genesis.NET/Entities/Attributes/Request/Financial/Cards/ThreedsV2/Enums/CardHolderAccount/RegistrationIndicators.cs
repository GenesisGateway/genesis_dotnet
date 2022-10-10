using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums
{
    /// <summary>
    /// Indicates the length of time that the payment account was enrolled in the cardholder’s account with the 3DS Requester.
    /// </summary>
    public enum RegistrationIndicators
    {
        /// <remarks/>
        [XmlEnum("guest_checkout")]
        GuestCheckout,

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
