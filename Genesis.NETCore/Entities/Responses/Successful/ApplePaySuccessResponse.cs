using System.Xml.Serialization;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "ApplePaySuccessResponse")]
    public class ApplePaySuccessResponse :
        AlternativePaymentMethodSuccessResponse,
        IAvsResponseModel,
        IAuthorizationModel,
        IConsumerModel,
        IIssuerModel
    {
        public string AvsResponseCode { get; set; }
        public string AvsResponseText { get; set; }
        public string AuthorizationCode { get; set; }
        public string ConsumerId { get; set; }
        public string ResponseCode { get; set; }
    }
}
