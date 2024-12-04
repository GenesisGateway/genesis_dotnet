using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Enums
{
    public enum OnlineBankingPaymentType
    {
        /// <summary>
        /// Online banking
        /// </summary>
        [XmlEnum("online_banking")]
        OnlineBanking,

        /// <summary>
        /// Quick payment  
        /// </summary>
        [XmlEnum("quick_payment")]
        QuickPayment,

        /// <summary>
        /// Qr payment 
        /// </summary>
        [XmlEnum("qr_payment")]
        QrPayment,

        /// <summary>
        /// Netbanking 
        /// </summary>
        [XmlEnum("netbanking")]
        Netbanking,

        /// <summary>
        /// Alipay QR  
        /// </summary>
        [XmlEnum("alipay_qr")]
        AlipayQr,

        /// <summary>
        /// Bancomer   
        /// </summary>
        [XmlEnum("bancomer")]
        Bancomer,

        /// <summary>
        /// Scotiabank 
        /// </summary>
        [XmlEnum("scotiabank")]
        Scotiabank,
    }
}
