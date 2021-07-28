using Genesis.Net.Entities.Attributes.Request.Financial.Business;
using System;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "InitRecurringSale")]
    public class InitRecurringSale : InitialRequest
    {
        [XmlElement(ElementName="risk_params")]
        public RiskParams RiskParams { get; set; }

        [XmlElement(ElementName="dynamic_descriptor_params")]
        public DynamicDescriptor DynamicDescriptorParams { get; set; }

        [XmlElement(ElementName = "business_attributes")]
        public BusinessAttributes BusinessAttributes { get; set; }

        public InitRecurringSale()
        {
            Type = TransactionTypes.InitRecurringSale;
        }
    }
}
