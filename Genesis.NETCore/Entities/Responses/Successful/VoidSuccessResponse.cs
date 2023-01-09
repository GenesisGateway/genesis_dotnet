using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "VoidSuccessResponse")]
    public class VoidSuccessResponse :
        MoneyAndTransactionModel,
        IMoneyModel,
        ITransactionModel,
        IAcquirerModel,
        IAuthorizationModel,
        ITransactionStatusModel,
        ITransactionTypeModel,
        IIssuerModel
    {
        public bool SentToAcquirer { get; set; }

        [XmlElement(ElementName = "authorization_code")]
        public string AuthorizationCode { get; set; }
        public TransactionStates? Status { get; set; }
        public TransactionTypes TransactionType { get; set; }
        public string ResponseCode { get; set; }
    }
}
