using CopaceticSoftware.pMixins.Attributes;
using System;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(TransactionModel))]
    [pMixin(Mixin = typeof(AsyncTransactionModel))]
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(MoneyModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [XmlRoot("wpf_payment", Namespace = "WpfCreateSuccessResponse")]
    public partial class WpfCreateSuccessResponse : Entity
    {
    }
}