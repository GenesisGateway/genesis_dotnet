using System.ComponentModel.DataAnnotations;

namespace Genesis.NetCore.Validations
{
    public class RangeOnPropertyValueAttribute : OnPropertyValueValidationAttribute
    {
        public RangeOnPropertyValueAttribute(string propertyName, object propertyValue, int minimum, int maximum)
            : base(propertyName, propertyValue, new RangeAttribute(minimum, maximum))
        {
        }

        public RangeOnPropertyValueAttribute(string propertyName, object propertyValue, double minimum, double maximum)
            : base(propertyName, propertyValue, new RangeAttribute(minimum, maximum))
        {
        }
    }
}
