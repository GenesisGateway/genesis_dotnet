using System.Xml.Serialization;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums;

namespace Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2
{
    /// <summary>
    /// An exemption from Strong Customer Authentication (SCA) can be requested by submitting an exemption with <code>low_risk</code> under SCA params.
    /// In case the issuer accepts the exemption, a step up in the authentication flow might not be required because the transaction's risk analysis has already been performed by acquirer.
    /// Note, the requested exemption might not be accepted due to internal risk validations.
    /// For example, to be able to utilize the low risk exemption, the BIN country of the card must be part of the European Economic Area (EEA).
    /// Furthermore, the acquirer could accept the merchant low-risk exemption request only if the transaction amount does not exceed the acquirer low-risk exemption threshold.
    /// Finally, the ACS might not acknowledge the merchant/acquirer's exemption request and may still require a step up in the cardholder authentication.
    /// </summary>
    [XmlRoot(ElementName = "sca")]
    public partial class Sca : IEntity
    {
        /// <summary>
        /// Exemption for the Strong Customer Authentication.
        /// </summary>
        [XmlElement(ElementName = "exemption")]
        public ScaExemptions Exemption { get; set; }
    }
}
