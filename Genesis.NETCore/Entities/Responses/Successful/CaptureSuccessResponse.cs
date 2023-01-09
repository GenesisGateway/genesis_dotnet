using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "CaptureSuccessResponse")]
    public class CaptureSuccessResponse : AlternativePaymentMethodSuccessResponse
    {
    }
}
