using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class RecurringAdviceModel
    {
        [XmlElement(ElementName = "recurring_advice_code")]
        public string RecurringAdviceCode { get; set; }

        [XmlElement(ElementName = "recurring_advice_text")]
        public string RecurringAdviceText { get; set; }
    }
}