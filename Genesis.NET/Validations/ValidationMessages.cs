using Genesis.Net.Common;
using System;
using System.Linq;

namespace Genesis.Net.Validations
{
    public static class ValidationMessages
    {
        private const string RequiredFieldTemplate = "The {0} field is required.";
        private const string InvalidUSStateCodeTemplate = "{0} is not a valid ISO 3166-2 state code in {1}";
        private const string StringTooLongTemplate = "The field {0} must be a string with a maximum length of {1}.";
        private const string StringOutOfRangeTemplate = "The field {0} must be a string with a minimum length of {1} and a maximum length of {2}.";
        private const string InvalidEmailTemplate = "The {0} field is not a valid e-mail address.";
        private const string InvalidIPv4AddressTemplate = "{0} is not a valid IPv4 address.";
        private const string NumberOutOfRangeTemplate = "The field {0} must be between {1} and {2}.";
        private const string InvalidCardNumberTemplate = "The {0} field is not a valid credit card number.";
        private const string InvalidUrlTemplate = "The {0} field is not a valid URL.";

        public const string AmountOutOfRange = "The minimum required minor amount in your chosen currency is 1";

        public static string Required(string name)
        {
            return String.Format(RequiredFieldTemplate, name);
        }

        public static string InvalidStateCode(string state, Iso3166CountryCodes countryCode)
        {
            return String.Format(InvalidUSStateCodeTemplate, state, countryCode.ToString());
        }

        public static string StringTooLong(string name, int charsCountLimit)
        {
            return String.Format(StringTooLongTemplate, name, charsCountLimit);
        }

        public static string InvalidEmail(string fieldName)
        {
            return String.Format(InvalidEmailTemplate, fieldName);
        }

        public static string InvalidIPv4Address(string ipAddress)
        {
            return String.Format(InvalidIPv4AddressTemplate, ipAddress);
        }

        public static string MonthOutOfRange(string fieldName)
        {
            return String.Format(NumberOutOfRangeTemplate, fieldName,
                Constants.MinMonthValue, Constants.MaxMonthValue);
        }

        public static string YearOutOfRange(string fieldName)
        {
            return String.Format(NumberOutOfRangeTemplate, fieldName,
                Constants.MinYearValue, Constants.MaxYearValue);
        }

        public static string InvalidCardNumber(string fieldName)
        {
            return String.Format(InvalidCardNumberTemplate, fieldName);
        }

        public static string InvalidCvvCode(string fieldName)
        {
            return String.Format(StringOutOfRangeTemplate, fieldName,
                Constants.MinCvvCodeLength, Constants.MaxCvvCodeLength);
        }

        public static string InvalidUrl(string fieldName)
        {
            return String.Format(InvalidUrlTemplate, fieldName);
        }
    }
}
