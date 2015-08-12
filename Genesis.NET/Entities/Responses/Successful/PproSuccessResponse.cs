using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses.Successful
{
    [XmlRoot("payment_response", Namespace = "PproSuccessResponse")]
    public class PproSuccessResponse : AlternativePaymentMethodSuccessResponse
    {
        [XmlElement(ElementName = "payment_type")]
        public string PaymentType { get; set; }
    }
}
