using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Genesis.NetCore.Common;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    public abstract class ProcessRequest : Request
    {
        private readonly Money money = new Money();

        public override string ApiPath
        {
            get
            {
                return "process";
            }
        }

        [XmlElement(ElementName = "transaction_type")]
        public TransactionTypes TransactionType { get; set; }

        [StringLength(255)]
        [Required]
        [XmlElement(ElementName = "transaction_id")]
        public string Id { get; set; }

        [StringLength(255)]
        [XmlElement(ElementName = "usage")]
        public string Usage { get; set; }

        /// <summary>
        /// Represents the amount of money in major currency units
        /// </summary>
        [MoneyRange]
        [Required]
        [XmlIgnore]
        public decimal Amount
        {
            get
            {
                return money.MajorAmount;
            }
            set
            {
                money.MajorAmount = value;
            }
        }

        [XmlElement(ElementName = "amount")]
        public string ProxyAmount
        {
            get
            {
                return money.MinorAmount.ToString();
            }
            set
            {
                money.NativeAmount = value;
            }
        }

        [Required]
        [XmlElement(ElementName = "currency")]
        public Iso4217CurrencyCodes Currency
        {
            get
            {
                return money.CurrencyCode;
            }
            set
            {
                money.CurrencyCode = value;
            }
        }

        [IPv4Address]
        [XmlElement(ElementName = "remote_ip")]
        public string RemoteIp { get; set; }
    }
}
