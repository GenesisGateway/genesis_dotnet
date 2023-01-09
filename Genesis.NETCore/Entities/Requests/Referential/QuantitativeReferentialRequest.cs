using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Genesis.NetCore.Common;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Entities.Requests.Referential
{
    public abstract class QuantitativeReferentialRequest : ReferentialRequest
    {
        private readonly Money money = new Money();

        /// <summary>
        /// Represents the amount of money in major currency units
        /// </summary>
        [MoneyRange]
        [Required]
        [XmlIgnore]
        public decimal Amount
        {
            get { return money.MajorAmount; }
            set { money.MajorAmount = value; }
        }

        [XmlElement(ElementName = "amount")]
        public string ProxyAmount
        {
            get { return money.MinorAmount.ToString(); }
            set { money.NativeAmount = value; }
        }

        [Required]
        [XmlElement(ElementName = "currency")]
        public Iso4217CurrencyCodes Currency
        {
            get { return money.CurrencyCode; }
            set { money.CurrencyCode = value; }
        }
    }
}