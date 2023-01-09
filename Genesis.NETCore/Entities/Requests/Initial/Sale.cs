using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "Sale")]
    public class Sale : CardTransaction
    {
        public Sale() : base(TransactionTypes.Sale)
        {
        }
    }
}
