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
            address.on_validation_should_have(1, new[] { "State" }, new[] {
                ValidationMessages.InvalidStateCode(address.State, address.Country)
            });
        }

        [TestMethod]
        public void it_should_report_valid_state_on_validation()
        {
            address.State = "CA";
            address.should_be_valid();
        }

        [TestMethod]
        public void it_should_report_invalid_state_on_empty_string_validation()
        {
            address.State = string.Empty;
            address.on_validation_should_have(1, new[] { "State" }, new[] { "The provided value couldn't be recognized." });
        }
    }
}