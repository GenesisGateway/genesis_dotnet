using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "AvsSuccessResponse")]
    public class AvsSuccessResponse :
        TransactionAndMotoModel,
        ITransactionModel,
        IMotoModel,
        IAcquirerModel,
        IAuthorizationModel,
        IAvsResponseModel,
        IIssuerModel,
        ITransactionStatusModel,
        ITransactionTypeModel
    {
        public bool SentToAcquirer { get; set; }
        public string AuthorizationCode { get; set; }
        public string AvsResponseCode { get; set; }
        public string AvsResponseText { get; set; }
        public string ResponseCode { get; set; }
        public TransactionStates? Status { get; set; }
        public TransactionTypes TransactionType { get; set; }
    }
}