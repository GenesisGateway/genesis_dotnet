using Genesis.Net.Entities.Attributes.Request.Financial.Business;
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

        [XmlElement(ElementName = "business_attributes")]
        public BusinessAttributes BusinessAttributes { get; set; }

        public InitRecurringSale3d()
        {
            Type = TransactionTypes.InitRecurringSale3d;
        }
    }
}