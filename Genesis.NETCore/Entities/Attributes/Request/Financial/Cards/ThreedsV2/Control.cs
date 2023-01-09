using System.Xml.Serialization;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums;

namespace Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2
{
    /// <summary>
    /// General params for preferences in authentication flow and providing device interface information.
    /// </summary>
    [XmlRoot(ElementName = "control")]
    public partial class Control : IEntity
    {
        /// <summary>
        /// Identifies the device channel of the consumer, required in the 3DSv2 authentication protocol.
        /// </summary>
        [XmlElement(ElementName = "device_type")]
        public DeviceTypes DeviceType { get; set; }

        /// <summary>
        /// Identifies the size of the challenge window for the consumer.
        /// </summary>
        [XmlElement(ElementName = "challenge_window_size")]
        public ChallengeWindowSizes ChallengeWindowSize { get; set; }

        /// <summary>
        /// The value has weight and might impact the decision whether a challenge will be required for the transaction or not. If not provided, it will be interpreted as no_preference.
        /// </summary>
        [XmlElement(ElementName = "challenge_indicator")]
        public ChallengeIndicators ChallengeIndicator { get; set; }
    }
}