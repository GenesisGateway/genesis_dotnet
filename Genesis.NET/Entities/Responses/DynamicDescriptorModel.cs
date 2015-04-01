using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class DynamicDescriptorModel
    {
        [XmlElement(ElementName = "dynamic_descriptor_params")]
        public DynamicDescriptor DynamicDescriptorParams { get; set; }
    }
}