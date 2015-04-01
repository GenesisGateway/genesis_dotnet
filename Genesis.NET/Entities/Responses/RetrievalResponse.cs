using System;
using CopaceticSoftware.pMixins.Attributes;

namespace Genesis.Net.Entities.Responses
{
    [pMixin(Mixin = typeof(AuthorizationModel))]
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(CustomerModel))]
    [pMixin(Mixin = typeof(RetrievalResponseModel))]
    public partial class RetrievalResponse : Entity
    {
    }
}