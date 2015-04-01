using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Genesis.Net.Common;
using Genesis.Net.Validations;

namespace Genesis.Net.Entities.Requests.Referential
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
#if GenerateXmlSerializers
        public string ProxyAmount
#else
        internal string ProxyAmount
#endif
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