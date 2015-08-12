using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DataAnnotations = DataAnnotationsExtensions;

namespace Genesis.Net.Entities.Requests.Initial
{
    public abstract class AlternativePaymentMethod : ProcessRequest
    {
        [Required]
        [DataAnnotations.Url(DataAnnotations.UrlOptions.OptionalProtocol)]
        [XmlElement(ElementName = "return_success_url")]
        public string ReturnSuccessUrl { get; set; }

        [Required]
        [DataAnnotations.Url(DataAnnotations.UrlOptions.OptionalProtocol)]
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
