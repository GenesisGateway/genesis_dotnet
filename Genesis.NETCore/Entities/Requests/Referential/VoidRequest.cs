using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Referential
{
    [XmlRoot("payment_transaction", Namespace = "VoidRequest")]
    public class VoidRequest : ReferentialRequest
    {
        public VoidRequest()
        {
            TransactionType = TransactionTypes.Void;
        }
    }
}
