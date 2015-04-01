using CopaceticSoftware.pMixins.Attributes;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(ChargebackModel))]
    [pMixin(Mixin = typeof(ItemsRangeModel))]
    [XmlRoot("chargeback_responses", Namespace = "MultiChargebackSuccessResponse")]
    public partial class MultiChargebackSuccessResponse : Entity
    {
        [XmlElement(ElementName = "chargeback_response")]
        public ChargebackResponse[] Chargebacks { get;  set; }
    }
}