using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "InitRecurringSale3d")]
    public class InitRecurringSale3d : CardTransaction3d
    {
        public InitRecurringSale3d() : base(TransactionTypes.InitRecurringSale3d)
        {
        }
    }
}