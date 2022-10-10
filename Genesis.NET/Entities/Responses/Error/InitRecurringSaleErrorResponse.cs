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
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(TransactionModel))]
    [pMixin(Mixin = typeof(MoneyModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [XmlRoot("payment_response", Namespace = "InitRecurringSaleErrorResponse")]
    public partial class InitRecurringSaleErrorResponse : Entity, IErrorResponse
    {
    }
}