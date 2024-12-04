using System.ComponentModel.DataAnnotations;
using System.Linq;
using Genesis.NetCore.Common;

namespace Genesis.NetCore.Validations
{
    public class SupportedValuesValidationAttribute : ValidationAttribute
    {
        private readonly string propertyName;
        private readonly object[] propertyValuesAllowed;

        public SupportedValuesValidationAttribute(string propertyName, params object[] propertyValuesAllowed)
        {
            this.propertyName = propertyName;
            this.propertyValuesAllowed = propertyValuesAllowed;
        }

        public SupportedValuesValidationAttribute(string propertyName, params Iso4217CurrencyCodes[] iso4217CurrencyCodes)
        {
            this.propertyName = propertyName;
            this.propertyValuesAllowed = iso4217CurrencyCodes.Cast<object>().ToArray();
        }
        public override bool IsValid(object value)
        {
            var validationContext = new ValidationContext(value);
            return IsValid(value, validationContext) == ValidationResult.Success;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var contextObject = validationContext.ObjectInstance;
            var propertyInfo = contextObject.GetType().GetProperty(propertyName);
            if (propertyInfo == null)
            {
                return new ValidationResult(string.Format("Can't find property {0}", propertyName));
            }

            var contextPropertyValue = propertyInfo.GetValue(contextObject);

            if (propertyValuesAllowed.Contains(contextPropertyValue))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult($"{contextPropertyValue} is not supported value for {propertyName}.");
            }
        }
    }
}