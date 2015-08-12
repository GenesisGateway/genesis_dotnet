using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class AsyncTransactionModel
    {
        [XmlElement(ElementName = "redirect_url")]
        public string RedirectUrl { get; set; }
    }
}