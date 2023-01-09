using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Error
{
    [XmlRoot("payment_response", Namespace = "SingleReconcileErrorResponse")]
    public class SingleReconcileErrorResponse : TransactionStatusErrorResponse
    {
    }
}