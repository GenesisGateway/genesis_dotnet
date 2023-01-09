using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Query
{
    [XmlRoot("retrieval_request_request", Namespace = "SingleRetrievalRequest")]
    public class SingleRetrievalRequest : Request
    {
        public override string ApiPath
        {
            get
            {
                return "retrieval_requests";
            }
        }

        [XmlElement(ElementName = "arn")]
        public string Arn { get; set; }

        [XmlElement(ElementName = "original_transaction_unique_id")]
        public string OriginalTransactionUniqueId { get; set; }

        public SingleRetrievalRequest()
        {
        }
    }
}