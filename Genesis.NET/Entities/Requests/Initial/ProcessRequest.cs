using Genesis.Net.Common;
using Genesis.Net.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial
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

        [XmlIgnore]
        public TransactionTypes Type { get; set; }

        [XmlElement(ElementName = "transaction_type")]
        public string ProxyType
        {
            get
            {
                if (Type == null)
                    return string.Empty;
                else
                    return Type.ToString();
            }
            set
            {
                Type = TransactionTypes.TransactionTypesByName.Value[value];
            }
        }

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
#if GenerateXmlSerializers
        public string ProxyAmount
#else
        internal string ProxyAmount
#endif
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
