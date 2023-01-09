using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "Payout")]
    public class Payout : InitialRequest
    {
        public Payout()
        {
            TransactionType = TransactionTypes.Payout;
        }
    }
}
