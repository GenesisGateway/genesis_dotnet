using System.Xml.Serialization;
using Genesis.NetCore.Errors;
namespace Genesis.NetCore.Entities.Responses.Error
{
    public interface IErrorResponse
    {
        [XmlElement(ElementName = "code")]
        ErrorCodes Code { get; set; }

        [XmlElement(ElementName = "technical_message")]
        string TechnicalMessage { get; set; }

        [XmlElement(ElementName = "message")]
        string Message { get; set; }
    }
}