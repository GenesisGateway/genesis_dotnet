using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    public interface IMotoModel
    {
        [XmlElement(ElementName = "moto")]
        bool? Moto { get; set; }

        bool ShouldSerializeMoto();
    }
}