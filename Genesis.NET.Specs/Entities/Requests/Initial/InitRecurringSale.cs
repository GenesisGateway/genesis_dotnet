using System;
using System.Linq;
using Genesis.Net.Common;
using Genesis.Net.Entities;
using Genesis.Net.Entities.Requests.Initial;
using NSpec;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Requests.Initial
{
    class describe_init_recurring_sale : nspec
    {
        EntityMock<InitRecurringSale> initRecurringSaleMock;

        void before_each()
        {
            initRecurringSaleMock = RequestMocksFactory.CreateValidInitRecurringSale();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            initRecurringSaleMock.Instance.should_serialize_and_deserialize<InitRecurringSale>();
        }

        void it_should_validate_required_properties()
        {
            initRecurringSaleMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "CardHolder", "CardNumber");
        }

        void it_should_validate_amount()
        {
            initRecurringSaleMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            initRecurringSaleMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_validate_month()
        {
            initRecurringSaleMock.Instance.on_validation_should_behave_like_month("ExpirationMonth");
        }

        void it_should_validate_year()
        {
            initRecurringSaleMock.Instance.on_validation_should_behave_like_year("ExpirationYear");
        }

        void it_should_validate_card_number()
        {
            initRecurringSaleMock.Instance.on_validation_should_behave_like_card_number("CardNumber");
        }

        void it_should_validate_cvv()
        {
            initRecurringSaleMock.Instance.on_validation_should_behave_like_cvv("Cvv");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            initRecurringSaleMock.Instance.should_serialize_to(initRecurringSaleMock.Xml);
        }
    }
}