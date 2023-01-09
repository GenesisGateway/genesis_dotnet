using System.ComponentModel.DataAnnotations;

namespace Genesis.NetCore.Validations
{
    /// <summary>
    /// A validation attribute that runs validations only if context property has some predefined value.
    /// </summary>
    public abstract class OnPropertyValueValidationAttribute : ValidationAttribute
    {
        private readonly string propertyName;
        private readonly object propertyValue;
        private readonly ValidationAttribute attributeToUse;

        public OnPropertyValueValidationAttribute(string propertyName, object propertyValue, ValidationAttribute attributeToUse)
        {
            this.propertyName = propertyName;
            this.propertyValue = propertyValue;
            this.attributeToUse = attributeToUse;
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

            if (contextPropertyValue.Equals(propertyValue))
            {
                return attributeToUse.GetValidationResult(value, validationContext);
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
