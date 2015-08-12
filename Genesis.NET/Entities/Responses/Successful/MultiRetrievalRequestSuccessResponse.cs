using System.Xml.Serialization;
using CopaceticSoftware.pMixins.Attributes;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(ItemsRangeModel))]
    [pMixin(Mixin = typeof(RetrievalRequestsResponseModel))]
    [XmlRoot("retrieval_request_responses", Namespace = "MultiRetrievalRequestSuccessResponse")]
    public partial class MultiRetrievalRequestSuccessResponse : Entity
    {
        [XmlElement(ElementName = "retrieval_request_response")]
        public RetrievalResponse[] Retrievals { get;  set; }
    }
}