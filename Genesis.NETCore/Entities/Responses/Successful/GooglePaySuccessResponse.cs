using System.Xml.Serialization;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "GooglePaySuccessResponse")]
    public class GooglePaySuccessResponse :
        AlternativePaymentMethodSuccessResponse,
        IAuthorizationModel,
        IAvsResponseModel,
        IConsumerModel,
        IIssuerModel
    {
        public string AuthorizationCode { get; set; }
        public string AvsResponseCode { get; set; }
        public string AvsResponseText { get; set; }
        public string ConsumerId { get; set; }
        public string ResponseCode { get; set; }
    }
}
