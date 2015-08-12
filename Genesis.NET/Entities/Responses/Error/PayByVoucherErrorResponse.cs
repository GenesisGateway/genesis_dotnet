using CopaceticSoftware.pMixins.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses.Error
{
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(TransactionModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [pMixin(Mixin = typeof(AcquirerModel))]
    [pMixin(Mixin = typeof(MoneyModel))]
    [XmlRoot("payment_response", Namespace = "PayByVoucherErrorResponse")]
    public partial class PayByVoucherErrorResponse : Entity, IErrorResponse
    {
    }
}
