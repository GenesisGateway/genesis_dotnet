using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Enums
{
    /// <summary>
    /// PPRO transaction payment type
    /// </summary>
    public enum PproPaymentType
    {
        /// <summary>
        /// e-payment standard
        /// </summary>
        [XmlEnum("eps")]
        EPS,

        /// <summary>
        /// iDEAL
        /// </summary>
        [XmlEnum("ideal")]
        IDEAL,

        /// <summary>
        /// Przelewy24
        /// </summary>
        [XmlEnum("przelewy24")]
        PRZELEWY24,

        /// <summary>
        /// SafetyPay
        /// </summary>
        [XmlEnum("safetypay")]
        SAFETY_PAY,

        /// <summary>
        /// Mr.Cash
        /// </summary>
        [XmlEnum("bcmc")]
        BCMC,

        /// <summary>
        /// MyBank
        /// </summary>
        [XmlEnum("mybank")]
        MYBANK
    }
}
