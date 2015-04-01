using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial.ThreeD;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial.ThreeD
{
    class describe_authorize_3d_async : nspec
    {
        EntityMock<Authorize3dAsync> authorize3dAsyncMock;

        void before_each()
        {
            authorize3dAsyncMock = RequestMocksFactory.CreateValidAuthorize3dAsync();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            authorize3dAsyncMock.Instance.should_serialize_and_deserialize<Authorize3dAsync>();
        }

        void it_should_validate_required_properties()
        {
            authorize3dAsyncMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "CardHolder", "CardNumber",
                "NotificationUrl", "ReturnSuccessUrl", "ReturnFailureUrl");
        }

        void it_should_validate_amount()
        {
            authorize3dAsyncMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_ipv4Address()
        {
            authorize3dAsyncMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        void it_should_validate_month()
        {
            authorize3dAsyncMock.Instance.on_validation_should_behave_like_month("ExpirationMonth");
        }

        void it_should_validate_year()
        {
            authorize3dAsyncMock.Instance.on_validation_should_behave_like_year("ExpirationYear");
        }

        void it_should_validate_card_number()
        {
            authorize3dAsyncMock.Instance.on_validation_should_behave_like_card_number("CardNumber");
        }

        void it_should_validate_cvv()
        {
            authorize3dAsyncMock.Instance.on_validation_should_behave_like_cvv("Cvv");
        }

        void it_should_validate_notification_url()
        {
            authorize3dAsyncMock.Instance.on_validation_should_behave_like_url("NotificationUrl");
        }

        void it_should_validate_success_url()
        {
            authorize3dAsyncMock.Instance.on_validation_should_behave_like_url("ReturnSuccessUrl");
        }

        void it_should_validate_failure_url()
        {
            authorize3dAsyncMock.Instance.on_validation_should_behave_like_url("ReturnFailureUrl");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            authorize3dAsyncMock.Instance.should_serialize_to(authorize3dAsyncMock.Xml);
        }
    }
}