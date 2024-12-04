using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using Genesis.NetCore.Entities;
using Genesis.NetCore.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Validation
{
    public class DescribeSupportedValuesValidation
    {
        private IEnumerable<SupportedValuesValidationAttribute> attributes;
        private readonly IEntity entity;
        private readonly object invalidValue;
        private readonly FieldInfo attributePrpertyNameField;
        private readonly FieldInfo attributePropertyValuesAllowedField;

        public DescribeSupportedValuesValidation(IEntity entity, object invalidValue)
        {
            this.attributes = entity.GetType().GetCustomAttributes<SupportedValuesValidationAttribute>();
            this.entity = entity;
            this.invalidValue = invalidValue;
            this.attributePrpertyNameField = typeof(SupportedValuesValidationAttribute).GetField("propertyName", BindingFlags.NonPublic | BindingFlags.Instance);
            this.attributePropertyValuesAllowedField = typeof(SupportedValuesValidationAttribute).GetField("propertyValuesAllowed", BindingFlags.NonPublic | BindingFlags.Instance);
        }


        public void it_ShouldReportValidValueOnValidation()
        {
            foreach (var attribute in attributes)
            {
                var propertyName = attributePrpertyNameField.GetValue(attribute) as string;
                var validObjectsArray = attributePropertyValuesAllowedField.GetValue(attribute) as object[];
                var validValue = validObjectsArray[0];
                entity.GetType().GetProperty(propertyName).SetValue(entity, validValue);
                Assert.IsTrue(attribute.IsValid(entity));

                var validationContext = new ValidationContext(entity);
                var methodIsValid = attribute.GetType().GetMethod("IsValid", BindingFlags.NonPublic | BindingFlags.Instance);
                var validationResult = methodIsValid.Invoke(attribute, new object[] { entity, validationContext }) as ValidationResult;
                Assert.AreEqual(validationResult, ValidationResult.Success);
            }
        }

        public void it_ShouldReportInvalidValueOnValidation()
        {
            foreach (var attribute in attributes)
            {
                var propertyName = attributePrpertyNameField.GetValue(attribute) as string;
                var validObjectsArray = attributePropertyValuesAllowedField.GetValue(attribute) as object[];
                if (validObjectsArray.Contains(invalidValue))
                {
                    throw new InternalTestFailureException($"Parameter {nameof(invalidValue)} contains valid value.");
                }

                entity.GetType().GetProperty(propertyName).SetValue(entity, invalidValue);
                Assert.IsFalse(attribute.IsValid(entity));

                var validationContext = new ValidationContext(entity);
                var methodIsValid = attribute.GetType().GetMethod("IsValid", BindingFlags.NonPublic | BindingFlags.Instance);
                var validationResult = methodIsValid.Invoke(attribute, new object[] { entity, validationContext }) as ValidationResult;
                Assert.AreNotEqual(validationResult, ValidationResult.Success);
            }
        }
    }
}
