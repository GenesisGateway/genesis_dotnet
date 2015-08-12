using System.Xml.Serialization;
using Genesis.Net.Common;

namespace Genesis.Net.Entities.Responses
{
    internal class MoneyModel
    {
        private readonly Money money = new Money();

        /// <summary>
        /// Represents the amount of money in major currency units
        /// </summary>
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

        [XmlElement(ElementName = "partial_approval")]
        public bool? PartialApproval { get; set; }
    }
}