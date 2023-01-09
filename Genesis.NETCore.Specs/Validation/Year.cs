using Genesis.NetCore.Common;
using Genesis.NetCore.Entities;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Specs.Validation
{
    class describe_year_validation : describe_entity_property_validation
    {
        public describe_year_validation(IEntity entity, string yearPropertyName, string csePropertyName = null)
            : base(entity, yearPropertyName, csePropertyName)
        {
        }

        public void it_should_report_invalid_year_on_validation()
        {
            propertyInfo.SetValue(entity, (Constants.MinYearValue - 1).ToString());

            if (string.IsNullOrEmpty(csePropertyName))
            {
                var expectedErrorsCount = 1;
                var expectedMemberNames = new string[] { propertyName };
                var expectedErrorMessages = new string[] { ValidationMessages.YearOutOfRange(propertyName) };

                entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
            }
            else
            {
                csePropertyInfo.SetValue(entity, true);
                entity.should_be_valid();
            }
        }

        public void it_should_report_year_out_of_range_on_validation()
        {
            propertyInfo.SetValue(entity, (Constants.MaxYearValue + 1).ToString());

            if (string.IsNullOrEmpty(csePropertyName))
            {
                var expectedErrorsCount = 1;
            var expectedMemberNames = new string[] { propertyName };
            var expectedErrorMessages = new string[] { ValidationMessages.YearOutOfRange(propertyName) };

            entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
            }
            else
            {
                csePropertyInfo.SetValue(entity, true);
                entity.should_be_valid();
            }
        }

        public void it_should_report_valid_year_on_validation()
        {
            propertyInfo.SetValue(entity, Constants.MinYearValue.ToString());
            entity.should_be_valid();
        }

        public void it_should_report_valid_year_on_validation_2()
        {
            propertyInfo.SetValue(entity, Constants.MaxYearValue.ToString());
            entity.should_be_valid();
        }
    }
}