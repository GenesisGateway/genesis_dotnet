using System.Xml.Serialization;
using Genesis.NetCore.Entities.Responses.Models;
using Genesis.NetCore.Errors;
namespace Genesis.NetCore.Entities.Responses.Error
{
    public interface IErrorResponse : ITechnicalMessageModel
    {
        [XmlElement(ElementName = "code")]
        ErrorCodes Code { get; set; }
    }
}