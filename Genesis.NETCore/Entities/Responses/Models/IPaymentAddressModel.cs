using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IPaymentAddressModel
    {
        [XmlElement(ElementName = "billing_address")]
        Address BillingAddress { get; set; }

        [XmlElement(ElementName = "shipping_address")]
        Address ShippingAddress { get; set; }

        [XmlElement(ElementName = "terminal_token")]
        string TerminalToken { get; set; }
    }
}