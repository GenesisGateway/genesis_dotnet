using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses.Error
{
    [XmlRoot("payment_response", Namespace = "GooglePayErrorResponse")]
    public partial class GooglePayErrorResponse : AlternativePaymentMethodErrorResponse
    {
    }
}
