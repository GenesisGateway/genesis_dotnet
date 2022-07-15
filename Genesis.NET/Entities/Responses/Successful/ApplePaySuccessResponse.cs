using CopaceticSoftware.pMixins.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(AvsResponseModel))]
    [pMixin(Mixin = typeof(AuthorizationModel))]
    [pMixin(Mixin = typeof(ConsumerModel))]
    [pMixin(Mixin = typeof(IssuerModel))]
    [XmlRoot("payment_response", Namespace = "ApplePaySuccessResponse")]
    public partial class ApplePaySuccessResponse : AlternativePaymentMethodSuccessResponse
    {
    }
}
