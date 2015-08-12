using System.Xml.Serialization;
using Genesis.Net.Common;

namespace Genesis.Net.Entities.Requests.Query
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

        [XmlElement(ElementName="arn")]
        public string Arn { get; set; }

        [XmlElement(ElementName="original_transaction_unique_id")]
        public string OriginalTransactionUniqueId { get; set; }

        public SingleRetrievalRequest()
        {
        }
    }
}