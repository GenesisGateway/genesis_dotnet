using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Query
{
    [XmlRoot("chargeback_request", Namespace = "SingleChargeback")]
    public class SingleChargeback : Request
    {
        public override string ApiPath
        {
            get
            {
                return "chargebacks";
            }
        }

        [XmlElement(ElementName="arn")]
        public string Arn { get; set; }

        [XmlElement(ElementName="original_transaction_unique_id")]
        public string OriginalTransactionUniqueId { get; set; }

        public SingleChargeback()
        {
        }
    }
}