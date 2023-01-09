using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "PproSuccessResponse")]
    public class PproSuccessResponse : AlternativePaymentMethodSuccessResponse
    {
        [XmlElement(ElementName = "payment_type")]
        public string PaymentType { get; set; }
    }
}
