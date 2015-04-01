using CopaceticSoftware.pMixins.Attributes;
using System;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(AuthorizationModel))]
    [pMixin(Mixin = typeof(AvsResponseModel))]
    [pMixin(Mixin = typeof(AcquirerModel))]
    [pMixin(Mixin = typeof(MotoModel))]
    [pMixin(Mixin = typeof(IssuerModel))]
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(TransactionModel))]
    [XmlRoot("payment_response", Namespace = "AccountVerificationSuccessResponse")]
    public partial class AccountVerificationSuccessResponse : Entity
    {
    }
}
