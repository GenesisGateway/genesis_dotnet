using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    public class InvalidTransactionsForAmountModel
    {
        [XmlElement("invalid_transactions_for_amount")]
        public string InvalidTransactionsForAmount { get; set; }
    }
}
