using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "Sofort")]
    public class Sofort : AlternativePaymentMethod
    {
        public Sofort()
        {
            TransactionType = TransactionTypes.Sofort;
        }

        [StringLength(12)]
        [XmlElement(ElementName = "customer_bank_id")]
        public string CustomerBankId { get; set; }

        [StringLength(24)]
        [XmlElement(ElementName = "bank_account_number")]
        public string BankAccountNumber { get; set; }
    }
}
