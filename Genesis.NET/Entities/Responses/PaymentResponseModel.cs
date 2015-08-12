using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class PaymentResponseModel
    {
        [XmlElement(ElementName = "payment_response")]
        public PaymentResponse[] Payments { get; set; }
    }
}