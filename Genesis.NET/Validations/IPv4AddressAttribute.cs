using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;

namespace Genesis.Net.Validations
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
                return new ValidationResult(String.Format("The provided value couldn't be recognized."));
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