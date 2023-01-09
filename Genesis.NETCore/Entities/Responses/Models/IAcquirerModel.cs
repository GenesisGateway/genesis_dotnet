using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IAcquirerModel
    {
        [XmlElement(ElementName = "sent_to_acquirer")]
        bool SentToAcquirer { get; set; }
    }
}
