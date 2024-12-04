using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Error
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "OnlineBankingErrorResponse")]
    public class OnlineBankingErrorResponse : AlternativePaymentMethodErrorResponse
    {
    }
}
