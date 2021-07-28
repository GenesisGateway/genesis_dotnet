using Genesis.Net.Entities.Attributes.Request.Financial.Business;
using System;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Referential
{
    [XmlRoot("payment_transaction", Namespace = "Capture")]
    public class Capture : QuantitativeReferentialRequest
    {
        [XmlElement(ElementName = "business_attributes")]
        public BusinessAttributes BusinessAttributes { get; set; }

        public Capture()
        {
            Type = TransactionTypes.Capture;
        }
    }
}