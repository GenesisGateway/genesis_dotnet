using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Error
{
    [XmlRoot("payment_response", Namespace = "EzeeWalletErrorResponse")]
    public class EzeeWalletErrorResponse : AlternativePaymentMethodErrorResponse
    {
    }
}
