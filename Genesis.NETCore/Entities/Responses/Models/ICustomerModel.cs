using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface ICustomerModel
    {
        [XmlElement(ElementName = "customer_email")]
        string CustomerEmail { get; set; }

        [XmlElement(ElementName = "customer_phone")]
        string CustomerPhone { get; set; }
    }
}