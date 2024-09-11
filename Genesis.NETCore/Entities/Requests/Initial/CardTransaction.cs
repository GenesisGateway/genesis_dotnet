using Genesis.NetCore.Entities.Attributes.Request.Financial.Business;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Funding;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    public abstract class CardTransaction : InitialRequest
    {
        public CardTransaction(TransactionTypes type)
        {
            TransactionType = type;
        }

        [XmlElement(ElementName = "gaming")]
        public bool? Gaming { get; set; }

        public bool ShouldSerializeGaming()
        {
            return Gaming != null;
        }

        [XmlElement(ElementName = "risk_params")]
        public RiskParams RiskParams { get; set; }

        [XmlElement(ElementName = "dynamic_descriptor_params")]
        public DynamicDescriptor DynamicDescriptorParams { get; set; }

        [XmlElement(ElementName = "business_attributes")]
        public BusinessAttributes BusinessAttributes { get; set; }

        /// <summary>
        /// Funding Transaction Params
        /// </summary>
        [XmlElement(ElementName = "funding")]
        public FundingAttributes Funding { get; set; }
    }
}
