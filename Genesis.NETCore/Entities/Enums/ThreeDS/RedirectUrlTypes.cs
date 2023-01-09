using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Enums.ThreeDS
{
    /// <summary>
    /// The type of the redirect URL in the 3DS scope.
    /// </summary>
    public enum RedirectUrlTypes
    {
        /// <summary>
        /// 3DSv1 Payer Authentication
        /// </summary>
        [XmlEnum("3ds_v1_payer_authentication")]
        ThreeDSv1PayerAuthentication = 1,

        /// <summary>
        /// 3DSv2 Challenge
        /// </summary>
        [XmlEnum("3ds_v2_challenge")]
        ThreeDSv2Challage = 2,
    }
}
