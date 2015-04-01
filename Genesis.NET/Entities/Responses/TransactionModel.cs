using System;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class TransactionModel
    {
        [XmlElement(ElementName = "unique_id")]
        public string UniqueId { get; set; }

        [XmlElement(ElementName = "transaction_id")]
        public string TransactionId { get; set; }

        [XmlElement(ElementName = "mode")]
        public string Mode { get; set; }

        [XmlIgnore]
        public DateTime Time { get; set; }

        [XmlElement(ElementName = "timestamp")]
        public string ProxyTime
        {
            get
            {
                return Formatter.FormatToString(Time);
            }
            set
            {
                Time = Formatter.FormatFromString(value);
            }
        }

        [XmlElement(ElementName = "descriptor")]
        public string Descriptor { get; set; }
    }
}
