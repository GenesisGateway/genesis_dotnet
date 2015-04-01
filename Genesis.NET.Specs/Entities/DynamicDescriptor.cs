using System;
using System.Linq;
using Genesis.Net.Validations;
using NSpec;
using Genesis.Net.Entities;
using Genesis.Net.Common;

namespace Genesis.Net.Specs.Entities
{
    class describe_dynamic_descriptor : nspec
    {
        private DynamicDescriptor dynamicDescriptor;

        void before_each()
        {
            dynamicDescriptor = new DynamicDescriptor()
            {
                MerchantName = "Test",
                MerchantCity = "Testing Town"
            };
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            var actualDynamicDescriptor = SpecHelper.SerializeAndDeserialize<DynamicDescriptor>(dynamicDescriptor);
            actualDynamicDescriptor.should_be(dynamicDescriptor);
        }

        void it_should_report_invalid_merchant_name_on_validation()
        {
            dynamicDescriptor.MerchantName = new String('*', 26);

            var validationErrors = EntitiesValidator.GetValidationErrors(dynamicDescriptor);
            validationErrors.Count().should_be(1);

            var expectedMembers = "MerchantName";
            var actualMembers = validationErrors.First().MemberNames.First();
            actualMembers.should_be(expectedMembers);

            var expectedErrorMessages = ValidationMessages.StringTooLong(expectedMembers, 25);
            var actualErrorMessages = validationErrors.Select(e => e.ErrorMessage).OrderBy(m => m).ToArray();
            actualErrorMessages.should_be(expectedErrorMessages);
        }

        void it_should_report_valid_merchant_name_on_validation()
        {
            dynamicDescriptor.MerchantName = new String('*', 25);

            var validationErrors = EntitiesValidator.GetValidationErrors(dynamicDescriptor);
            validationErrors.Count().should_be(0);
        }

        void it_should_report_invalid_merchant_city_on_validation()
        {
            dynamicDescriptor.MerchantCity = new String('*', 14);

            var validationErrors = EntitiesValidator.GetValidationErrors(dynamicDescriptor);
            validationErrors.Count().should_be(1);

            var expectedMembers = "MerchantCity";
            var actualMembers = validationErrors.First().MemberNames.First();
            actualMembers.should_be(expectedMembers);

            var expectedErrorMessages = ValidationMessages.StringTooLong(expectedMembers, 13);
            var actualErrorMessages = validationErrors.Select(e => e.ErrorMessage).OrderBy(m => m).ToArray();
            actualErrorMessages.should_be(expectedErrorMessages);
        }

        void it_should_report_valid_merchant_city_on_validation()
        {
            dynamicDescriptor.MerchantCity = new String('*', 13);

            var validationErrors = EntitiesValidator.GetValidationErrors(dynamicDescriptor);
            validationErrors.Count().should_be(0);
        }
    }
}
