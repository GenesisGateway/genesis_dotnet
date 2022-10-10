using Genesis.Net.Entities.Attributes.Request.Financial.Business;
using System;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial.ThreeD
{
    /// <summary>
    /// This class is deprecated. Please use: <see cref="Genesis.Net.Entities.Requests.Initial.Sale3d"/>
    /// </summary>
    [Obsolete("This class is deprecated. Please use Genesis.Net.Entities.Requests.Initial.Sale3d")]
    public abstract class Sale3d : InitialRequest
    {
        public Sale3d()
        {
            Type = TransactionTypes.Sale3d;
        }

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

        [XmlElement(ElementName = "business_attributes")]
        public BusinessAttributes BusinessAttributes { get; set; }
    }
}