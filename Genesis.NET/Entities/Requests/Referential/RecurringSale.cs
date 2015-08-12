using System;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Referential
{
    [XmlRoot("payment_transaction", Namespace = "RecurringSale")]
    public class RecurringSale : QuantitativeReferentialRequest
    {
        public RecurringSale()
        {
            Type = TransactionTypes.RecurringSale;
        }
    }
}