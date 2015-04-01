using System;
using System.Linq;
using NSpec;
using Genesis.Net.Entities.Requests.Referential;
using Genesis.Net.Common;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Requests.Referential
{
    class describe_capture : nspec
    {
        EntityMock<Capture> captureMock;

        void before_each()
        {
            captureMock = RequestMocksFactory.CreateValidCapture();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            captureMock.Instance.should_serialize_and_deserialize<Capture>();
        }

        void it_should_validate_required_properties()
        {
            captureMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "ReferenceId");
        }

        void it_should_validate_amount()
        {
            captureMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            captureMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            captureMock.Instance.should_serialize_to(captureMock.Xml);
        }
    }
}