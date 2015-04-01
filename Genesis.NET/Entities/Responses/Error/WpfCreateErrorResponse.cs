using CopaceticSoftware.pMixins.Attributes;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses.Error
{
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [XmlRoot("wpf_payment", Namespace = "WpfCreateErrorResponse")]
    public partial class WpfCreateErrorResponse : Entity, IErrorResponse
    {
    }
}