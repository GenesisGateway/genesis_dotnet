using System;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class AuthorizationModel
    {
        [XmlElement(ElementName = "authorization_code")]
        public string AuthorizationCode { get; set; }
    }
}
