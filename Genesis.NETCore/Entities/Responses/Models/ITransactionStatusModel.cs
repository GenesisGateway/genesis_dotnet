using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface ITransactionStatusModel
    {
        [XmlElement(ElementName = "status")]
        TransactionStates? Status { get; set; }
    }
}
