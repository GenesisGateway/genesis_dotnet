using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IChargebackModel
    {
        [XmlElement(ElementName = "chargeback_response")]
        ChargebackResponse[] Chargebacks { get; set; }
    }
}