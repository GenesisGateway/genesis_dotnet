using Genesis.Net.Entities.Attributes.Request.Financial.Business;
using System;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial.ThreeD
{
    /// <summary>
    /// This class is deprecated. Please use: <see cref="Genesis.Net.Entities.Requests.Initial.Authorize3d"/>
    /// </summary>
    [XmlRoot("payment_transaction")]
    [Obsolete("This class is deprecated. Please use Genesis.Net.Entities.Requests.Initial.Authorize3d")]
    public abstract class Authorize3d : InitialRequest
    {
        public Authorize3d()
        {
            Type = TransactionTypes.Authorize3d;
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