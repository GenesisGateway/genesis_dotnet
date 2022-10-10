using Genesis.Net.Entities.Enums;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class TransactionStatusModel
    {
        [XmlElement(ElementName = "status")]
        public TransactionStates? Status { get; set; }
    }
}
