using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;
using Genesis.NetCore.Errors;

namespace Genesis.NetCore.Entities.Responses.Error
{
    public class AlternativePaymentMethodErrorResponse :
        MoneyAndTransactionModel,
        IMoneyModel,
        ITransactionModel,
        IAcquirerModel,
        IErrorResponse,
        ITransactionStatusModel,
        ITransactionTypeModel
    {
        public bool SentToAcquirer { get; set; }
        public ErrorCodes Code { get; set; }
        public string TechnicalMessage { get; set; }
        public string Message { get; set; }
        public TransactionStates? Status { get; set; }
        public TransactionTypes TransactionType { get; set; }
    }
}
