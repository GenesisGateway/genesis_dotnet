using System.Xml.Serialization;
using CopaceticSoftware.pMixins.Attributes;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(TransactionModel))]
    [pMixin(Mixin = typeof(MoneyModel))]
    [pMixin(Mixin = typeof(AcquirerModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [XmlRoot("payment_response", Namespace = "EzeeWalletSuccessResponse")]
    public partial class EzeeWalletSuccessResponse : Entity
    {
        [XmlElement(ElementName = "redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
