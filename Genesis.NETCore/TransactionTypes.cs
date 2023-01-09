using System.Xml.Serialization;

namespace Genesis.NetCore
{
    public enum TransactionTypes
    {
        [XmlEnum("authorize")]
        Authorize = 1,

        [XmlEnum("authorize3d")]
        Authorize3d = 2,

        [XmlEnum("capture")]
        Capture = 3,

        [XmlEnum("sale")]
        Sale = 4,

        [XmlEnum("sale3d")]
        Sale3d = 5,

        [XmlEnum("init_recurring_sale")]
        InitRecurringSale = 6,

        [XmlEnum("init_recurring_sale3d")]
        InitRecurringSale3d = 7,

        [XmlEnum("recurring_sale")]
        RecurringSale = 8,

        [XmlEnum("refund")]
        Refund = 9,

        [XmlEnum("void")]
        Void = 10,

        [XmlEnum("credit")]
        Credit = 11,

        [XmlEnum("payout")]
        Payout = 12,

        [XmlEnum("account_verification")]
        AccountVerification = 13,

        [XmlEnum("avs")]
        Avs = 14,

        [XmlEnum("ezeewallet")]
        EzeeWallet = 15,

        [XmlEnum("paybyvoucher")]
        PayByVoucher = 16,

        [XmlEnum("cashu")]
        CashU = 17,

        [XmlEnum("paysafecard")]
        PaySafeCard = 18,

        [XmlEnum("sofort")]
        Sofort = 19,

        [XmlEnum("sofort_ideal")]
        SofortIdeal = 20,

        [XmlEnum("ppro")]
        Ppro = 21,

        [XmlEnum("google_pay")]
        GooglePay = 22,

        [XmlEnum("apple_pay")]
        ApplePay = 23,
    }
}
