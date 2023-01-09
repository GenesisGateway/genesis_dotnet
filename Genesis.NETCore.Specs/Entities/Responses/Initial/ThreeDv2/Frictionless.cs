using System.Collections.Specialized;
using Genesis.NetCore.Entities;
using Genesis.NetCore.Entities.Notifications;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses.Initial.ThreeDv2
{
    [TestClass]
    public class describe_response_Frictionless
    {
        [TestMethod]
        public void it_should_deserialize_success_frictionless_response()
        {
            var successResponseMock = ResponseMocksFactory.Create3dV2FrictionlessSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<CardTransactionSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_deserialize_success_reconcile_response()
        {
            var successResponseMock = ResponseMocksFactory.Create3dV2FrictionlessReconcileSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<SingleReconcileSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_3dv2_notification()
        {
            var threedNotificationParams = new NameValueCollection(6)
            {
                { "transaction_id", "119643250547501c79d8295" },
                { "unique_id", "44177a21403427eb96664a6d7e5d5d48" },
                { "transaction_type", "init_recurring_sale3d" },
                { "terminal_token", "394f2ebc3646d3c017fa1e1cbc4a1e20" },
                { "status", "approved" },
                { "amount", "100" },
                { "signature", "088e16a1019277b15d58faf0541e11910eb756f6" },
                { "eci", "05" },
                { "avs_response_code", "5I" },
                { "avs_response_text", "Response provided by issuer processor; Address information not verified" },
                { "cvv_result_code", "M" },
                { "authorization_code", "005645" },
                { "retrieval_reference_number", "016813015184" },
                { "threeds_authentication_flow", "frictionless" },
                { "threeds_target_protocol_version", "2" },
                { "threeds_concrete_protocol_version", "2" }
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
                "&threeds_authentication_flow=frictionless" +
                "&threeds_target_protocol_version=2" +
                "&threeds_concrete_protocol_version=2";

            var threeDNotification = Notification.Parse(notificationData) as ThreeDNotification;

            Assert.IsNotNull(threeDNotification);

            threeDNotification.should_be_override(expected3DNotification);
        }
    }
}
