using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Error
{
    [XmlRoot("wpf_payment", Namespace = "WpfReconcileErrorResponse")]
    public class WpfReconcileErrorResponse : TransactionStatusErrorResponse
    {
    }
}