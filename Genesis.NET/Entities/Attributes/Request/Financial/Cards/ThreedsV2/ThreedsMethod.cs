using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2
{
    /// <summary>
    /// 3DS-Method related parameters for any callbacks and notifications.
    /// </summary>
    [XmlRoot(ElementName = "threeds_method")]
    public partial class ThreedsMethod : Entity
    {
        /// <summary>
        /// Specific 3DS-Method callback URL after the 3DS-Method completes. The actual status will be provided via HTTP POST to that URL.
        /// </summary>
        [DataAnnotationsExtensions.Url(DataAnnotationsExtensions.UrlOptions.OptionalProtocol)]
        [XmlElement(ElementName = "callback_url")]
        public string CallbackUrl { get; set; }
    }
}
