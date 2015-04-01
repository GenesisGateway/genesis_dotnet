using System.Xml.Serialization;
using CopaceticSoftware.pMixins.Attributes;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(AuthorizationModel))]
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(RetrievalResponseModel))]
    [pMixin(Mixin = typeof(CustomerModel))]
    [XmlRoot("retrieval_request_response", Namespace = "SingleRetrievalRequestSuccessResponse")]
    public partial class SingleRetrievalRequestSuccessResponse : Entity
    {
    }
}
