using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface ITransactionTypeModel
    {
        [XmlElement(ElementName = "transaction_type")]
        TransactionTypes TransactionType { get; set; }
    }
}