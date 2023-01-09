using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Error
{
    [XmlRoot("retrieval_request_response", Namespace = "MultiRetrievalRequestErrorResponse")]
    public class MultiRetrievalRequestErrorResponse : TransactionStatusErrorResponse
    {
    }
}