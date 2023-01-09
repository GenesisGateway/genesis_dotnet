using Genesis.NetCore.Entities;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Specs.Validation
{
    class describe_card_number_validation : describe_entity_property_validation
    {
        public describe_card_number_validation(IEntity entity, string cardNumberPropertyName, string csePropertyName = null)
            : base(entity, cardNumberPropertyName, csePropertyName) { }

        public void it_should_report_invalid_card_number_on_validation()
        {
            propertyInfo.SetValue(entity, "invalid card number");

            if (string.IsNullOrEmpty(csePropertyName))
            {
                var expectedErrorsCount = 1;
                var expectedMemberNames = new string[] { propertyName };
                var expectedErrorMessages = new string[] { ValidationMessages.InvalidCardNumber(propertyName) };

                entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
            }
            else
            {
                csePropertyInfo.SetValue(entity, true);
                entity.should_be_valid();
            }
        }

        public void it_should_report_valid_card_number_on_validation()
        {
            propertyInfo.SetValue(entity, CardsNumbers.VisaSuccessfulTransaction);
            entity.should_be_valid();
        }
    }
}
