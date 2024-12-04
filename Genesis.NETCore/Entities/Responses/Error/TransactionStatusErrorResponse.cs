using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;
using Genesis.NetCore.Errors;

namespace Genesis.NetCore.Entities.Responses.Error
{
    public class TransactionStatusErrorResponse :
        IResponse,
        IErrorResponse,
        ITransactionStatusModel
    {
        public ErrorCodes Code { get; set; }
        public string TechnicalMessage { get; set; }
        public string Message { get; set; }
        public TransactionStates? Status { get; set; }
    }
}
