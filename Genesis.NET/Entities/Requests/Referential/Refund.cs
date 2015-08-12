using System;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Referential
{
    [XmlRoot("payment_transaction", Namespace = "Refund")]
    public class Refund : QuantitativeReferentialRequest
    {
        public Refund()
        {
            Type = TransactionTypes.Refund;
        }
    }
}
