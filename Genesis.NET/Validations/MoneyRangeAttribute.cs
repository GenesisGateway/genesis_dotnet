using Genesis.Net.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Genesis.Net.Validations
{
    internal class MoneyRangeAttribute : ValidationAttribute
    {
        private const int MinMinorAmount = 1;

        public readonly string CurrencyPropertyName;

        public MoneyRangeAttribute(string currencyPropertyName = "Currency")
        {
            CurrencyPropertyName = currencyPropertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var majorAmount = (decimal)value;
            var currencyCode = GetCurrencyCode(validationContext.ObjectInstance);
            int minorAmount;
            if (Iso4217Currencies.TryConvertMajorToMinor(currencyCode, majorAmount, out minorAmount))
            {
                if (minorAmount >= MinMinorAmount)
                {
                    return ValidationResult.Success;
                }

                return new ValidationResult(ValidationMessages.AmountOutOfRange, new string[] { validationContext.MemberName });
            }

            return ValidationResult.Success;
        }

        private Iso4217CurrencyCodes GetCurrencyCode(object instance)
        {
            var currencyCode = (Iso4217CurrencyCodes)instance.GetType().GetProperty(CurrencyPropertyName).GetValue(instance, null);
            return currencyCode;
        }
    }
}