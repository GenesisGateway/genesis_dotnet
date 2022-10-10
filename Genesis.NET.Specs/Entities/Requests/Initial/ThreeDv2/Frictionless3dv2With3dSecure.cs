using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial.ThreeDv2
{
    class describe_Frictionless3dv2With3dSecure : nspec
    {
        EntityMock<InitRecurringSale3d> sale3dv2With3dSecureMock;

        void before_each()
        {
            sale3dv2With3dSecureMock = RequestMocksFactory.CreateValidFrictionless3dv2With3dSecure();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            sale3dv2With3dSecureMock.Instance.should_serialize_and_deserialize<InitRecurringSale3d>();
        }

        void it_should_validate_required_properties()
        {
            sale3dv2With3dSecureMock.Instance.on_validation_should_behave_like_required("Id", "CardHolder", "CardNumber");
        }

        void it_should_validate_amount()
        {
            sale3dv2With3dSecureMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            sale3dv2With3dSecureMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_validate_month()
        {
            sale3dv2With3dSecureMock.Instance.on_validation_should_behave_like_month("ExpirationMonth");
        }

        void it_should_validate_year()
        {
            sale3dv2With3dSecureMock.Instance.on_validation_should_behave_like_year("ExpirationYear");
        }

        void it_should_validate_card_number()
        {
            sale3dv2With3dSecureMock.Instance.on_validation_should_behave_like_card_number("CardNumber");
        }

        void it_should_validate_cvv()
        {
            sale3dv2With3dSecureMock.Instance.on_validation_should_behave_like_cvv("Cvv");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            sale3dv2With3dSecureMock.Instance.should_serialize_to(sale3dv2With3dSecureMock.Xml);
        }
    }
}
