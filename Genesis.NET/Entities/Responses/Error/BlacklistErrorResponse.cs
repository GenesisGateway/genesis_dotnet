using System.Xml.Serialization;
using CopaceticSoftware.pMixins.Attributes;

namespace Genesis.Net.Entities.Responses.Error
{
    [pMixin(Mixin = typeof(ErrorModel))]
    [XmlRoot("blacklist_response", Namespace = "BlacklistErrorResponse")]
    public partial class BlacklistErrorResponse : Entity, IErrorResponse
    {
    }
}