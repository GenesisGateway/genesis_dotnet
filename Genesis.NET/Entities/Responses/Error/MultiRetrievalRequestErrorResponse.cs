using System.Xml.Serialization;
using CopaceticSoftware.pMixins.Attributes;

namespace Genesis.Net.Entities.Responses.Error
{
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [XmlRoot("retrieval_request_response", Namespace = "MultiRetrievalRequestErrorResponse")]
    public partial class MultiRetrievalRequestErrorResponse : Entity, IErrorResponse
    {
    }
}