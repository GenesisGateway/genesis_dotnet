using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class CustomerModel
    {
        [XmlElement(ElementName = "customer_email")]
        public string CustomerEmail { get; set; }

        [XmlElement(ElementName = "customer_phone")]
        public string CustomerPhone { get; set; }
    }
}