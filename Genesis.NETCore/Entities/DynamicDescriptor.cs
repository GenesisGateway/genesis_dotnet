using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities
{
    public class DynamicDescriptor : IEntity
    {
        [StringLength(25)]
        [XmlElement(ElementName = "merchant_name")]
        public string MerchantName { get; set; }

        [StringLength(13)]
        [XmlElement(ElementName = "merchant_city")]
        public string MerchantCity { get; set; }

        public DynamicDescriptor() { }
    }
}
