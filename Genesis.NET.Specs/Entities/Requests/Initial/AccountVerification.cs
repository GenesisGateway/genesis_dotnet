using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial
{
    class describe_account_verification : nspec
    {
        EntityMock<AccountVerification> accountVerificationMock;

        void before_each()
        {
            accountVerificationMock = RequestMocksFactory.CreateValidAccountVerification();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            accountVerificationMock.Instance.should_serialize_and_deserialize<AccountVerification>();
        }

        void it_should_validate_required_properties()
        {
            accountVerificationMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "CardHolder", "CardNumber");
        }

        void it_should_validate_amount()
        {
            accountVerificationMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            accountVerificationMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_validate_month()
        {
            accountVerificationMock.Instance.on_validation_should_behave_like_month("ExpirationMonth");
        }

        void it_should_validate_year()
        {
            accountVerificationMock.Instance.on_validation_should_behave_like_year("ExpirationYear");
        }

        void it_should_validate_card_number()
        {
            accountVerificationMock.Instance.on_validation_should_behave_like_card_number("CardNumber");
        }

        void it_should_validate_cvv()
        {
            accountVerificationMock.Instance.on_validation_should_behave_like_cvv("Cvv");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            accountVerificationMock.Instance.should_serialize_to(accountVerificationMock.Xml);
        }
    }
}
