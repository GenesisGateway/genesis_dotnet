using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial.ThreeD;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial.ThreeD
{
    class describe_init_recurring_sale_3d_async : nspec
    {
        EntityMock<InitRecurringSale3dAsync> initRecurringSale3dAsyncMock;

        void before_each()
        {
            initRecurringSale3dAsyncMock = RequestMocksFactory.CreateValidInitRecurringSale3dAsync();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            initRecurringSale3dAsyncMock.Instance.should_serialize_and_deserialize<InitRecurringSale3dAsync>();
        }

        void it_should_validate_required_properties()
        {
            initRecurringSale3dAsyncMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "CardHolder", "CardNumber",
                "NotificationUrl", "ReturnSuccessUrl", "ReturnFailureUrl");
        }

        void it_should_validate_amount()
        {
            initRecurringSale3dAsyncMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            initRecurringSale3dAsyncMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_validate_month()
        {
            initRecurringSale3dAsyncMock.Instance.on_validation_should_behave_like_month("ExpirationMonth");
        }

        void it_should_validate_year()
        {
            initRecurringSale3dAsyncMock.Instance.on_validation_should_behave_like_year("ExpirationYear");
        }

        void it_should_validate_card_number()
        {
            initRecurringSale3dAsyncMock.Instance.on_validation_should_behave_like_card_number("CardNumber");
        }

        void it_should_validate_cvv()
        {
            initRecurringSale3dAsyncMock.Instance.on_validation_should_behave_like_cvv("Cvv");
        }

        void it_should_validate_notification_url()
        {
            initRecurringSale3dAsyncMock.Instance.on_validation_should_behave_like_url("NotificationUrl");
        }

        void it_should_validate_success_url()
        {
            initRecurringSale3dAsyncMock.Instance.on_validation_should_behave_like_url("ReturnSuccessUrl");
        }

        void it_should_validate_failure_url()
        {
            initRecurringSale3dAsyncMock.Instance.on_validation_should_behave_like_url("ReturnFailureUrl");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            initRecurringSale3dAsyncMock.Instance.should_serialize_to(initRecurringSale3dAsyncMock.Xml);
        }
    }
}