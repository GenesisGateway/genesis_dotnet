using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "Authorize")]
    public class Authorize : CardTransaction
    {
        public Authorize() : base(TransactionTypes.Authorize)
        {
        }
    }
}