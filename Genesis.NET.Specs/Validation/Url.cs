using System;
using System.Linq;
using Genesis.Net.Entities;
using Genesis.Net.Validations;

namespace Genesis.Net.Specs.Validation
{
    class describe_url : describe_entity_property_validation
    {
        public describe_url(Entity entity, string urlPropertyName)
            : base(entity, urlPropertyName)
        {
        }

        public void it_should_report_invalid_url_on_validation()
        {
            propertyInfo.SetValue(entity, "http://mw1.hello.com/mw-earth-vectordb/kml-samples/gp/world/gigapxl/$[level]/r$[y]_c$[x].jpg");
            var expectedErrorsCount = 1;
            var expectedMemberNames = new string[] { propertyName };
            var expectedErrorMessages = new string[] { ValidationMessages.InvalidUrl(propertyName) };

            entity.on_validation_should_have(expectedErrorsCount, expectedMemberNames, expectedErrorMessages);
        }

        public void it_should_report_valid_url_on_validation()
        {
            propertyInfo.SetValue(entity, "https://example.com/notify");
            entity.should_be_valid();
        }
    }
}
