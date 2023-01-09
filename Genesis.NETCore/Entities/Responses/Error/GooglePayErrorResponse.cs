using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Error
{
    [XmlRoot("payment_response", Namespace = "GooglePayErrorResponse")]
    public class GooglePayErrorResponse : AlternativePaymentMethodErrorResponse
    {
    }
}
