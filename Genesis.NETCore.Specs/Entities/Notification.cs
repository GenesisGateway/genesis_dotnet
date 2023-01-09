using System.Collections.Specialized;
using System.Linq;
using System.Text;
using Genesis.NetCore.Entities;
using Genesis.NetCore.Entities.Notifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.EntitiesSpecs
{
    [TestClass]
    public class describe_notification
    {
        [TestMethod]
        public void it_should_parse_3d_notification()
        {
            var threedNotificationParams = new NameValueCollection(6)
            {
                { "transaction_id", "82803B4C-70CC-43BD-8B21-FD0395285B40" },
                { "unique_id", "44177a21403427eb96664a6d7e5d5d48" },
                { "transaction_type", "sale3d" },
                { "terminal_token", "394f2ebc3646d3c017fa1e1cbc4a1e20" },
                { "status", "approved" },
                { "signature", "088e16a1019277b15d58faf0541e11910eb756f6" }
            };

            var expected3DNotification = new ThreeDNotification(threedNotificationParams);

            var notificationData = string.Format("transaction_id={0}&unique_id={1}&transaction_type={2}&terminal_token={3}&status={4}&signature={5}",
                threedNotificationParams.Get("transaction_id"),
                threedNotificationParams.Get("unique_id"),
                threedNotificationParams.Get("transaction_type"),
                threedNotificationParams.Get("terminal_token"),
                threedNotificationParams.Get("status"),
                threedNotificationParams.Get("signature"));

            var threeDNotification = Notification.Parse(notificationData) as ThreeDNotification;

            Assert.IsNotNull(threeDNotification);
            threeDNotification.should_be_override(expected3DNotification);
        }

        [TestMethod]
        public void it_should_parse_wpf_notifications()
        {
            var wpfNotificationParams = new NameValueCollection(8)
            {
                { "notification_type", "wpf" },
                { "wpf_unique_id", "26aa150ee68b1b2d6758a0e6c44fce4c" },
                { "wpf_status", "approved" },
                { "payment_transaction_transaction_type", "sale" },
                { "wpf_transaction_id", "mtid201104081447161135536962" },
                { "payment_transaction_unique_id", "bad08183a9ec545daf0f24c48361aa10" },
                { "payment_transaction_terminal_token", "e9fd7a957845450fb7ab9dccb498b6e1f6e1e3aa" },
                { "signature", "c5219b3d385e74496b2b48a5497b347e102849f10eacd25b062f823b" }
            };

            var expectedWpfNotification = new WpfNotification(wpfNotificationParams);

            var notificationData = string.Format("notification_type={0}&wpf_unique_id={1}&wpf_status={2}&payment_transaction_transaction_type={3}" +
                                                 "&wpf_transaction_id={4}&payment_transaction_unique_id={5}&payment_transaction_terminal_token={6}&signature={7}",
                wpfNotificationParams.Get("notification_type"),
                wpfNotificationParams.Get("wpf_unique_id"),
                wpfNotificationParams.Get("wpf_status"),
                wpfNotificationParams.Get("payment_transaction_transaction_type"),
                wpfNotificationParams.Get("wpf_transaction_id"),
                wpfNotificationParams.Get("payment_transaction_unique_id"),
                wpfNotificationParams.Get("payment_transaction_terminal_token"),
                wpfNotificationParams.Get("signature"));

            var wpfNotification = Notification.Parse(notificationData) as WpfNotification;

            Assert.IsNotNull(wpfNotification);
            wpfNotification.should_be_override(expectedWpfNotification);
        }

        [TestMethod]
        public void it_should_render_correct_3d_notification_response()
        {
            var threedNotificationParams = new NameValueCollection(1)
            {
                { "unique_id", "44177a21403427eb96664a6d7e5d5d48" }
            };

            var threeDNotification = new ThreeDNotification(threedNotificationParams);

            var xmlResponse = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                              "<notification_echo>" +
                              "<unique_id>" + threeDNotification.UniqueId + "</unique_id>" +
                              "</notification_echo>";
            var expectedResponse = Encoding.UTF8.GetBytes(xmlResponse);

            var actualResponse = threeDNotification.GetEchoResponseBody();
            var decoded = Encoding.UTF8.GetString(actualResponse);
            Assert.IsTrue(Enumerable.SequenceEqual(expectedResponse, actualResponse));
        }

        [TestMethod]
        public void it_should_render_correct_wpf_notification_response()
        {
            var wpfNotificationParams = new NameValueCollection(1)
            {
                { "wpf_unique_id", "26aa150ee68b1b2d6758a0e6c44fce4c" }
            };

            var wpfNotification = new WpfNotification(wpfNotificationParams);

            var xmlResponse = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                              "<notification_echo>" +
                              "<wpf_unique_id>" + wpfNotification.WpfUniqueId + "</wpf_unique_id>" +
                              "</notification_echo>";
            var expectedResponse = Encoding.UTF8.GetBytes(xmlResponse);

            var actualResponse = wpfNotification.GetEchoResponseBody();
            Assert.IsTrue(Enumerable.SequenceEqual(expectedResponse, actualResponse));
        }

        [TestMethod]
        public void when_determining_authenticity_it_should_recognize_an_authentic_3d_notification()
        {
            var configuration = new Configuration(
                Environments.Staging,
                string.Empty,
                string.Empty,
                "bogus",
                Endpoints.EComProcessing
                );
            var threedNotificationParams = new NameValueCollection(2)
                {
                    { "signature", "08d01ae1ebdc22b6a1a764257819bb26e9e94e8d" },
                    { "unique_id", "fc6c3c8c0219730c7a099eaa540f70dc" }
                };

            var threeDNotification = new ThreeDNotification(threedNotificationParams);

            Assert.IsTrue(threeDNotification.IsAuthentic(configuration));
        }

        [TestMethod]
        public void when_determining_authenticity_it_should_recognize_a_fake_3d_notification()
        {
            var configuration = new Configuration(
                Environments.Staging,
                string.Empty,
                string.Empty,
                "boguS",
                Endpoints.EComProcessing);

            var threedNotificationParams = new NameValueCollection(2)
                {
                    { "signature", "08d01ae1ebdc22b6a1a764257819bb26e9e94e8d" },
                    { "unique_id", "fc6c3c8c0219730c7a099eaa540f70dc" }
                };

            var threeDNotification = new ThreeDNotification(threedNotificationParams);

            Assert.IsFalse(threeDNotification.IsAuthentic(configuration));
        }

        [TestMethod]
        public void when_determining_authenticity_it_should_recognize_an_authentic_wpf_notification()
        {
            var configuration = new Configuration(
                Environments.Staging,
                string.Empty,
                string.Empty,
                "50fd87e65eb415f42fb5af4c9cf497662e00b785",
                Endpoints.EComProcessing);

            var wpfNotificationParams = new NameValueCollection(2)
                {
                    { "signature", "c5219b3d385e74496b2b48a5497b347e102849f10eacd25b062f823bbd11249ce4e233f031C0ecebc9b691e69d23eb0c1cd65a79621152467b56aC2bf103b512" },
                    { "wpf_unique_id", "26aa150ee68b1b2d6758a0e6c44fce4c" }
                };

            var wpfNotification = new WpfNotification(wpfNotificationParams);

            Assert.IsTrue(wpfNotification.IsAuthentic(configuration));
        }

        [TestMethod]
        public void when_determining_authenticity_it_should_recognize_a_fake_wpf_notification()
        {
            var configuration = new Configuration(
                Environments.Staging,
                string.Empty,
                string.Empty,
                "50Fd87e65eb415f42fb5af4c9cf497662e00b785",
                Endpoints.EComProcessing);

            var wpfNotificationParams = new NameValueCollection(2)
                {
                    { "signature", "c5219b3d385e74496b2b48a5497b347e102849f10eacd25b062f823bbd11249ce4e233f031C0ecebc9b691e69d23eb0c1cd65a79621152467b56aC2bf103b512" },
                    { "wpf_unique_id", "26aa150ee68b1b2d6758a0e6c44fce4c" }
                };

            var wpfNotification = new WpfNotification(wpfNotificationParams);

            Assert.IsFalse(wpfNotification.IsAuthentic(configuration));
        }
    }
}