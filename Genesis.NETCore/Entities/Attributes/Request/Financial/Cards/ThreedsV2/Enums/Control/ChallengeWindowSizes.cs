using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums
{
    /// <summary>
    /// The challenge_window_size is required when the device_type is set to browser.
    /// See: <see cref="DeviceTypes"/>
    /// </summary>
    public enum ChallengeWindowSizes
    {
        /// <summary>
        /// Challenge in a full screen
        /// </summary>
        [XmlEnum("full_screen")]
        FullScreen,

        /// <summary>
        /// Challenge window: width of 250px and height of 400px
        /// </summary>
        [XmlEnum("250x400")]
        ChallengeWindow_250x400,

        /// <summary>
        /// Challenge window: width of 390px and height of 400px
        /// </summary>
        [XmlEnum("390x400")]
        ChallengeWindow_390x400,

        /// <summary>
        /// Challenge window: width of 500px and height of 600px
        /// </summary>
        [XmlEnum("500x600")]
        ChallengeWindow_500x600,

        /// <summary>
        /// Challenge window: width of 600px and height of 400px
        /// </summary>
        [XmlEnum("600x400")]
        ChallengeWindow_600x400
    }
}
