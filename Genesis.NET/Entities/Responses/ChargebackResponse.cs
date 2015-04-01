using System;
using CopaceticSoftware.pMixins.Attributes;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    [pMixin(Mixin = typeof(MoneyModel))]
    public partial class ChargebackResponse : RetrievalResponse
    {
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
