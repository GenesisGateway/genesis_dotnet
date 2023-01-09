using System.Xml.Serialization;
using Genesis.NetCore.Common;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IMoneyModel
    {
        [XmlIgnore]
        decimal Amount { get; set; }

        [XmlElement(ElementName = "amount")]
        string ProxyAmount { get; set; }

        [XmlElement(ElementName = "currency")]
        Iso4217CurrencyCodes Currency { get; set; }

        [XmlElement(ElementName = "partial_approval")]
        bool? PartialApproval { get; set; }
    }
}