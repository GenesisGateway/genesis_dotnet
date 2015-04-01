using System;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Referential
{
    [XmlRoot("payment_transaction", Namespace = "VoidRequest")]
    public class VoidRequest : ReferentialRequest
    {
        public VoidRequest()
        {
            Type = TransactionTypes.Void;
        }
    }
}
