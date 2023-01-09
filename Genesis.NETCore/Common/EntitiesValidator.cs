using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Genesis.NetCore.Entities;

namespace Genesis.NetCore.Common
{
    public static class EntitiesValidator
    {
        public static IEnumerable<ValidationResult> GetValidationErrors<T>(T entity) where T : IEntity
        {
            var validationErrors = new List<ValidationResult>();

            var context = new ValidationContext(entity);
            Validator.TryValidateObject(entity, context, validationErrors, true);

            return validationErrors;
        }

        public static void Validate<T>(T entity) where T : IEntity
        {
            var context = new ValidationContext(entity);
            Validator.ValidateObject(entity, context, true);
        }
    }
}