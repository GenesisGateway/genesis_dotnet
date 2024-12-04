using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Enums
{
    public enum BankPayoutSubtype
    {
        [XmlEnum("bank_to_bank")]
        BankToBank,

        [XmlEnum("pix")]
        Pix,

        [XmlEnum("bsb")]
        Bsb,

        [XmlEnum("pay_id")]
        PayId,

        [XmlEnum("bank_to_bank_b2b")]
        BankToBankB2b,

        [XmlEnum("pix_b2b")]
        PixB2b
    }
}
