using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IPaymentResponseModel
    {
        [XmlElement(ElementName = "payment_response")]
        PaymentResponse[] Payments { get; set; }
    }
}