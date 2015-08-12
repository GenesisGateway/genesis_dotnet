using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class MotoModel
    {
        [XmlElement(ElementName = "moto")]
        public bool? Moto { get; set; }

        public bool ShouldSerializeMoto()
        {
            return Moto != null;
        }
    }
}