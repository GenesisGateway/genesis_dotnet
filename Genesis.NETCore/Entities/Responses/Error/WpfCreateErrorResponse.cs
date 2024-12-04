using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;
using Genesis.NetCore.Errors;

namespace Genesis.NetCore.Entities.Responses.Error
{
    [XmlRoot("wpf_payment", Namespace = "WpfCreateErrorResponse")]
    public class WpfCreateErrorResponse :
        TransactionModel,
        ITransactionModel,
        IErrorResponse,
        ITransactionStatusModel,
        ITransactionTypeModel
    {
        public ErrorCodes Code { get; set; }
        public string TechnicalMessage { get; set; }
        public string Message { get; set; }
        public TransactionStates? Status { get; set; }
        public TransactionTypes TransactionType { get; set; }
    }
}