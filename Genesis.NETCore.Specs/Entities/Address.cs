using System.Linq;
using Genesis.NetCore.Common;
using Genesis.NetCore.Entities;
using Genesis.NetCore.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities
{
    [TestClass]
    public class describe_address
    {
        private Address address;

        [TestInitialize]
        public void before_each()
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

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            address.should_serialize_and_deserialize();
        }

        [TestMethod]
        public void it_should_report_invalid_state_on_validation()
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

        [TestMethod]
        public void it_should_report_valid_state_on_validation()
        {
            address.State = "CA";

            var validationErrors = EntitiesValidator.GetValidationErrors(address);
            validationErrors.Count().should_be(0);
        }
    }
}