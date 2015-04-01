using CopaceticSoftware.pMixins.Attributes;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses.Error
{
    [pMixin(Mixin = typeof(AcquirerModel))]
    [pMixin(Mixin = typeof(MotoModel))]
    [pMixin(Mixin = typeof(IssuerModel))]
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(TransactionModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [XmlRoot("payment_response", Namespace = "AccountVerificationErrorResponse")]
    public partial class AccountVerificationErrorResponse : Entity, IErrorResponse
    {
    }
}