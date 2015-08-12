using System;
using System.Linq;
using Genesis.Net.Entities;
using Genesis.Net.Validations;

namespace Genesis.Net.Specs.Validation
{
    class describe_card_number_validation : describe_entity_property_validation
    {
        public describe_card_number_validation(Entity entity, string cardNumberPropertyName)
            : base(entity, cardNumberPropertyName) { }

        public void it_should_report_invalid_card_number_on_validation()
        {
            propertyInfo.SetValue(entity, "invalid card number");

            var expectedErrorsCount = 1;
            var expectedMemberNames = new string[] { propertyName };
            var expectedErrorMessages = new string[] { ValidationMessages.InvalidCardNumber(propertyName) };

            entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
        }

        public void it_should_report_valid_card_number_on_validation()
        {
            propertyInfo.SetValue(entity, CardsNumbers.VisaSuccessfulTransaction);
            entity.should_be_valid();
        }
    }
}
