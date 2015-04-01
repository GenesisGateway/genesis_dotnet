using System.Xml.Serialization;
using CopaceticSoftware.pMixins.Attributes;

namespace Genesis.Net.Entities.Responses.Error
{
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [XmlRoot("wpf_payment", Namespace = "WpfReconcileErrorResponse")]
    public partial class WpfReconcileErrorResponse : Entity, IErrorResponse
    {
    }
}