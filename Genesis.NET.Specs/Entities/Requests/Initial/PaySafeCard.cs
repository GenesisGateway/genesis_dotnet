using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial
{
    class describe_paysafecard : nspec
    {
        EntityMock<PaySafeCard> paySafeCardMock;

        void before_each()
        {
            paySafeCardMock = RequestMocksFactory.CreateValidPaySafeCard();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            paySafeCardMock.Instance.should_serialize_and_deserialize<PaySafeCard>();
        }

        void it_should_validate_required_properties()
        {
            paySafeCardMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "ReturnSuccessUrl", "ReturnFailureUrl");
        }

        void it_should_validate_amount()
        {
            paySafeCardMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            paySafeCardMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            paySafeCardMock.Instance.should_serialize_to(paySafeCardMock.Xml);
        }
    }
}
