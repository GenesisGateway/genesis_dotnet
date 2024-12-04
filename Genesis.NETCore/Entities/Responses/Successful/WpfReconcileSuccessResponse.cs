using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("wpf_payment", Namespace = "WpfReconcileSuccessResponse")]
    public class WpfReconcileSuccessResponse :
        MoneyAndTransactionModel,
        IMoneyModel,
        ITransactionModel,
        ITechnicalMessageModel,
        IPaymentTransactionsModel,
        ITransactionStatusModel
    {
        public string TechnicalMessage { get; set; }
        public string Message { get; set; }
        public PaymentResponse[] Payments { get; set; }
        public TransactionStates? Status { get; set; }
    }
}