using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "Authorize3d")]
    public class Authorize3d : CardTransaction3d
    {
        public Authorize3d() : base(TransactionTypes.Authorize3d)
        {
        }
    }
}