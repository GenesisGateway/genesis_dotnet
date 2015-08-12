using CopaceticSoftware.pMixins.Attributes;
using System;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(AcquirerModel))]
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(TransactionModel))]
    [pMixin(Mixin = typeof(MoneyModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [XmlRoot("payment_response", Namespace = "CaptureSuccessResponse")]
    public partial class CaptureSuccessResponse : Entity
    {
    }
}
