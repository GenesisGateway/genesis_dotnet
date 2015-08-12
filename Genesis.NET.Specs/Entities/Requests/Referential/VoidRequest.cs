using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Referential;
using NSpec;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Requests.Referential
{
    class describe_void : nspec
    {
        EntityMock<VoidRequest> voidRequestMock;

        void before_each()
        {
            voidRequestMock = RequestMocksFactory.CreateValidVoidRequest();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            voidRequestMock.Instance.should_serialize_and_deserialize<VoidRequest>();
        }

        void it_should_validate_required_properties()
        {
            voidRequestMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "ReferenceId");
        }

        void it_should_validate_ipv4Address()
        {
            voidRequestMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            voidRequestMock.Instance.should_serialize_to(voidRequestMock.Xml);
        }
    }
}