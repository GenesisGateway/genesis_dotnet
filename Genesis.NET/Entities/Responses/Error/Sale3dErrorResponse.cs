using System;
using System.Xml.Serialization;
using CopaceticSoftware.pMixins.Attributes;

namespace Genesis.Net.Entities.Responses.Error
{
    /// <summary>
    /// This class is deprecated. Please use: <see cref="CardTransactionErrorResponse">CardTransactionSuccessResponse</see>
    /// </summary>
    [Obsolete("This class is deprecated. Please use: Entities.Responses.Successful.CardTransactionErrorResponse")]
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