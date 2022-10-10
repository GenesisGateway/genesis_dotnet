using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2
{
    /// <summary>
    /// For browser-based transactions. They are all required in case the device_type is set to browser. See <see cref="Control.DeviceType"/>
    /// </summary>
    [XmlRoot(ElementName = "browser")]
    public partial class Browser : Entity
    {
        /// <summary>
        /// The exact content of the HTTP ACCEPT header as sent to the 3DS Requester from the Cardholder browser. Any other header different than the ACCEPT header will be rejected.
        /// Example: <example>application/json,text/plain,text/html,*/*</example>
        /// </summary>
        [XmlElement(ElementName = "accept_header")]
        public string AcceptHeader { get; set; }

        /// <summary>
        /// Boolean that represents the ability of the cardholder browser to execute Java. The value can be retrieved by accessing a property of the navigator with JavaScript.
        /// Example: <example>navigator.javaEnabled</example>
        /// </summary>
        [XmlElement(ElementName = "java_enabled")]
        public bool JavaEnabled { get; set; }

        /// <summary>
        /// Value representing the browser language as defined in <see href="https://en.wikipedia.org/wiki/IETF_language_tag">IETF BCP47</see>. Note that only one browser language tag is about to be submitted as per the above IETF BCP47.
        /// Numeric chars are also allowed in the subtag and will represent the region.
        /// <example>Example: <code>en-GB, zh-guoyu, fil-PH, gsw, es-419, de-1996, etc.</code></example>
        /// The value can be retrieved by accessing a property of the navigator with JavaScript: <code>navigator.language</code>
        /// </summary>
        [XmlElement(ElementName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// Value representing the bit depth of the color palette for displaying images, in bits per pixel.
        /// Obtained from Cardholder browser using the screen.colorDepth property.
        /// The value as per EMVCo specs can be one of <code>1, 4, 8, 15, 16, 24, 32, 48</code>
        /// In case, an unsupported color_depth is determined, the nearest supported value that is less than the actual one needs to be submitted.
        /// For example, if the obtained value is 30, which is not supported as per EMVCo specs, 24 has to be submitted.
        /// </summary>
        [XmlElement(ElementName = "color_depth")]
        public int ColorDepth { get; set; }

        /// <summary>
        /// Total height of the Cardholder's screen in pixels. Value is returned from the <code>screen.height</code> property (in JavaScript).
        /// </summary>
        [XmlElement(ElementName = "screen_height")]
        public ushort ScreenHeight { get; set; }

        /// <summary>
        /// Total width of the Cardholder's screen in pixels. Value is returned from the  <code>screen.width</code> property (in JavaScript).
        /// </summary>
        [XmlElement(ElementName = "screen_width")]
        public ushort ScreenWidth { get; set; }

        /// <summary>
        /// Time difference between UTC time and the Cardholder browser local time, in minutes.
        /// Note that the offset is positive if the local time zone is behind UTC and negative if it is ahead. If UTC -5 hours then submit 300 or +300, If UTC +2 hours then -120.
        /// The value can be retrieved using Javascript <code>getTimezoneOffset()</code> method over Date object.
        /// </summary>
        [XmlElement(ElementName = "time_zone_offset")]
        public int TimeZoneOffset { get; set; }

        /// <summary>
        /// Exact content of the HTTP user-agent header.
        /// </summary>
        [MaxLength(2048)]
        [XmlElement(ElementName = "user_agent")]
        public string UserAgent { get; set; }
    }
}
