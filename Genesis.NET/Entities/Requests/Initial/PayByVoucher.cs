using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "PayByVoucher")]
    public class PayByVoucher : ProcessRequest
    {
        [Required]
        [XmlElement(ElementName="product_name")]
        public string ProductName { get; set; }

        [Required]
        [XmlElement(ElementName="product_category")]
        public string ProductCategory { get; set; }

        [Required]
        [XmlElement(ElementName="card_holder")]
        public string CardHolder { get; set; }

        [Required]
        [XmlElement(ElementName = "customer_phone")]
        public string CustomerPhone { get; set; }

        [Required]
        [EmailAddress]
        [XmlElement(ElementName = "customer_email")]
        public string CustomerEmail { get; set; }

        [Required]
        [XmlElement(ElementName = "customer_id_number")]
        public string CustomerIdNumber { get; set; }

        [Required]
        [XmlElement(ElementName = "customer_bank_id")]
        public string CustomerBankId { get; set; }

        [Required]
        [XmlElement(ElementName = "bank_account_number")]
        public string BankAccountNumber { get; set; }

        public PayByVoucher()
        {
            Type = TransactionTypes.PayByVoucher;
        }
    }
}
