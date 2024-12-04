using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "BankPayoutSuccessResponse")]
    public class BankPayoutSuccessResponse :
        MoneyAndTransactionModel,
        IMoneyModel,
        ITransactionModel,
        ITechnicalMessageModel,
        IAcquirerModel,
        ITransactionStatusModel,
        ITransactionTypeModel
    {
        public TransactionTypes TransactionType { get; set; }
        public TransactionStates? Status { get; set; }
        public string TechnicalMessage { get; set; }
        public string Message { get; set; }
        public bool SentToAcquirer { get; set; }
    }
}