using CopaceticSoftware.pMixins.Attributes;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses.Error
{
    /// <remarks />
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
    [pMixin(Mixin = typeof(AvsResponseModel))]
    [pMixin(Mixin = typeof(CvvResultCodeModel))]
    [pMixin(Mixin = typeof(RetrievalReferenceNumberModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [pMixin(Mixin = typeof(ThreeDSModel))]
    [XmlRoot("payment_response", Namespace = "CardTransactionErrorResponse")]
    public partial class CardTransactionErrorResponse : Entity, IErrorResponse
    {
    }
}
