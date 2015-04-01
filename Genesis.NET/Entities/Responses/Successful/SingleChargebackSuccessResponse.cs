using System;
using System.Xml.Serialization;
using CopaceticSoftware.pMixins.Attributes;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(AuthorizationModel))]
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(MoneyModel))]
    [pMixin(Mixin = typeof(RetrievalResponseModel))]
    [pMixin(Mixin = typeof(CustomerModel))]
    [XmlRoot("chargeback_response", Namespace = "SingleChargebackSuccessResponse")]
    public partial class SingleChargebackSuccessResponse : Entity
    {
    }
}