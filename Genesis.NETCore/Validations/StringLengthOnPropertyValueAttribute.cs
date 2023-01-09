using System.ComponentModel.DataAnnotations;

namespace Genesis.NetCore.Validations
{
    public class StringLengthOnPropertyValueAttribute : OnPropertyValueValidationAttribute
    {
        public StringLengthOnPropertyValueAttribute(string propertyName, object propertyValue, int maximumLength)
            : base(propertyName, propertyValue, new StringLengthAttribute(maximumLength))
        {
        }

        public StringLengthOnPropertyValueAttribute(string propertyName, object propertyValue, int maximumLength, int minimumLength)
            : base(propertyName, propertyValue, new StringLengthAttribute(maximumLength) { MinimumLength = minimumLength })
        {
        }
    }
}
