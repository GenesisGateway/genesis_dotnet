using System;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Referential
{
    [XmlRoot("payment_transaction", Namespace = "Credit")]
    public class Credit : QuantitativeReferentialRequest
    {
        public Credit()
        {
            Type = TransactionTypes.Credit;
        }
    }
}