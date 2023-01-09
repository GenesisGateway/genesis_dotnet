using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IBlacklistModel
    {
        [XmlElement(ElementName = "blacklisted")]
        bool Blacklisted { get; set; }
    }
}