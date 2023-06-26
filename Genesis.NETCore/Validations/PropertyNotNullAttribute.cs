using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Enums.ManagedRecurring;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Genesis.NetCore.Validations
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class PropertyNotNullAttribute : ValidationAttribute
    {
        private readonly string propertyToValidateName;
        private readonly string currentPropertyValue;

        public PropertyNotNullAttribute(string propertyToValidateName, string currentPropertyValue)
        {
            this.propertyToValidateName = propertyToValidateName;
            this.currentPropertyValue = currentPropertyValue;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && value.ToString().ToLower() == this.currentPropertyValue)
            {
                var property = validationContext.ObjectInstance.GetType().GetProperty(propertyToValidateName);
                var propertyValue = property.GetValue(validationContext.ObjectInstance, null);

                if (propertyValue == null)
                {
                    return new ValidationResult(string.Format("Property {0} is required", this.propertyToValidateName));
                }
            }
            
            return ValidationResult.Success;
        }
    }
}
