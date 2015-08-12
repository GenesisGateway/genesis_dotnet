using Genesis.Net.Common;
using Genesis.Net.Entities;
using Genesis.Net.Validations;

namespace Genesis.Net.Specs.Validation
{
    class describe_year_validation : describe_entity_property_validation
    {
        public describe_year_validation(Entity entity, string yearPropertyName)
            : base(entity, yearPropertyName)
        {
        }

        public void it_should_report_invalid_year_on_validation()
        {
            propertyInfo.SetValue(entity, Constants.MinYearValue - 1);

            var expectedErrorsCount = 1;
            var expectedMemberNames = new string[] { propertyName };
            var expectedErrorMessages = new string[] { ValidationMessages.YearOutOfRange(propertyName) };

            entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
        }

        public void it_should_report_year_out_of_range_on_validation()
        {
            propertyInfo.SetValue(entity, Constants.MaxYearValue + 1);

            var expectedErrorsCount = 1;
            var expectedMemberNames = new string[] { propertyName };
            var expectedErrorMessages = new string[] { ValidationMessages.YearOutOfRange(propertyName) };

            entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
        }

        public void it_should_report_valid_year_on_validation()
        {
            propertyInfo.SetValue(entity, Constants.MinYearValue);
            entity.should_be_valid();
        }

        public void it_should_report_valid_year_on_validation_2()
        {
            propertyInfo.SetValue(entity, Constants.MaxYearValue);
            entity.should_be_valid();
        }
    }
}