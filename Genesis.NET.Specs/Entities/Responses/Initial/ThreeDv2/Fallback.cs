using System.Collections.Specialized;
using Genesis.Net.Entities;
using Genesis.Net.Entities.Notifications;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Responses.Initial.ThreeDv2
{
    public class describe_response_Fallback : nspec
    {
        void it_should_deserialize_success_fallback_response()
        {
            var successResponseMock = ResponseMocksFactory.Create3dV2FallbackSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<CardTransactionSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_deserialize_success_reconcile_response()
        {
            var successResponseMock = ResponseMocksFactory.Create3dV2FallbackReconcileSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<SingleReconcileSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_3dv2_notification()
        {
            var threedNotificationParams = new NameValueCollection(6)
            {
                { "transaction_id", "119643250547501c79d8295" },
                { "unique_id", "44177a21403427eb96664a6d7e5d5d48" },
                { "transaction_type", "init_recurring_sale3d" },
                { "terminal_token", "394f2ebc3646d3c017fa1e1cbc4a1e20" },
                { "status", "approved" },
                { "signature", "088e16a1019277b15d58faf0541e11910eb756f6" },
                { "threeds_authentication_flow", "fallback" },
                { "threeds_target_protocol_version", "2" },
                { "threeds_concrete_protocol_version", "1" }
            };

            var expected3DNotification = new ThreeDNotification(threedNotificationParams);

            var notificationData = "transaction_id=119643250547501c79d8295" +
                "&unique_id=44177a21403427eb96664a6d7e5d5d48" +
                "&transaction_type=init_recurring_sale3d" +
                "&terminal_token=394f2ebc3646d3c017fa1e1cbc4a1e20" +
                "&status=approved" +
                "&amount=100" +
                "&signature=088e16a1019277b15d58faf0541e11910eb756f6" +
                "&eci=05" +
                "&avs_response_code=5I" +
                "&avs_response_text=Response+provided+by+issuer+processor%3B+Address+information+not+verified" +
                "&cvv_result_code=M" +
                "&authorization_code=005645" +
                "&retrieval_reference_number=016813015184" +
                "&threeds_authentication_flow=fallback" +
                "&threeds_target_protocol_version=2" +
                "&threeds_concrete_protocol_version=1";

            var threeDNotification = Notification.Parse(notificationData) as ThreeDNotification;

            threeDNotification.should_not_be_null();

            threeDNotification.should_be(expected3DNotification);
        }
    }
}
