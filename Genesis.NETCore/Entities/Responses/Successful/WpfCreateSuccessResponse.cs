using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("wpf_payment", Namespace = "WpfCreateSuccessResponse")]
    public class WpfCreateSuccessResponse :
        MoneyAndTransactionModel,
        IMoneyModel,
        ITransactionModel,
        IAsyncTransactionModel,
        IConsumerModel,
        ITechnicalMessageModel,
        IFundsStatusModel,
        IInvalidTransactionsForAmountModel,
        IThreeDSModel,
        ITransactionStatusModel,
        ITransactionTypeModel
    {
        public string RedirectUrl { get; set; }
        public string ConsumerId { get; set; }
        public string TechnicalMessage { get; set; }
        public string Message { get; set; }
        public string FundsStatus { get; set; }
        public string InvalidTransactionsForAmount { get; set; }
        public ThreeDSElementModel ThreeDS { get; set; }
        public TransactionStates? Status { get; set; }
        public TransactionTypes TransactionType { get; set; }
    }
}