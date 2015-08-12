using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities
{
    public class DynamicDescriptor : Entity
    {
        [StringLength(25)]
        [XmlElement(ElementName="merchant_name")]
        public string MerchantName { get; set; }

        [StringLength(13)]
        [XmlElement(ElementName="merchant_city")]
        public string MerchantCity { get; set; }

        public DynamicDescriptor() { }
    }
}
