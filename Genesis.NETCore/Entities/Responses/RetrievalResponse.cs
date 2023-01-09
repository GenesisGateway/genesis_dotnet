using System.Xml.Serialization;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses
{
    public class RetrievalResponse :
        RetrievalResponseModel,
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