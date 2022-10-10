using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "Authorize")]
    public class Authorize : CardTransaction
    {
        public Authorize() : base(TransactionTypes.Authorize)
        {
        }
    }
}