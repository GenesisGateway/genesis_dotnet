using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Referential
{
    [XmlRoot("payment_transaction", Namespace = "Refund")]
    public class Refund : QuantitativeReferentialRequest
    {
        public Refund()
        {
            TransactionType = TransactionTypes.Refund;
        }
    }
}
