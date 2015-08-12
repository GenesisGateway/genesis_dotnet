using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial
{
    class describe_sofort : nspec
    {
        EntityMock<Sofort> sofortMock;

        void before_each()
        {
            sofortMock = RequestMocksFactory.CreateValidSofort();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            sofortMock.Instance.should_serialize_and_deserialize<Sofort>();
        }

        void it_should_validate_required_properties()
        {
            sofortMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "ReturnSuccessUrl", "ReturnFailureUrl");
        }

        void it_should_validate_amount()
        {
            sofortMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            sofortMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            sofortMock.Instance.should_serialize_to(sofortMock.Xml);
        }
    }
}
