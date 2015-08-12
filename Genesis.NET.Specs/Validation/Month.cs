using System;
using System.Linq;
using Genesis.Net.Common;
using Genesis.Net.Entities;
using Genesis.Net.Validations;

namespace Genesis.Net.Specs.Validation
{
    class describe_month_validation : describe_entity_property_validation
    {
        public describe_month_validation(Entity entity, string monthPropertyName)
            : base(entity, monthPropertyName) { }

        public void it_should_report_invalid_month_on_validation()
        {
            propertyInfo.SetValue(entity, Constants.MinMonthValue - 1);

            var expectedErrorsCount = 1;
            var expectedMemberNames = new string[] { propertyName };
            var expectedErrorMessages = new string[] { ValidationMessages.MonthOutOfRange(propertyName) };

            entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
        }

        public void it_should_report_month_out_of_range_on_validation()
        {
            propertyInfo.SetValue(entity, Constants.MaxMonthValue + 1);

            var expectedErrorsCount = 1;
            var expectedMemberNames = new string[] { propertyName };
            var expectedErrorMessages = new string[] { ValidationMessages.MonthOutOfRange(propertyName) };

            entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
        }

        public void it_should_report_valid_month_on_validation()
        {
            propertyInfo.SetValue(entity, Constants.MinMonthValue);
            entity.should_be_valid();
        }

        public void it_should_report_valid_month_on_validation_2()
        {
            propertyInfo.SetValue(entity, Constants.MaxMonthValue);
            entity.should_be_valid();
        }
    }
}
