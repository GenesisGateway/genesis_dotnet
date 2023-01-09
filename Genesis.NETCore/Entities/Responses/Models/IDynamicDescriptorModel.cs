using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IDynamicDescriptorModel
    {
        [XmlElement(ElementName = "dynamic_descriptor_params")]
        DynamicDescriptor DynamicDescriptorParams { get; set; }
    }
}