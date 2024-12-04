using Genesis.NetCore.Common;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Business;
using Genesis.NetCore.Entities.Attributes.Request.Financial.Funding;
using Genesis.NetCore.Validations;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    public abstract class CardTransaction : InitialRequest
    {
        private readonly Money money = new Money();

        public CardTransaction(TransactionTypes type)
        {
            TransactionType = type;
        }

        /// <summary>
        /// Represents the amount of money in major currency units
        /// </summary>
        [MoneyRange(0)]
        [Required]
        [XmlIgnore]
        public new decimal Amount
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
        public new string ProxyAmount
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
        public new Iso4217CurrencyCodes Currency
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

        [XmlElement(ElementName = "gaming")]
        public bool? Gaming { get; set; }

        public bool ShouldSerializeGaming()
        {
            return Gaming != null;
        }

        [XmlElement(ElementName = "risk_params")]
        public RiskParams RiskParams { get; set; }

        [XmlElement(ElementName = "dynamic_descriptor_params")]
        public DynamicDescriptor DynamicDescriptorParams { get; set; }

        [XmlElement(ElementName = "business_attributes")]
        public BusinessAttributes BusinessAttributes { get; set; }

        /// <summary>
        /// Funding Transaction Params
        /// </summary>
        [XmlElement(ElementName = "funding")]
        public FundingAttributes Funding { get; set; }
    }
}
