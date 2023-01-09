using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    public interface IFundsStatusModel
    {
        [XmlElement(ElementName = "funds_status")]
        string FundsStatus { get; set; }
    }
}
