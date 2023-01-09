using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    public abstract class AlternativePaymentMethod : ProcessRequest
    {
        [Required]
        [UrlAddress]
        [XmlElement(ElementName = "return_success_url")]
        public string ReturnSuccessUrl { get; set; }

        [Required]
        [UrlAddress]
        [XmlElement(ElementName = "return_failure_url")]
        public string ReturnFailureUrl { get; set; }

        [Required]
        [XmlElement(ElementName = "customer_email")]
        public string CustomerEmail { get; set; }

        [XmlElement(ElementName = "customer_phone")]
        public string CustomerPhone { get; set; }

        [XmlElement(ElementName = "billing_address")]
        public Address BillingAddress { get; set; }

        [XmlElement(ElementName = "shipping_address")]
        public Address ShippingAddress { get; set; }

        [XmlElement(ElementName = "risk_params")]
        public RiskParams RiskParams { get; set; }
    }
}
