using System.Xml.Serialization;

namespace Genesis.Net.Entities.Enums.ThreeDS
{
    /// <summary>
    /// Identifies the concrete 3DS authentication flow that the transaction has gone through. It will be available in the notification only if the consumer has finished the 3DS authentication with the issuer.
    /// </summary>
    public enum AuthenticationFlows
    {
        /// <summary>
        /// The value for 3DSv1 will be payer_authentication.
        /// </summary>
        [XmlEnum("payer_authentication")]
        PayerAuthentication,

        /// <summary>
        /// 3DSv2 value
        /// </summary>
        [XmlEnum("frictionless")]
        Frictionless,

        /// <summary>
        /// 3DSv2 value
        /// </summary>
        [XmlEnum("challenge")]
        Challenge,

        /// <summary>
        /// 3DSv2 value
        /// </summary>
        [XmlEnum("fallback")]
        Fallback
    }
}
