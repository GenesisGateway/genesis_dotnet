using System;
using System.Xml.Serialization;
using CopaceticSoftware.pMixins.Attributes;

namespace Genesis.Net.Entities.Responses.Successful
{
    /// <summary>
    /// This class is deprecated. Please use: <see cref="CardTransactionSuccessResponse">CardTransactionSuccessResponse</see>
    /// </summary>
    [Obsolete("This class is deprecated. Please use: Entities.Responses.Successful.CardTransactionSuccessResponse")]
    [pMixin(Mixin = typeof(AuthorizationModel))]
    [pMixin(Mixin = typeof(AcquirerModel))]
    [pMixin(Mixin = typeof(MotoModel))]
    [pMixin(Mixin = typeof(IssuerModel))]
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(TransactionModel))]
    [pMixin(Mixin = typeof(RecurringAdviceModel))]
    [pMixin(Mixin = typeof(DynamicDescriptorModel))]
    [pMixin(Mixin = typeof(MoneyModel))]
    [XmlRoot("payment_response", Namespace = "InitRecurringSaleSuccessResponse")]
    public partial class InitRecurringSaleSuccessResponse : Entity
    {
    }
}
