using System;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial.ThreeD
{
    [XmlRoot("payment_transaction")]
    public abstract class Authorize3d : InitialRequest
    {
        [XmlElement(ElementName="gaming")]
        public bool? Gaming { get; set; }

        public bool ShouldSerializeGaming()
        {
            return Gaming != null;
        }

        [XmlElement(ElementName="risk_params")]
        public RiskParams RiskParams { get; set; }

        [XmlElement(ElementName="dynamic_descriptor_params")]
        public DynamicDescriptor DynamicDescriptorParams { get; set; }

        public Authorize3d()
        {
            Type = TransactionTypes.Authorize3d;
        }
    }
}