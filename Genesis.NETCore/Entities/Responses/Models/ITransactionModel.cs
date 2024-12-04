using System;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface ITransactionModel
    {
        [XmlElement(ElementName = "descriptor")]
        string Descriptor { get; set; }

        [XmlElement(ElementName = "mode")]
        string Mode { get; set; }

        [XmlIgnore]
        DateTime Time { get; set; }

        [XmlElement(ElementName = "timestamp")]
        string ProxyTime { get; set; }

        [XmlElement(ElementName = "transaction_id")]
        string TransactionId { get; set; }

        [XmlElement(ElementName = "unique_id")]
        string UniqueId { get; set; }
    }
}