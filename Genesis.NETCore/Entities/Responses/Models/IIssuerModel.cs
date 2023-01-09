using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IIssuerModel
    {
        [XmlElement(ElementName = "response_code")]
        string ResponseCode { get; set; }
    }
}