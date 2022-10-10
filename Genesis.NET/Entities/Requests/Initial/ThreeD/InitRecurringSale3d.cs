using Genesis.Net.Entities.Attributes.Request.Financial.Business;
using System;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial.ThreeD
{
    /// <summary>
    /// This class is deprecated. Please use: <see cref="Genesis.Net.Entities.Requests.Initial.InitRecurringSale3d"/>
    /// </summary>
    [Obsolete("This class is deprecated. Please use Genesis.Net.Entities.Requests.Initial.InitRecurringSale3d")]
    public abstract class InitRecurringSale3d : InitialRequest
    {
        public InitRecurringSale3d()
        {
            Type = TransactionTypes.InitRecurringSale3d;
        }

        [XmlElement(ElementName="risk_params")]
        public RiskParams RiskParams { get; set; }

        [XmlElement(ElementName="dynamic_descriptor_params")]
        public DynamicDescriptor DynamicDescriptorParams { get; set; }

        [XmlElement(ElementName = "business_attributes")]
        public BusinessAttributes BusinessAttributes { get; set; }
    }
}