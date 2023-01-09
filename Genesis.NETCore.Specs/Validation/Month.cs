using Genesis.NetCore.Common;
using Genesis.NetCore.Entities;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Specs.Validation
{
    class describe_month_validation : describe_entity_property_validation
    {
        public describe_month_validation(IEntity entity, string monthPropertyName, string csePropertyName = null)
            : base(entity, monthPropertyName, csePropertyName)
        {
        }

        public void it_should_report_invalid_month_on_validation()
        {
            propertyInfo.SetValue(entity, (Constants.MinMonthValue - 1).ToString());

            if (string.IsNullOrEmpty(csePropertyName))
            {
                var expectedErrorsCount = 1;
                var expectedMemberNames = new string[] { propertyName };
                var expectedErrorMessages = new string[] { ValidationMessages.MonthOutOfRange(propertyName) };

                entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
            }
            else
            {
                csePropertyInfo.SetValue(entity, true);
                entity.should_be_valid();
            }
        }

        public void it_should_report_month_out_of_range_on_validation()
        {
            propertyInfo.SetValue(entity, (Constants.MaxMonthValue + 1).ToString());

            if (string.IsNullOrEmpty(csePropertyName))
            {
                var expectedErrorsCount = 1;
                var expectedMemberNames = new string[] { propertyName };
                var expectedErrorMessages = new string[] { ValidationMessages.MonthOutOfRange(propertyName) };

                entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
            }
            else
            {
                csePropertyInfo.SetValue(entity, true);
                entity.should_be_valid();
            }
        }

        public void it_should_report_valid_month_on_validation()
        {
            propertyInfo.SetValue(entity, Constants.MinMonthValue.ToString());
            entity.should_be_valid();
        }

        public void it_should_report_valid_month_on_validation_2()
        {
            propertyInfo.SetValue(entity, Constants.MaxMonthValue.ToString());
            entity.should_be_valid();
        }
    }
}
