using System;
using System.Linq;
using System.Xml.Serialization;
using CopaceticSoftware.pMixins.Attributes;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(TransactionModel))]
    [pMixin(Mixin = typeof(MoneyModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [pMixin(Mixin = typeof(PaymentTransactionsModel))]
    [XmlRoot("wpf_payment", Namespace = "WpfReconcileSuccessResponse")]
    public partial class WpfReconcileSuccessResponse : Entity
    {
    }
}