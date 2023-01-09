using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums
{
    /// <summary>
    /// Required.
    /// </summary>
    public enum DeviceTypes
    {
        /// <summary>
        /// Browser-based consumer interface. All the browser parameters are required.
        /// See: <see cref="ChallengeWindowSizes"/>
        /// </summary>
        [XmlEnum("browser")]
        Browser,

        /// <summary>
        /// Application-based consumer interface, mobile etc. All the sdk parameters are required.
        /// </summary>
        [XmlEnum("application")]
        Application
    }
}
