using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IPaymentTransactionsModel
    {
        [XmlElement(ElementName = "payment_transaction")]
        PaymentResponse[] Payments { get; set; }
    }
}