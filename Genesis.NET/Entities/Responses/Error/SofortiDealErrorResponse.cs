using CopaceticSoftware.pMixins.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses.Error
{
    [XmlRoot("payment_response", Namespace = "SofortiDealErrorResponse")]
    public class SofortiDealErrorResponse : AlternativePaymentMethodErrorResponse
    {
    }
}
