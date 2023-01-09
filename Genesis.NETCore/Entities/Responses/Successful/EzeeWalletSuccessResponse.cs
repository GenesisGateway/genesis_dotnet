using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "EzeeWalletSuccessResponse")]
    public class EzeeWalletSuccessResponse : AlternativePaymentMethodSuccessResponse

    {
    }
}
