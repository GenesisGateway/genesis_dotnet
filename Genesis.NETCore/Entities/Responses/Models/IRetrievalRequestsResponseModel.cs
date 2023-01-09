using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IRetrievalRequestsResponseModel
    {
        [XmlElement(ElementName = "retrieval_request_response")]
        RetrievalResponse[] Retrievals { get; set; }
    }
}