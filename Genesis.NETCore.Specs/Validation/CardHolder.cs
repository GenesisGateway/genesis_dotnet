using Genesis.NetCore.Entities;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Specs.Validation
{
    class describe_card_holder_validation : describe_entity_property_validation
    {
        public describe_card_holder_validation(IEntity entity, string cardNumberPropertyName, string csePropertyName = null)
            : base(entity, cardNumberPropertyName, csePropertyName) { }

        public void it_should_report_invalid_card_holder_on_validation()
        {
            propertyInfo.SetValue(entity, new string('h', 256));

            if (string.IsNullOrEmpty(csePropertyName))
            {
                var expectedErrorsCount = 1;
                var expectedMemberNames = new string[] { propertyName };
                var expectedErrorMessages = new string[] { ValidationMessages.StringTooLong(propertyName, 255) };

                entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
            }
            else
            {
                csePropertyInfo.SetValue(entity, true);
                entity.should_be_valid();
            }
        }

        public void it_should_report_valid_card_holder_on_validation()
        {
            propertyInfo.SetValue(entity, new string('h', 255));
            entity.should_be_valid();
        }
    }
}
