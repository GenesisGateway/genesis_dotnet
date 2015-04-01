using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class ChargebackModel
    {
        [XmlElement(ElementName = "chargeback_response")]
        public ChargebackResponse[] Chargebacks { get; set; }
    }
}