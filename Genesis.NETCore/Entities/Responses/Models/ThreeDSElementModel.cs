using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums.ThreeDS;

namespace Genesis.NetCore.Entities.Responses.Models
{
    /// <summary>
    /// 3DS Response model
    /// </summary>
    public class ThreeDSElementModel : IResponse
    {
        /// <summary>
        /// Identifies the concrete authentication flow of the 3DS transaction that it has gone through. It will be included only if the transaction reaches the final state.
        /// </summary>
        [XmlElement("authentication_flow")]
        public AuthenticationFlows? AuthenticationFlow { get; set; }

        /// <summary>
        /// Contains the current status of 3DSv2-Method.
        /// </summary>
        [XmlElement("threeds_method")]
        public ThreedsMethodModel ThreedsMethod { get; set; }

        /// <summary>
        /// Identifies the requested version and concrete version of the 3DS authentication protocol.
        /// </summary>
        [XmlElement("protocol")]
        public ProtocolModel Protocol { get; set; }

        /// <summary>
        /// Electronic Commerce Indicator (ECI) is a value that is returned from the Directory Server (Visa, MasterCard, etc.) to indicate the authentication results of your customer’s credit card payment on 3D Secure.
        /// <code>Visa/JCB/Diners/American Express/Rupay</code>
        /// <code>05</code> Both cardholder and card issuing bank are 3D enabled. 3D card authentication is successful
        /// <code>06</code> Either cardholder or card issuing bank is not 3D enrolled. 3D card authentication is unsuccessful, in sample situations as: 1. 3D cardholder not enrolled 2. Card issuing bank is not 3D Secure ready
        /// <code>07</code> Authentication is unsuccessful or not attempted.The credit card is either a non-3D card or card issuing bank does not handle it as a 3D transaction
        /// <code>MasterCard/Maestro</code>
        /// <code>02</code> Both cardholder and card issuing bank are 3D enabled. 3D card authentication is successful
        /// <code>01</code> Either cardholder or card issuing bank is not 3D enrolled. 3D card authentication is unsuccessful, in sample situations as: 1. 3D Cardholder not enrolled 2. Card issuing bank is not 3D Secure ready
        /// <code>00 (or empty)</code> Authentication is unsuccessful or not attempted.The credit card is either a non-3D card or card issuing bank does not handle it as a 3D transaction
        /// </summary>
        [MaxLength(2)]
        [XmlElement("eci")]
        public string Eci { get; set; }
    }
}
