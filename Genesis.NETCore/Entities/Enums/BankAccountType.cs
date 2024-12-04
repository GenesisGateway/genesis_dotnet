using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Enums
{
    /// <summary>
    /// The type of account.
    /// </summary>
    public enum BankAccountType
    {
        /// <summary>
        /// C: for Checking accounts
        /// </summary>
        [XmlEnum("C")]
        Checking,

        /// <summary>
        /// S: for Savings accounts
        /// </summary>
        [XmlEnum("S")]
        Savings,

        /// <summary>
        /// M: for Maestra accounts (Only Peru)
        /// </summary>
        [XmlEnum("M")]
        Maestra,

        /// <summary>
        /// P: for Payment accounts
        /// </summary>
        [XmlEnum("P")]
        Payment
    }
}
