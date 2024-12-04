using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;
using Genesis.NetCore.Errors;

namespace Genesis.NetCore.Entities.Responses.Error
{
    [XmlRoot("payment_response", Namespace = "BankPayoutErrorResponse")]
    public class BankPayoutErrorResponse :
        MoneyAndTransactionModel,
        IErrorResponse,
        IIssuerModel,
        ITransactionStatusModel,
        ITransactionTypeModel,
        IAcquirerModel
    {
        public ErrorCodes Code { get; set; }
        public string TechnicalMessage { get; set; }
        public string Message { get; set; }
        public TransactionStates? Status { get; set; }
        public TransactionTypes TransactionType { get; set; }
        public bool SentToAcquirer { get; set; }
        string IIssuerModel.ResponseCode { get; set; }
    }
}
