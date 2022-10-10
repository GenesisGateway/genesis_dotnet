using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "Sale3d")]
    public class Sale3d : CardTransaction3d
    {
        public Sale3d() : base(TransactionTypes.Sale3d)
        {
        }
    }
}