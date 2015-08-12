using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "PaySafeCard")]
    public class PaySafeCard : AlternativePaymentMethod
    {
        public PaySafeCard()
        {
            Type = TransactionTypes.PaySafeCard;
        }
    }
}
