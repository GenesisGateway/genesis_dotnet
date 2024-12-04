using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "SingleReconcileSuccessResponse")]
    public class SingleReconcileSuccessResponse :
        MoneyAndTransactionModel,
        IMoneyModel,
        ITransactionModel,
        IAcquirerModel,
        IAuthorizationModel,
        ICustomerModel,
        ITechnicalMessageModel,
        IIssuerModel,
        IPaymentAddressModel,
        IThreeDSModel,
        ITransactionStatusModel,
        ITransactionTypeModel
    {
        public bool SentToAcquirer { get; set; }
        public string AuthorizationCode { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string TechnicalMessage { get; set; }
        public string Message { get; set; }
        public string ResponseCode { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public string TerminalToken { get; set; }
        public ThreeDSElementModel ThreeDS { get; set; }
        public TransactionStates? Status { get; set; }
        public TransactionTypes TransactionType { get; set; }
    }
}