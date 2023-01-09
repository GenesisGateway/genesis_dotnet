using System.Xml.Serialization;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses
{
    public partial class ChargebackResponse :
        MoneyAndRetrievalResponseModel,
        IMoneyModel,
        IRetrievalResponseModel,
        IAuthorizationModel,
        ICustomerModel,
        ITransactionTypeModel
    {
        [XmlElement(ElementName = "authorization_code")]
        public string AuthorizationCode { get; set; }

        [XmlElement(ElementName = "customer_email")]
        public string CustomerEmail { get; set; }

        [XmlElement(ElementName = "customer_phone")]
        public string CustomerPhone { get; set; }

        [XmlElement(ElementName = "transaction_type")]
        public TransactionTypes TransactionType { get; set; }
    }
}
