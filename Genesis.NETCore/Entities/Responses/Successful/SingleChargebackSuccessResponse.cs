using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("chargeback_response", Namespace = "SingleChargebackSuccessResponse")]
    public class SingleChargebackSuccessResponse : ChargebackResponse
    {
    }
}