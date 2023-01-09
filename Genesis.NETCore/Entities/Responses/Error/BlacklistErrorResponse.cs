using System.Xml.Serialization;
using Genesis.NetCore.Entities.Responses.Models;
using Genesis.NetCore.Errors;

namespace Genesis.NetCore.Entities.Responses.Error
{
    [XmlRoot("blacklist_response", Namespace = "BlacklistErrorResponse")]
    public class BlacklistErrorResponse :
        IResponse,
        IErrorResponse,
        IErrorModel
    {
        public ErrorCodes Code { get; set; }
        public string TechnicalMessage { get; set; }
        public string Message { get; set; }
    }
}