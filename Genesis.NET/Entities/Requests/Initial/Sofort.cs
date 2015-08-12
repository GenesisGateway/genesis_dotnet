using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "Sofort")]
    public class Sofort : AlternativePaymentMethod
    {
        [StringLength(12)]
        [XmlElement(ElementName = "customer_bank_id")]
        public string CustomerBankId { get; set; }

        [StringLength(24)]
        [XmlElement(ElementName = "bank_account_number")]
        public string BankAccountNumber { get; set; }

        public Sofort()
        {
            Type = TransactionTypes.Sofort;
        }
    }
}
