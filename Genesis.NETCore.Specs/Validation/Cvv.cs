using Genesis.NetCore.Entities;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Specs.Validation
{
    class describe_cvv_validation : describe_entity_property_validation
    {
        public describe_cvv_validation(IEntity entity, string cvvPropertyName, string csePropertyName = null)
            : base(entity, cvvPropertyName, csePropertyName)
        {
        }

        public void it_should_report_invalid_cvv_on_validation()
        {
            propertyInfo.SetValue(entity, "invalid cvv code");

            if (string.IsNullOrEmpty(csePropertyName))
            {
                var expectedErrorsCount = 1;
                var expectedMemberNames = new string[] { propertyName };
                var expectedErrorMessages = new string[] { ValidationMessages.InvalidCvvCode(propertyName) };

                entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
            }
            else
            {
                csePropertyInfo.SetValue(entity, true);
                entity.should_be_valid();
            }
        }

        public void it_should_report_valid_cvv_on_validation()
        {
            propertyInfo.SetValue(entity, "123");
            entity.should_be_valid();
        }
    }
}