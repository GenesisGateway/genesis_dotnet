using Genesis.NetCore.Entities;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Specs.Validation
{
    class describe_amount_validation : describe_entity_property_validation
    {
        private readonly decimal invalidAmount;

        public describe_amount_validation(IEntity entity, string amountPropertyName, decimal invalidAmount = 0)
            : base(entity, amountPropertyName)
        {
            this.invalidAmount = invalidAmount;
        }

        public void it_should_report_amount_out_of_range_on_validation()
        {
            propertyInfo.SetValue(entity, invalidAmount);

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
