using System.Xml.Serialization;
using CopaceticSoftware.pMixins.Attributes;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(BlacklistModel))]
    [XmlRoot("blacklist_response", Namespace = "BlacklistSuccessResponse")]
    public partial class BlacklistSuccessResponse : Entity
    {
    }
}