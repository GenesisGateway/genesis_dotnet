using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Error
{
    [XmlRoot("payment_response", Namespace = "CaptureErrorResponse")]
    public class CaptureErrorResponse : AlternativePaymentMethodErrorResponse
    {
    }
}