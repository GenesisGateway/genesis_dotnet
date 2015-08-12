using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class RetrievalRequestsResponseModel
    {
        [XmlElement(ElementName = "retrieval_request_response")]
        public RetrievalResponse[] Retrievals { get; set; }
    }
}