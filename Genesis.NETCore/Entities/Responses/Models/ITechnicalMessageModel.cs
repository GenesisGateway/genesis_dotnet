using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    public interface ITechnicalMessageModel
    {
        [XmlElement(ElementName = "technical_message")]
        string TechnicalMessage { get; set; }

        [XmlElement(ElementName = "message")]
        string Message { get; set; }
    }
}