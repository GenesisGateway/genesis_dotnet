using Genesis.NetCore.Common;
using System.ComponentModel.DataAnnotations;

namespace Genesis.NetCore.Validations
{
    internal class MoneyRangeAttribute : ValidationAttribute
    {
        private readonly int MinMinorAmount = 1;

        public readonly string CurrencyPropertyName;

        public MoneyRangeAttribute(int minMinorAmount = 1, string currencyPropertyName = "Currency")
        {
            this.MinMinorAmount = minMinorAmount;
            this.CurrencyPropertyName = currencyPropertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var majorAmount = (decimal)value;
            var currencyCode = GetCurrencyCode(validationContext.ObjectInstance);

            if (Iso4217Currencies.TryConvertMajorToMinor(currencyCode, majorAmount, out var minorAmount))
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