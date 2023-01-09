using System.Xml.Serialization;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("blacklist_response", Namespace = "BlacklistSuccessResponse")]
    public class BlacklistSuccessResponse :
        IResponse,
        IBlacklistModel
    {
        public bool Blacklisted { get; set; }
    }
}