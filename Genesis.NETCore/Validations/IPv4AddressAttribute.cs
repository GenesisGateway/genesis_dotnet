using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Genesis.NetCore.Validations
{
    internal class IPv4AddressAttribute : ValidationAttribute
    {
        public IPv4AddressAttribute()
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string addressString = value as string;
            if (string.IsNullOrEmpty(addressString))
            {
                return ValidationResult.Success;
            }

            IPAddress address;
            if (IPAddress.TryParse(addressString, out address))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(ValidationMessages.InvalidIPv4Address(addressString), new string[] { validationContext.MemberName });
            }
        }
    }
}