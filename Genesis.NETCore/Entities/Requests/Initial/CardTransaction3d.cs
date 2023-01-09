using System.Xml.Serialization;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    public abstract class CardTransaction3d : CardTransaction
    {
        public CardTransaction3d(TransactionTypes type) : base(type)
        {
        }

        #region async params
        [UrlAddress]
        [XmlElement(ElementName = "notification_url")]
        public string NotificationUrl { get; set; }

        [UrlAddress]
        [XmlElement(ElementName = "return_success_url")]
        public string ReturnSuccessUrl { get; set; }

        [UrlAddress]
        [XmlElement(ElementName = "return_failure_url")]
        public string ReturnFailureUrl { get; set; }
        #endregion

        #region sync params
        [XmlElement(ElementName = "mpi_params")]
        public MpiParams MpiParams { get; set; }
        #endregion

        #region 3dsv2
        /// <summary>
        /// 3DSv2 async parameters. They must be submitted in order to use the 3DSv2 authentication protocol in asynchronous workflow.
        /// </summary>
        [XmlElement(ElementName = "threeds_v2_params")]
        public ThreeDSv2 ThreeDSv2 { get; set; }

        /// <summary>
        /// An exemption from Strong Customer Authentication (SCA) can be requested by submitting an exemption with <code>low_risk</code> under SCA params.
        /// In case the issuer accepts the exemption, a step up in the authentication flow might not be required because the transaction's risk analysis has already been performed by acquirer.
        /// Note, the requested exemption might not be accepted due to internal risk validations.
        /// For example, to be able to utilize the low risk exemption, the BIN country of the card must be part of the European Economic Area (EEA).
        /// Furthermore, the acquirer could accept the merchant low-risk exemption request only if the transaction amount does not exceed the acquirer low-risk exemption threshold.
        /// Finally, the ACS might not acknowledge the merchant/acquirer's exemption request and may still require a step up in the cardholder authentication.
        /// </summary>
        [XmlElement(ElementName = "sca_params")]
        public Sca Sca { get; set; }
        #endregion
    }
}