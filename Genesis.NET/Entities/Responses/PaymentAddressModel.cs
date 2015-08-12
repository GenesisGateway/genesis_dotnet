using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class PaymentAddressModel
    {
        [XmlElement(ElementName = "billing_address")]
        public Address BillingAddress { get; set; }

        [XmlElement(ElementName = "shipping_address")]
        public Address ShippingAddress { get; set; }

        [XmlElement(ElementName = "terminal_token")]
        public string TerminalToken { get; set; }
    }
}