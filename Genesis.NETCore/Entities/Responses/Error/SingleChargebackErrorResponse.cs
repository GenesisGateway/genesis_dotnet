using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Error
{
    [XmlRoot("chargeback_response", Namespace = "SingleChargebackErrorResponse")]
    public class SingleChargebackErrorResponse : TransactionStatusErrorResponse
    {
    }
}