using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial
{
    class describe_cashu : nspec
    {
        EntityMock<CashU> cashUMock;

        void before_each()
        {
            cashUMock = RequestMocksFactory.CreateValidCashU();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            cashUMock.Instance.should_serialize_and_deserialize<CashU>();
        }

        void it_should_validate_required_properties()
        {
            cashUMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "ReturnSuccessUrl", "ReturnFailureUrl");
        }

        void it_should_validate_amount()
        {
            cashUMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            cashUMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            cashUMock.Instance.should_serialize_to(cashUMock.Xml);
        }
    }
}