using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IRecurringAdviceModel
    {
        [XmlElement(ElementName = "recurring_advice_code")]
        string RecurringAdviceCode { get; set; }

        [XmlElement(ElementName = "recurring_advice_text")]
        string RecurringAdviceText { get; set; }
    }
}