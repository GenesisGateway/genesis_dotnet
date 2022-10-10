using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial.ThreeDv2
{
    class describe_Challenge3dv2With3dSecure : nspec
    {
        EntityMock<Sale3d> challenge3dv2With3dSecureMock;

        void before_each()
        {
            challenge3dv2With3dSecureMock = RequestMocksFactory.CreateValidChallenge3dv2With3dSecure();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            challenge3dv2With3dSecureMock.Instance.should_serialize_and_deserialize<Sale3d>();
        }

        void it_should_validate_required_properties()
        {
            challenge3dv2With3dSecureMock.Instance.on_validation_should_behave_like_required("Id", "CardHolder", "CardNumber");
        }

        void it_should_validate_amount()
        {
            challenge3dv2With3dSecureMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            challenge3dv2With3dSecureMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_validate_month()
        {
            challenge3dv2With3dSecureMock.Instance.on_validation_should_behave_like_month("ExpirationMonth");
        }

        void it_should_validate_year()
        {
            challenge3dv2With3dSecureMock.Instance.on_validation_should_behave_like_year("ExpirationYear");
        }

        void it_should_validate_card_number()
        {
            challenge3dv2With3dSecureMock.Instance.on_validation_should_behave_like_card_number("CardNumber");
        }

        void it_should_validate_cvv()
        {
            challenge3dv2With3dSecureMock.Instance.on_validation_should_behave_like_cvv("Cvv");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            challenge3dv2With3dSecureMock.Instance.should_serialize_to(challenge3dv2With3dSecureMock.Xml);
        }
    }
}
