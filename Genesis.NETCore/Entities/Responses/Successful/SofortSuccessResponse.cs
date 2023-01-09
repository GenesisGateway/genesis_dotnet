using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "SofortSuccessResponse")]
    public class SofortSuccessResponse : AlternativePaymentMethodSuccessResponse
    {
    }
}
