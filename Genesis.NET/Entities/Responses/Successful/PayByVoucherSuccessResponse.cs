using CopaceticSoftware.pMixins.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(TransactionModel))]
    [pMixin(Mixin = typeof(MoneyModel))]
    [pMixin(Mixin = typeof(AcquirerModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [XmlRoot("payment_response", Namespace = "PayByVoucherSuccessResponse")]
    public partial class PayByVoucherSuccessResponse : Entity
    {
        [XmlElement(ElementName = "redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
