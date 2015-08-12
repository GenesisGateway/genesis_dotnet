using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class IssuerModel
    {
        [XmlElement(ElementName = "response_code")]
        public string ResponseCode { get; set; }
    }
}