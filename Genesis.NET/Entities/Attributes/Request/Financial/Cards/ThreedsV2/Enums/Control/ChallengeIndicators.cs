using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums
{
    /// <summary>
    /// Optional.
    /// </summary>
    public enum ChallengeIndicators
    {
        /// <summary>
        /// Don't have any preferences related to the Challenge flow. (default)
        /// </summary>
        [XmlEnum("no_preference")]
        NoPreference,

        /// <summary>
        /// I prefer that a Challenge flow does not take place.
        /// </summary>
        [XmlEnum("no_challenge_requested")]
        NoChallengeRequested,

        /// <summary>
        /// A request for the Challenge flow to take place.
        /// </summary>
        [XmlEnum("preference")]
        Preference,

        /// <summary>
        /// A Challenge flow must take place to fulfill a mandate
        /// </summary>
        [XmlEnum("mandate")]
        Mandate
    }
}
