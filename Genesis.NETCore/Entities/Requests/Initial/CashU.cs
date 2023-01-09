using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "CashU")]
    public class CashU : AlternativePaymentMethod
    {
        public CashU()
        {
            TransactionType = TransactionTypes.CashU;
        }
    }
}
