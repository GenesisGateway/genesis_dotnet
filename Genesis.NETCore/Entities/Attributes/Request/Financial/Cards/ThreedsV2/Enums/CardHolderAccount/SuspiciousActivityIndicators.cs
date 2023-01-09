using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums
{
    /// <summary>
    /// Indicates whether the 3DS Requestor has experienced suspicious activity (including previous fraud) on the cardholder account.
    /// </summary>
    public enum SuspiciousActivityIndicators
    {
        /// <remarks/>
        [XmlEnum("no_suspicious_observed")]
        NoSuspiciousObserved,

        /// <remarks/>
        [XmlEnum("suspicious_observed")]
        SuspiciousObserved,
    }
}
