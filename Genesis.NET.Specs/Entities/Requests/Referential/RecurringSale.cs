using System;
using System.Linq;
using NSpec;
using Genesis.Net.Entities.Requests.Referential;
using Genesis.Net.Common;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Requests.Referential
{
    class describe_recurring_sale : nspec
    {
        EntityMock<RecurringSale> recurringSaleMock;

        void before_each()
        {
            recurringSaleMock = RequestMocksFactory.CreateValidRecurringSale();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            recurringSaleMock.Instance.should_serialize_and_deserialize<RecurringSale>();
        }

        void it_should_validate_required_properties()
        {
            recurringSaleMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "ReferenceId");
        }

        void it_should_validate_amount()
        {
            recurringSaleMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            recurringSaleMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            recurringSaleMock.Instance.should_serialize_to(recurringSaleMock.Xml);
        }
    }
}