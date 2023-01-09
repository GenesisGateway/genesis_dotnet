using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Query
{
    [XmlRoot("retrieval_request_request", Namespace = "MultiRetrievalRequest")]
    public class MultiRetrievalRequest : QueryByDate
    {
        public override string ApiPath
        {
            get
            {
                return "retrieval_requests/by_date";
            }
        }

        public MultiRetrievalRequest()
        {
        }
    }
}