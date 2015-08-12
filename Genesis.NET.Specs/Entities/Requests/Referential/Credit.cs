using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Referential;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Referential
{
    class describe_credit : nspec
    {
        EntityMock<Credit> creditMock;

        void before_each()
        {
            creditMock = RequestMocksFactory.CreateValidCredit();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            creditMock.Instance.should_serialize_and_deserialize<Credit>();
        }

        void it_should_validate_required_properties()
        {
            creditMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "ReferenceId");
        }

        void it_should_validate_amount()
        {
            creditMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            creditMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            creditMock.Instance.should_serialize_to(creditMock.Xml);
        }
    }
}