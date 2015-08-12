using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "SofortiDeal")]
    public class SofortiDeal : AlternativePaymentMethod
    {
        [Required]
        [StringLength(3)]
        [XmlElement(ElementName = "customer_bank_id")]
        public string CustomerBankId { get; set; }

        [Required]
        [StringLength(30)]
        [XmlElement(ElementName = "bank_account_number")]
        public string BankAccountNumber { get; set; }

        public SofortiDeal()
        {
            Type = TransactionTypes.SofortiDeal;
        }
    }
}
