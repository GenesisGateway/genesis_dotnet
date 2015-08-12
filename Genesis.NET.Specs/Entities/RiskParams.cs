using System;
using System.Linq;
using Genesis.Net.Validations;
using NSpec;
using Genesis.Net.Entities;
using Genesis.Net.Common;

namespace Genesis.Net.Specs.Entities
{
    class describe_risk_params : nspec
    {
        private RiskParams riskParams;

        void before_each()
        {
            riskParams = new RiskParams()
            {
                Ssn = "test_snn",
                MacAddress = "test_mac_ddress",
                SessionId = "test_session_id",
                UserId = "test_user_id",
                UserLevel = "test_user_level",
                Email = "test@test.com",
                RemoteIp = "10.100.10.100",
                SerialNumber = "test_serial_number"
            };
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            var actualRiskParams = SpecHelper.SerializeAndDeserialize<RiskParams>(riskParams);
            actualRiskParams.should_be(riskParams);
        }

        void it_should_report_too_long_strings_on_validation()
        {
            int maxLengthAllowed = 128;
            int minLengthNotAllowed = maxLengthAllowed + 1;
            string minStringNotAllowed = new String('*', minLengthNotAllowed);

            riskParams.Ssn = minStringNotAllowed;
            riskParams.MacAddress = minStringNotAllowed;
            riskParams.SessionId = minStringNotAllowed;
            riskParams.UserId = minStringNotAllowed;
            riskParams.UserLevel = minStringNotAllowed;
            riskParams.Email = minStringNotAllowed + "@test.com";
            riskParams.Phone = minStringNotAllowed;
            riskParams.SerialNumber = minStringNotAllowed;

            var validationErrors = EntitiesValidator.GetValidationErrors(riskParams);
            validationErrors.Count().should_be(8);

            var expectedMembers = new string[] {
                "Ssn", "MacAddress", "SessionId", "UserId", "UserLevel", "Email", "Phone", "SerialNumber"
            }.OrderBy(m => m);

            var actualMembers = SpecHelper.GetMemberNamesInAscendingOrder(validationErrors);
            actualMembers.should_be(expectedMembers);

            var expectedErrorMessages = expectedMembers
                .Select(m => ValidationMessages.StringTooLong(m, maxLengthAllowed)).ToArray().OrderBy(m => m);

            var actualErrorMessages = SpecHelper.GetErrorMessagesInAscendingOrder(validationErrors);
            actualErrorMessages.should_be(expectedErrorMessages);
        }

        void it_should_report_invalid_email_address_on_validation()
        {
            riskParams.Email = "hello.world.com";

            var validationErrors = EntitiesValidator.GetValidationErrors(riskParams);
            validationErrors.Count().should_be(1);

            var expectedMember = "Email";
            var actualMember = validationErrors.First().MemberNames.First();
            actualMember.should_be(expectedMember);

            var expectedErrorMessage = ValidationMessages.InvalidEmail("Email");
            var actualErrorMessage = validationErrors.First().ErrorMessage;
            actualErrorMessage.should_be(expectedErrorMessage);
        }

        void it_should_report_valid_email_address_on_validation()
        {
            riskParams.Email = "hello@world.com";

            var validationErrors = EntitiesValidator.GetValidationErrors(riskParams);
            validationErrors.Count().should_be(0);
        }

        void it_should_report_invalid_ipv4_address_on_validation()
        {
            riskParams.RemoteIp = "256.10.100.10";

            var validationErrors = EntitiesValidator.GetValidationErrors(riskParams);
            validationErrors.Count().should_be(1);

            var expectedMember = "RemoteIp";
            var actualMember = validationErrors.First().MemberNames.First();
            actualMember.should_be(expectedMember);

            var expectedErrorMessage = ValidationMessages.InvalidIPv4Address(riskParams.RemoteIp);
            var actualErrorMessage = validationErrors.First().ErrorMessage;
            actualErrorMessage.should_be(expectedErrorMessage);
        }

        void it_should_report_valid_ipv4_address_on_validation()
        {
            riskParams.RemoteIp = "250.10.100.10";

            var validationErrors = EntitiesValidator.GetValidationErrors(riskParams);
            validationErrors.Count().should_be(0);
        }
    }
}
