using System;
using System.Linq;
using Genesis.NetCore.Common;
using Genesis.NetCore.Entities;
using Genesis.NetCore.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities
{
    [TestClass]
    public class describe_dynamic_descriptor
    {
        private DynamicDescriptor dynamicDescriptor;

        [TestInitialize]
        public void before_each()
        {
            dynamicDescriptor = new DynamicDescriptor()
            {
                MerchantName = "Test",
                MerchantCity = "Testing Town"
            };
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            dynamicDescriptor.should_serialize_and_deserialize();
        }

        [TestMethod]
        public void it_should_report_invalid_merchant_name_on_validation()
        {
            dynamicDescriptor.MerchantName = new String('*', 26);

            var validationErrors = EntitiesValidator.GetValidationErrors(dynamicDescriptor);
            validationErrors.Count().should_be(1);

            var expectedMembers = "MerchantName";
            var actualMembers = validationErrors.First().MemberNames.First();
            actualMembers.should_be(expectedMembers);

            var expectedErrorMessages = new[] { ValidationMessages.StringTooLong(expectedMembers, 25) };
            var actualErrorMessages = validationErrors.Select(e => e.ErrorMessage).OrderBy(m => m).ToArray();
            actualErrorMessages.should_be(expectedErrorMessages);
        }

        [TestMethod]
        public void it_should_report_valid_merchant_name_on_validation()
        {
            dynamicDescriptor.MerchantName = new String('*', 25);

            var validationErrors = EntitiesValidator.GetValidationErrors(dynamicDescriptor);
            validationErrors.Count().should_be(0);
        }

        [TestMethod]
        public void it_should_report_invalid_merchant_city_on_validation()
        {
            dynamicDescriptor.MerchantCity = new String('*', 14);

            var validationErrors = EntitiesValidator.GetValidationErrors(dynamicDescriptor);
            validationErrors.Count().should_be(1);

            var expectedMembers = "MerchantCity";
            var actualMembers = validationErrors.First().MemberNames.First();
            actualMembers.should_be(expectedMembers);

            var expectedErrorMessages = new[] { ValidationMessages.StringTooLong(expectedMembers, 13) };
            var actualErrorMessages = validationErrors.Select(e => e.ErrorMessage).OrderBy(m => m).ToArray();
            actualErrorMessages.should_be(expectedErrorMessages);
        }

        [TestMethod]
        public void it_should_report_valid_merchant_city_on_validation()
        {
            dynamicDescriptor.MerchantCity = new String('*', 13);

            var validationErrors = EntitiesValidator.GetValidationErrors(dynamicDescriptor);
            validationErrors.Count().should_be(0);
        }
    }
}
