using Genesis.Net.Entities;
using Genesis.Net.Validations;

namespace Genesis.Net.Specs.Validation
{
    class describe_cvv_validation : describe_entity_property_validation
    {
        public describe_cvv_validation(Entity entity, string cvvPropertyName)
            : base(entity, cvvPropertyName)
        {
        }

        public void it_should_report_invalid_cvv_on_validation()
        {
            propertyInfo.SetValue(entity, "invalid cvv code");

            var expectedErrorsCount = 1;
            var expectedMemberNames = new string[] { propertyName };
            var expectedErrorMessages = new string[] { ValidationMessages.InvalidCvvCode(propertyName) };

            entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
        }

        public void it_should_report_valid_cvv_on_validation()
        {
            propertyInfo.SetValue(entity, "123");
            entity.should_be_valid();
        }
    }
}