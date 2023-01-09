using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "RecurringSaleSuccessResponse")]
    public class RecurringSaleSuccessResponse :
        MoneyAndTransactionModel,
        IMoneyModel,
        ITransactionModel,
        IAcquirerModel,
        IAuthorizationModel,
        IIssuerModel,
        IRecurringAdviceModel,
        ITransactionStatusModel,
        ITransactionTypeModel
    {
        public bool SentToAcquirer { get; set; }
        public string AuthorizationCode { get; set; }
        public string ResponseCode { get; set; }
        public string RecurringAdviceCode { get; set; }
        public string RecurringAdviceText { get; set; }
        public TransactionStates? Status { get; set; }
        public TransactionTypes TransactionType { get; set; }
    }
}
