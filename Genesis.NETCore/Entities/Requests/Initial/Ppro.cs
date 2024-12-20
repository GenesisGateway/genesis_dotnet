﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "Ppro")]
    public class Ppro : AlternativePaymentMethod
    {
        [XmlElement(ElementName = "payment_type")]
        public PproPaymentType PaymentType { get; set; }

        [StringLength(10)]
        [XmlElement(ElementName = "account_number")]
        public string AccountNumber { get; set; }

        [StringLength(8)]
        [XmlElement(ElementName = "bank_code")]
        public string BankCode { get; set; }

        [StringLength(11)]
        [XmlElement(ElementName = "bic")]
        public string Bic { get; set; }

        [StringLength(22)]
        [XmlElement(ElementName = "iban")]
        public string Iban { get; set; }

        [StringLength(11)]
        [XmlElement(ElementName = "account_phone")]
        public string AccountPhone { get; set; }

        public Ppro()
        {
            TransactionType = TransactionTypes.Ppro;
        }
    }
}
