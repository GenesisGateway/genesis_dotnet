using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Models;
using Genesis.NetCore.Errors;

namespace Genesis.NetCore.Entities.Responses
{
    public partial class PaymentResponse :
        MoneyAndTransactionModel,
        IMoneyModel,
        ITransactionModel,
        IAcquirerModel,
        IAuthorizationModel,
        ICustomerModel,
        IErrorResponse,
        IIssuerModel,
        IPaymentAddressModel,
        ITransactionStatusModel,
        ITransactionTypeModel
    {
        public bool SentToAcquirer { get; set; }
        public string AuthorizationCode { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public ErrorCodes Code { get; set; }
        public string TechnicalMessage { get; set; }
        public string Message { get; set; }
        public string ResponseCode { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public string TerminalToken { get; set; }
        public TransactionStates? Status { get; set; }
        public TransactionTypes TransactionType { get; set; }
    }
}
