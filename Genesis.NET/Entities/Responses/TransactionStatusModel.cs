using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class TransactionStatusModel
    {
        [XmlElement(ElementName = "status")]
        public string Status { get; set; }
    }
}
