using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class BlacklistModel
    {
        [XmlElement(ElementName = "blacklisted")]
        public bool Blacklisted { get; set; }
    }
}