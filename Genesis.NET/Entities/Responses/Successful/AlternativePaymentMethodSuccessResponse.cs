using CopaceticSoftware.pMixins.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(TransactionModel))]
    [pMixin(Mixin = typeof(MoneyModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [pMixin(Mixin = typeof(AcquirerModel))]
    public partial class AlternativePaymentMethodSuccessResponse : Entity
    {
        [XmlElement(ElementName = "redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
