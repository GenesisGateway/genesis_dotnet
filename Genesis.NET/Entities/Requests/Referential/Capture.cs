using System;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Referential
{
    [XmlRoot("payment_transaction", Namespace = "Capture")]
    public class Capture : QuantitativeReferentialRequest
    {
        public Capture()
        {
            Type = TransactionTypes.Capture;
        }
    }
}