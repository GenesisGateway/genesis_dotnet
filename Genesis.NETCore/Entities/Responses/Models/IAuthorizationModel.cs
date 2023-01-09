using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IAuthorizationModel
    {
        [XmlElement(ElementName = "authorization_code")]
        string AuthorizationCode { get; set; }
    }
}
