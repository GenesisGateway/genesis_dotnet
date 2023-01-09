using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Referential
{
    [XmlRoot("payment_transaction", Namespace = "Credit")]
    public class Credit : QuantitativeReferentialRequest
    {
        public Credit()
        {
            TransactionType = TransactionTypes.Credit;
        }
    }
}