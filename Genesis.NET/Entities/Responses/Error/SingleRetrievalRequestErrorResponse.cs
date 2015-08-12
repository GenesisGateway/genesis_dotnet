using System.Xml.Serialization;
using CopaceticSoftware.pMixins.Attributes;

namespace Genesis.Net.Entities.Responses.Error
{
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [XmlRoot("retrieval_request_response", Namespace = "SingleRetrievalRequestErrorResponse")]
    public partial class SingleRetrievalRequestErrorResponse : Entity, IErrorResponse
    {
    }
}