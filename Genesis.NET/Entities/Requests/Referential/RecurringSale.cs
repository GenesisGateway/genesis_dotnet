using Genesis.Net.Entities.Attributes.Request.Financial.Business;
using System;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Referential
{
    [XmlRoot("payment_transaction", Namespace = "RecurringSale")]
    public class RecurringSale : QuantitativeReferentialRequest
    {
        [XmlElement(ElementName = "business_attributes")]
        public BusinessAttributes BusinessAttributes { get; set; }

        public RecurringSale()
        {
            Type = TransactionTypes.RecurringSale;
        }
    }
}