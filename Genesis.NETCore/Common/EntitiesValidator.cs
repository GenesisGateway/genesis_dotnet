using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using Genesis.NetCore.Entities;

namespace Genesis.NetCore.Common
{
    public static class EntitiesValidator
    {
        public static IEnumerable<ValidationResult> GetValidationErrors<T>(T entity, bool validateSubEntities = true) where T : IEntity
        {
            var validationErrors = new List<ValidationResult>();

            var context = new ValidationContext(entity);
            Validator.TryValidateObject(entity, context, validationErrors, true);
            if (validateSubEntities)
            {
                RecursiveValidation(entity, validationErrors);
            }

            return validationErrors;
        }

        public static void Validate<T>(T entity, bool validateSubEntities = true) where T : IEntity
        {
            var context = new ValidationContext(entity);
            Validator.ValidateObject(entity, context, true);
            if (validateSubEntities)
            {
                RecursiveValidation(entity);
            }
        }

        private static void RecursiveValidation<T>(T entity, List<ValidationResult> validationErrors = null)
        {
            foreach (var propertyInfo in entity.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (propertyInfo.CanRead &&
                    propertyInfo.PropertyType.IsClass &&
                    propertyInfo.PropertyType.GetInterfaces().Contains(typeof(IEntity)))
                {
                    var propertyValue = propertyInfo.GetValue(entity);
                    if (propertyValue != null)
                    {
                        var propertyValueContext = new ValidationContext(propertyValue);
                        if (validationErrors != null)
                        {
                            Validator.TryValidateObject(propertyValue, propertyValueContext, validationErrors, true);
                            RecursiveValidation(propertyValue, validationErrors);
                        }
                        else
                        {
                            Validator.ValidateObject(propertyValue, propertyValueContext, true);
                            RecursiveValidation(propertyValue);
                        }
                    }
                }
            }
        }
    }
}