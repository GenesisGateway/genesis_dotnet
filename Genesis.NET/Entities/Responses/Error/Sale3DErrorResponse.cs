using CopaceticSoftware.pMixins.Attributes;
using System.Xml.Serialization;

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
    [XmlRoot("payment_response", Namespace = "Sale3DErrorResponse")]
    public partial class Sale3dErrorResponse : Entity, IErrorResponse
    {
    }
}