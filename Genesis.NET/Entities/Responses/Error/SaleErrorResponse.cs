using System.Xml.Serialization;
using CopaceticSoftware.pMixins.Attributes;

namespace Genesis.Net.Entities.Responses.Error
{
    [pMixin(Mixin = typeof(AcquirerModel))]
    [pMixin(Mixin = typeof(AuthorizationModel))]
    [pMixin(Mixin = typeof(MotoModel))]
    [pMixin(Mixin = typeof(IssuerModel))]
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(TransactionModel))]
    [pMixin(Mixin = typeof(GamingModel))]
    [pMixin(Mixin = typeof(DynamicDescriptorModel))]
    [pMixin(Mixin = typeof(MoneyModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [XmlRoot("payment_response", Namespace = "SaleErrorResponse")]
    public partial class SaleErrorResponse : Entity, IErrorResponse
    {
    }
}