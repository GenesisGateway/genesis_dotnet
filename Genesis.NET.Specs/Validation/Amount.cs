using System;
using System.Linq;
using Genesis.Net.Entities;
using Genesis.Net.Validations;

namespace Genesis.Net.Specs.Validation
{
    class describe_amount_validation : describe_entity_property_validation
    {
        public describe_amount_validation(Entity entity, string amountPropertyName)
            : base(entity, amountPropertyName) { }

        public void it_should_report_amount_out_of_range_on_validation()
        {
            propertyInfo.SetValue(entity, 0m);

            var expectedErrorsCount = 1;
            var expectedMemberNames = new string[] { propertyName };
            var expectedErrorMessages = new string[] { ValidationMessages.AmountOutOfRange };

            entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
        }

        public void it_should_report_amount_out_of_range_on_validation_1()
        {
            propertyInfo.SetValue(entity, -10m);

            var expectedErrorsCount = 1;
            var expectedMemberNames = new string[] { propertyName };
            var expectedErrorMessages = new string[] { ValidationMessages.AmountOutOfRange };

            entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
        }

        public void it_should_report_valid_amount_on_validation()
        {
            propertyInfo.SetValue(entity, 1m);
            entity.should_be_valid();
        }
    }
}
