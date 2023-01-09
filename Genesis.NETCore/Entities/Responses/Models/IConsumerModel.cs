using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IConsumerModel
    {
        [XmlElement(ElementName = "consumer_id")]
        string ConsumerId { get; set; }
    }
}