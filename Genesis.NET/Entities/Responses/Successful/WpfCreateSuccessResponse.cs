using CopaceticSoftware.pMixins.Attributes;
using System;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(TransactionModel))]
    [pMixin(Mixin = typeof(AsyncTransactionModel))]
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(ConsumerModel))]
    [pMixin(Mixin = typeof(MoneyModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [pMixin(Mixin = typeof(InvalidTransactionsForAmountModel))]
    [pMixin(Mixin = typeof(ThreeDSModel))]
    [pMixin(Mixin = typeof(FundsStatusModel))]
    [XmlRoot("wpf_payment", Namespace = "WpfCreateSuccessResponse")]
    public partial class WpfCreateSuccessResponse : Entity
    {
    }
}