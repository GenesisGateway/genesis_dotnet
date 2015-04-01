using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Referential;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Referential
{
    class describe_refund : nspec
    {
        EntityMock<Refund> refundMock;

        void before_each()
        {
            refundMock = RequestMocksFactory.CreateValidRefund();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            refundMock.Instance.should_serialize_and_deserialize<Refund>();
        }

        void it_should_validate_required_properties()
        {
            refundMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "ReferenceId");
        }

        void it_should_validate_amount()
        {
            refundMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            refundMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            refundMock.Instance.should_serialize_to(refundMock.Xml);
        }
    }
}