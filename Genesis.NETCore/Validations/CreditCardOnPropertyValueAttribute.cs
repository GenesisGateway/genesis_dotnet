using System.ComponentModel.DataAnnotations;

namespace Genesis.NetCore.Validations
{
    public class CreditCardOnPropertyValueAttribute : OnPropertyValueValidationAttribute
    {
        public CreditCardOnPropertyValueAttribute(string propertyName, object propertyValue)
            : base(propertyName, propertyValue, new CreditCardAttribute())
        {
        }
    }
}
