using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Genesis.Net.Entities;
using Genesis.Net.Common;
using System.Collections.Generic;

namespace Genesis.Net.Validations
{
    internal class StateCodeAttribute : ValidationAttribute
    {
        public StateCodeAttribute()
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            string stateCode = value as string;
            if (string.IsNullOrEmpty(stateCode))
            {
                return new ValidationResult(String.Format("The provided value couldn't be recognized."),
                    new string[] { validationContext.MemberName });
            }

            var address = validationContext.ObjectInstance as Address;
            if (address == null)
            {
                throw new Exception(String.Format("The StateCode validation attribute can be used only on members of the {0} class", typeof(Address).FullName));
            }

            HashSet<string> validStateCodes;
            if (iso3166_2_StateCodes.TryGetValue(address.Country, out validStateCodes))
            {
                if (!validStateCodes.Contains(stateCode))
                {
                    return new ValidationResult(ValidationMessages.InvalidStateCode(stateCode, address.Country),
                        new string[] { validationContext.MemberName });
                }
            }

            return ValidationResult.Success;
        }

        private static readonly Dictionary<Iso3166CountryCodes, HashSet<string>> iso3166_2_StateCodes =
            new Dictionary<Iso3166CountryCodes, HashSet<string>>()
            {
                {
                        Iso3166CountryCodes.US, new HashSet<string>()
                                                {
                                                    "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID",
                                                    "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS",
                                                    "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK",
                                                    "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VT", "WA", "WV",
                                                    "WI", "WY", "DC", "AS", "GU", "MP", "PR", "UM", "VI"
                                                }
                },
                {
                        Iso3166CountryCodes.CA, new HashSet<string>()
                                                {
                                                    "AB", "BC", "MB", "NB", "NL", "NS", "ON", "PE", "QC", "SK", "NT", "NU", "YT"
                                                }
                }
            };
    }
}