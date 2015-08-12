using System;
using System.Linq;
using Genesis.Net.Common;
using Genesis.Net.Entities;
using Genesis.Net.Validations;
using NSpec;

namespace Genesis.Net.Specs.Entities
{
    class describe_address : nspec
    {
        private Address address;

        void before_each()
        {
            address = new Address()
            {
                FirstName = "Travis",
                LastName = "Pastrana",
                Address1 = "Muster Str. 12",
                Address2 = "Test street",
                State = "CA",
                ZipCode = "10178",
                City = "Los Angeles",
                Country = Iso3166CountryCodes.US
            };
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            var actualAddress = SpecHelper.SerializeAndDeserialize<Address>(address);
            actualAddress.should_be(address);
        }

        void it_should_report_invalid_state_on_validation()
        {
            address.State = "BS";

            var validationErrors = EntitiesValidator.GetValidationErrors(address);
            validationErrors.Count().should_be(1);

            var actualMemberName = validationErrors.First().MemberNames.First();
            actualMemberName.should_be("State");

            var expectedErrorMessages = new string[] {
                ValidationMessages.InvalidStateCode(address.State, address.Country)
            };

            var actualErrorMessages = validationErrors.Select(e => e.ErrorMessage).ToArray();
            actualErrorMessages.should_be(expectedErrorMessages);
        }

        void it_should_report_valid_state_on_validation()
        {
            address.State = "CA";

            var validationErrors = EntitiesValidator.GetValidationErrors(address);
            validationErrors.Count().should_be(0);
        }
    }
}