using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IGamingModel
    {
        [XmlElement(ElementName = "gaming")]
        bool? Gaming { get; set; }
    }
}