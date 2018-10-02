using System;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial.ThreeD
{
    public abstract class InitRecurringSale3d : InitialRequest
    {
        [XmlElement(ElementName="risk_params")]
        public RiskParams RiskParams { get; set; }

        [XmlElement(ElementName="dynamic_descriptor_params")]
        public DynamicDescriptor DynamicDescriptorParams { get; set; }

        public InitRecurringSale3d()
        {
            Type = TransactionTypes.InitRecurringSale3d;
        }
    }
}