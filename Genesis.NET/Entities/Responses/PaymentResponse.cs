using System;
using System.Linq;
using CopaceticSoftware.pMixins.Attributes;
using Genesis.Net.Entities.Responses.Error;

namespace Genesis.Net.Entities.Responses
{
    [pMixin(Mixin = typeof(AuthorizationModel))]
    [pMixin(Mixin = typeof(AcquirerModel))]
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(TransactionModel))]
    [pMixin(Mixin = typeof(MoneyModel))]
    [pMixin(Mixin = typeof(PaymentAddressModel))]
    [pMixin(Mixin = typeof(CustomerModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [pMixin(Mixin = typeof(IssuerModel))]
    public partial class PaymentResponse : Entity, IErrorResponse
    {
    }
}
