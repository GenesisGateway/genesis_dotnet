using System.Xml.Serialization;
using Genesis.Net.Errors;

namespace Genesis.Net.Entities.Responses
{
    internal class ErrorModel
    {
        [XmlIgnore]
        public ErrorCodes Code { get; set; }

        [XmlElement(ElementName = "code")]
        public int ProxyCode
        {
            get
            {
                return (int)Code;
            }
            set
            {
                Code = (ErrorCodes)value;
            }
        }

        [XmlElement(ElementName = "technical_message")]
        public string TechnicalMessage { get; set; }

        [XmlElement(ElementName = "message")]
        public string Message { get; set; }
    }
}