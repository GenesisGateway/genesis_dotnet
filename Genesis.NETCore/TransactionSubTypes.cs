using System.Xml.Serialization;

namespace Genesis.NetCore
{
    public enum TransactionSubTypes
    {
        [XmlEnum("authorize")]
        Authorize = 1,

        [XmlEnum("sale")]
        Sale = 2,

        [XmlEnum("init_recurring_sale")]
        InitRecurringSale = 3,
    }
}
