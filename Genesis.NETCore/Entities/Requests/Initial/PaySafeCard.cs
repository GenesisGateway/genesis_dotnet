using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "PaySafeCard")]
    public class PaySafeCard : AlternativePaymentMethod
    {
        public PaySafeCard()
        {
            TransactionType = TransactionTypes.PaySafeCard;
        }
    }
}
