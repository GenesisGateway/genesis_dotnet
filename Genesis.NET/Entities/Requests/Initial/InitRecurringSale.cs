using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "InitRecurringSale")]
    public class InitRecurringSale : CardTransaction
    {
        public InitRecurringSale() : base(TransactionTypes.InitRecurringSale)
        {
        }
    }
}
