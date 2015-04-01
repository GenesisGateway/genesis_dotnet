using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial
{
    class describe_authorize : nspec
    {
        EntityMock<Authorize> authorizeMock;

        void before_each()
        {
            authorizeMock = RequestMocksFactory.CreateValidAuthorize();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            authorizeMock.Instance.should_serialize_and_deserialize<Authorize>();
        }

        void it_should_validate_required_properties()
        {
            authorizeMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "CardHolder", "CardNumber");
        }

        void it_should_validate_amount()
        {
            authorizeMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            authorizeMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_validate_month()
        {
            authorizeMock.Instance.on_validation_should_behave_like_month("ExpirationMonth");
        }

        void it_should_validate_year()
        {
            authorizeMock.Instance.on_validation_should_behave_like_year("ExpirationYear");
        }

        void it_should_validate_card_number()
        {
            authorizeMock.Instance.on_validation_should_behave_like_card_number("CardNumber");
        }

        void it_should_validate_cvv()
        {
            authorizeMock.Instance.on_validation_should_behave_like_cvv("Cvv");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            authorizeMock.Instance.should_serialize_to(authorizeMock.Xml);
        }
    }
}