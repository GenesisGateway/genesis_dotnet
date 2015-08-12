using System;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class AcquirerModel
    {
        [XmlElement(ElementName = "sent_to_acquirer")]
        public bool SentToAcquirer { get; set; }
    }
}
