using System.Xml.Serialization;
using CopaceticSoftware.pMixins.Attributes;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(ItemsRangeModel))]
    [pMixin(Mixin = typeof(PaymentResponseModel))]
    [XmlRoot("payment_responses", Namespace = "MultiReconcileSuccessResponse")]
    public partial class MultiReconcileSuccessResponse : Entity
    {
    }
}