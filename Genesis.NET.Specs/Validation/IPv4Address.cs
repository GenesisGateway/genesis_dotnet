using System;
using System.Linq;
using Genesis.Net.Entities;
using Genesis.Net.Validations;

namespace Genesis.Net.Specs.Validation
{
    class describe_ipv4_address_validation : describe_entity_property_validation
    {
        public describe_ipv4_address_validation(Entity entity, string ipv4AddressPropertyName)
            : base(entity, ipv4AddressPropertyName) { }

        public void it_should_report_invalid_ipv4_address_on_validation()
        {
            propertyInfo.SetValue(entity, "256.10.100.10");

            var expectedErrorsCount = 1;
            var expectedMemberNames = new string[] { propertyName };
            var expectedErrorMessages = new string[] { ValidationMessages.InvalidIPv4Address((string)propertyInfo.GetValue(entity)) };

            entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
        }

        public void it_should_report_valid_ipv4_address_on_validation()
        {
            propertyInfo.SetValue(entity, "250.10.100.10");
            entity.should_be_valid();
        }
    }
}
