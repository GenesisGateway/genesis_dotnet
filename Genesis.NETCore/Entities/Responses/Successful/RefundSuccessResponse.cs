using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "RefundSuccessResponse")]
    public class RefundSuccessResponse :
        MoneyAndTransactionModel,
        IAuthorizationModel,
        IIssuerModel,
        ITransactionStatusModel,
        ITransactionTypeModel
    {
        [XmlElement(ElementName = "authorization_code")]
        public string AuthorizationCode { get; set; }
        public string ResponseCode { get; set; }
        public TransactionStates? Status { get; set; }
        public TransactionTypes TransactionType { get; set; }
    }
}