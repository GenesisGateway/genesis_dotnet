using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Error
{
    [XmlRoot("retrieval_request_response", Namespace = "SingleRetrievalRequestErrorResponse")]
    public class SingleRetrievalRequestErrorResponse : TransactionStatusErrorResponse
    {
    }
}