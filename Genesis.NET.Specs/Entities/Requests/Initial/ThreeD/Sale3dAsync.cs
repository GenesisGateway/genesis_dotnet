using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial.ThreeD;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial.ThreeD
{
    class describe_sale_3d_async : nspec
    {
        EntityMock<Sale3dAsync> sale3dAsyncMock;

        void before_each()
        {
            sale3dAsyncMock = RequestMocksFactory.CreateValidSale3dAsync();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            sale3dAsyncMock.Instance.should_serialize_and_deserialize<Sale3dAsync>();
        }

        void it_should_validate_required_properties()
        {
            sale3dAsyncMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "CardHolder", "CardNumber",
                "NotificationUrl", "ReturnSuccessUrl", "ReturnFailureUrl");
        }

        void it_should_validate_amount()
        {
            sale3dAsyncMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            sale3dAsyncMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_validate_month()
        {
            sale3dAsyncMock.Instance.on_validation_should_behave_like_month("ExpirationMonth");
        }

        void it_should_validate_year()
        {
            sale3dAsyncMock.Instance.on_validation_should_behave_like_year("ExpirationYear");
        }

        void it_should_validate_card_number()
        {
            sale3dAsyncMock.Instance.on_validation_should_behave_like_card_number("CardNumber");
        }

        void it_should_validate_cvv()
        {
            sale3dAsyncMock.Instance.on_validation_should_behave_like_cvv("Cvv");
        }

        void it_should_validate_notification_url()
        {
            sale3dAsyncMock.Instance.on_validation_should_behave_like_url("NotificationUrl");
        }

        void it_should_validate_success_url()
        {
            sale3dAsyncMock.Instance.on_validation_should_behave_like_url("ReturnSuccessUrl");
        }

        void it_should_validate_failure_url()
        {
            sale3dAsyncMock.Instance.on_validation_should_behave_like_url("ReturnFailureUrl");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            sale3dAsyncMock.Instance.should_serialize_to(sale3dAsyncMock.Xml);
        }
    }
}