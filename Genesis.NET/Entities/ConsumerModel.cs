using System.Xml.Serialization;

namespace Genesis.Net.Entities
{
    internal class ConsumerModel
    {
        [XmlElement(ElementName = "consumer_id")]
        public string ConsumerId { get; set; }
    }
}