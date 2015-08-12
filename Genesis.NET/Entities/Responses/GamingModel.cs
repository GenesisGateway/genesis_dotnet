using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class GamingModel
    {
        [XmlElement(ElementName = "gaming")]
        public bool? Gaming { get; set; }
    }
}