using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class PaymentTransactionsModel
    {
        [XmlElement(ElementName = "payment_transaction")]
        public PaymentResponse[] Payments { get; set; }
    }
}