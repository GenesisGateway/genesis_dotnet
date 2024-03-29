using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Query
{
    [XmlRoot("chargeback_request", Namespace = "MultiChargeback")]
    public class MultiChargeback : QueryByDate
    {
        public override string ApiPath
        {
            get
            {
                return "chargebacks/by_date";
            }
        }

        public MultiChargeback()
        {
        }
    }
}