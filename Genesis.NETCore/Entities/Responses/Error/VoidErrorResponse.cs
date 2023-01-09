using System.Xml.Serialization;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Error
{
    [XmlRoot("payment_response", Namespace = "VoidErrorResponse")]
    public class VoidErrorResponse :
        AlternativePaymentMethodErrorResponse,
        IIssuerModel
    {
        public string ResponseCode { get; set; }
    }
}