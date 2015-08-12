using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Genesis.Net.Entities;

namespace Genesis.Net.Common
{
    public static class EntitiesValidator
    {
        public static IEnumerable<ValidationResult> GetValidationErrors<T>(T entity) where T : Entity
        {
            var validationErrors = new List<ValidationResult>();

            var context = new ValidationContext(entity);
            Validator.TryValidateObject(entity, context, validationErrors, true);

            return validationErrors;
        }

        public static void Validate<T>(T entity) where T : Entity
        {
            var context = new ValidationContext(entity);
            Validator.ValidateObject(entity, context, true);
        }
    }
}