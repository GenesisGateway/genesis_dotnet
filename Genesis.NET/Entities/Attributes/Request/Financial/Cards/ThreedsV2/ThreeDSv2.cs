using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2
{
    /// <summary>
    /// 3DSv2 async parameters. They must be submitted in order to use the 3DSv2 authentication protocol in asynchronous workflow.
    /// </summary>
    public partial class ThreeDSv2 : Entity
    {
        /// <summary>
        /// 3DS-Method related parameters for any callbacks and notifications.
        /// </summary>
        [XmlElement(ElementName = "threeds_method")]
        public ThreedsMethod ThreedsMethod { get; set; }

        /// <summary>
        /// General params for preferences in authentication flow and providing device interface information.
        /// </summary>
        [XmlElement(ElementName = "control")]
        public Control Control { get; set; }

        /// <summary>
        /// Purchase related params providing with additional information regarding the order.
        /// </summary>
        [XmlElement(ElementName = "purchase")]
        public Purchase Purchase { get; set; }

        /// <summary>
        /// Merchant risk assessment params. They are all optional, but recommended.
        /// </summary>
        [XmlElement(ElementName = "merchant_risk")]
        public MerchantRisk MerchantRisk { get; set; }

        /// <summary>
        /// Cardholder account additional information. They are all optional, but recommended, because they have a significant impact on approval rates.
        /// </summary>
        [XmlElement(ElementName = "card_holder_account")]
        public CardHolderAccount CardHolderAccount { get; set; }

        /// <summary>
        /// For browser-based transactions. They are all required in case the device_type is set to browser. See <see cref="Control.DeviceType"/>
        /// </summary>
        [XmlElement(ElementName = "browser")]
        public Browser Browser { get; set; }

        /// <summary>
        /// For application-based transactions. They are all required in case the device_type is set to application. See <see cref="Control.DeviceType"/>
        /// </summary>
        [XmlElement(ElementName = "sdk")]
        public Sdk Sdk { get; set; }

        /// <summary>
        /// Additional recurring details.
        /// </summary>
        [XmlElement(ElementName = "recurring")]
        public Recurring Recurring { get; set; }
    }
}
