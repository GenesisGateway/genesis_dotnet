using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "PayByVoucherSuccessResponse")]
    public class PayByVoucherSuccessResponse : AlternativePaymentMethodSuccessResponse
    {
    }
}
