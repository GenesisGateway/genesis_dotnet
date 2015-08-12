using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Requests.Initial
{
    class describe_wpf_create : nspec
    {
        EntityMock<WpfCreate> wpfCreateMock;

        void before_each()
        {
            wpfCreateMock = RequestMocksFactory.CreateValidWpfCreate();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            wpfCreateMock.Instance.should_serialize_and_deserialize<WpfCreate>();
        }

        void it_should_validate_required_properties()
        {
            wpfCreateMock.Instance.on_validation_should_behave_like_required("TransactionId", "Usage", "Description", "NotificationUrl", "ReturnSuccessUrl", "ReturnFailureUrl", "ReturnCancelUrl");
        }

        void it_should_validate_amount()
        {
            wpfCreateMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_notification_url()
        {
            wpfCreateMock.Instance.on_validation_should_behave_like_url("NotificationUrl");
        }

        void it_should_validate_success_url()
        {
            wpfCreateMock.Instance.on_validation_should_behave_like_url("ReturnSuccessUrl");
        }

        void it_should_validate_failure_url()
        {
            wpfCreateMock.Instance.on_validation_should_behave_like_url("ReturnFailureUrl");
        }

        void it_should_validate_cancel_url()
        {
            wpfCreateMock.Instance.on_validation_should_behave_like_url("ReturnCancelUrl");
        }

        void it_should_serialize_to_the_correct_xml()
        {
            wpfCreateMock.Instance.should_serialize_to(wpfCreateMock.Xml);
        }
    }
}