using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IAsyncTransactionModel
    {
        [XmlElement(ElementName = "redirect_url")]
        string RedirectUrl { get; set; }
    }
}