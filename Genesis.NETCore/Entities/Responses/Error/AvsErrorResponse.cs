using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;
using Genesis.NetCore.Errors;

namespace Genesis.NetCore.Entities.Responses.Error
{
    [XmlRoot("payment_response", Namespace = "AvsErrorResponse")]
    public class AvsErrorResponse :
        TransactionAndMotoModel,
        ITransactionModel,
        IMotoModel,
        IAcquirerModel,
        IErrorResponse,
        IIssuerModel,
        ITransactionStatusModel,
        ITransactionTypeModel
    {
        public bool SentToAcquirer { get; set; }
        public ErrorCodes Code { get; set; }
        public string TechnicalMessage { get; set; }
        public string Message { get; set; }
        public string ResponseCode { get; set; }
        public TransactionStates? Status { get; set; }
        public TransactionTypes TransactionType { get; set; }
    }
}