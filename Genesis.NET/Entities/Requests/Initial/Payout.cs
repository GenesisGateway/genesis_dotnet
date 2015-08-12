using System;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "Payout")]
    public class Payout : InitialRequest
    {
        public Payout()
        {
            Type = TransactionTypes.Payout;
        }
    }
}
