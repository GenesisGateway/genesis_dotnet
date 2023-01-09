using System.Xml.Serialization;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("retrieval_request_responses", Namespace = "MultiRetrievalRequestSuccessResponse")]
    public class MultiRetrievalRequestSuccessResponse :
        IResponse,
        IItemsRangeModel,
        IRetrievalRequestsResponseModel
    {
        public int ItemsPerPage { get; set; }
        public int PageNumber { get; set; }
        public int TotalCount { get; set; }
        public int PagesCount { get; set; }

        [XmlElement(ElementName = "retrieval_request_response")]
        public RetrievalResponse[] Retrievals { get; set; }
    }
}