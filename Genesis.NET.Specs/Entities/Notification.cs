using System;
using System.Linq;
using NSpec;
using Genesis.Net.Entities;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace Genesis.Net.Specs.EntitiesSpecs
{
    class describe_notification : nspec
    {
        X509Certificate certificate = X509Certificate.CreateFromCertFile(@"Certificates/genesis_sandbox_comodo_ca.pem");

        void it_should_parse_3d_notification()
        {
            var expected3DNotification = new ThreeDNotification()
            {
                TransactionId = "82803B4C-70CC-43BD-8B21-FD0395285B40",
                UniqueId = "44177a21403427eb96664a6d7e5d5d48",
                TransactionType = "sale3d",
                TerminalToken = "394f2ebc3646d3c017fa1e1cbc4a1e20",
                Status = "approved",
                Signature = "088e16a1019277b15d58faf0541e11910eb756f6"
            };

            var notificationData = String.Format("transaction_id={0}&unique_id={1}&transaction_type={2}&terminal_token={3}&status={4}&signature={5}",
                expected3DNotification.TransactionId, expected3DNotification.UniqueId, expected3DNotification.TransactionType,
                expected3DNotification.TerminalToken, expected3DNotification.Status, expected3DNotification.Signature);
            var threeDNotification = Notification.Parse(notificationData) as ThreeDNotification;
            
            threeDNotification.should_not_be_null();

            threeDNotification.should_be(expected3DNotification);
        }

        void it_should_parse_wpf_notifications()
        {
            var expectedWpfNotification = new WpfNotification()
            {
                NotificationType = "wpf",
                WpfUniqueId = "26aa150ee68b1b2d6758a0e6c44fce4c",
                WpfStatus = "approved",
                PaymentTransactionTransactionType = "sale",
                WpfTransactionId = "mtid201104081447161135536962",
                PaymentTransactionUniqueId = "bad08183a9ec545daf0f24c48361aa10",
                PaymentTransactionTerminalToken = "e9fd7a957845450fb7ab9dccb498b6e1f6e1e3aa",
                Signature = "c5219b3d385e74496b2b48a5497b347e102849f10eacd25b062f823b"
            };

            var notificationData = String.Format("notification_type={0}&wpf_unique_id={1}&wpf_status={2}&payment_transaction_transaction_type={3}" +
                                                 "&wpf_transaction_id={4}&payment_transaction_unique_id={5}&payment_transaction_terminal_token={6}&signature={7}",
                expectedWpfNotification.NotificationType, expectedWpfNotification.WpfUniqueId, expectedWpfNotification.WpfStatus,
                expectedWpfNotification.PaymentTransactionTransactionType, expectedWpfNotification.WpfTransactionId, expectedWpfNotification.PaymentTransactionUniqueId,
                expectedWpfNotification.PaymentTransactionTerminalToken, expectedWpfNotification.Signature);
            var wpfNotification = Notification.Parse(notificationData) as WpfNotification;

            wpfNotification.should_not_be_null();

            wpfNotification.should_be(expectedWpfNotification);
        }

        void when_determining_authenticity()
        {
            it["should recognize an authentic 3d notification"] = () =>
            {
                var configuration = new Configuration(Environments.Staging, string.Empty, string.Empty, "bogus", certificate, Endpoints.EComProcessing);
                var threeDNotification = new ThreeDNotification()
                {
                    Signature = "08d01ae1ebdc22b6a1a764257819bb26e9e94e8d",
                    UniqueId = "fc6c3c8c0219730c7a099eaa540f70dc"
                };

                threeDNotification.IsAuthentic(configuration).should_be_true();
            };

            it["should recognize a fake 3d notification"] = () =>
            {
                var configuration = new Configuration(Environments.Staging, string.Empty, string.Empty, "boguS", certificate, Endpoints.EComProcessing);
                var threeDNotification = new ThreeDNotification()
                {
                    Signature = "08d01ae1ebdc22b6a1a764257819bb26e9e94e8d",
                    UniqueId = "fc6c3c8c0219730c7a099eaa540f70dc"
                };

                threeDNotification.IsAuthentic(configuration).should_be_false();
            };

            it["should recognize an authentic wpf notification"] = () =>
            {
                var configuration = new Configuration(Environments.Staging, string.Empty, string.Empty, "50fd87e65eb415f42fb5af4c9cf497662e00b785", certificate, Endpoints.EComProcessing);
                var wpfNotification = new WpfNotification()
                {
                    Signature = "c5219b3d385e74496b2b48a5497b347e102849f10eacd25b062f823bbd11249ce4e233f031C0ecebc9b691e69d23eb0c1cd65a79621152467b56aC2bf103b512",
                    WpfUniqueId = "26aa150ee68b1b2d6758a0e6c44fce4c"
                };

                wpfNotification.IsAuthentic(configuration).should_be_true();
            };

            it["should recognize a fake wpf notification"] = () =>
            {
                var configuration = new Configuration(Environments.Staging, string.Empty, string.Empty, "50Fd87e65eb415f42fb5af4c9cf497662e00b785", certificate, Endpoints.EComProcessing);
                var wpfNotification = new WpfNotification()
                {
                    Signature = "c5219b3d385e74496b2b48a5497b347e102849f10eacd25b062f823bbd11249ce4e233f031C0ecebc9b691e69d23eb0c1cd65a79621152467b56aC2bf103b512",
                    WpfUniqueId = "26aa150ee68b1b2d6758a0e6c44fce4c"
                };

                wpfNotification.IsAuthentic(configuration).should_be_false();
            };
        }

        void it_should_render_correct_3d_notification_response()
        {
            var threeDNotification = new ThreeDNotification() { UniqueId = "44177a21403427eb96664a6d7e5d5d48" };

            var xmlResponse = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                              "<notification_echo xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"ThreeDNotification\">" +
                              "<unique_id>" + threeDNotification.UniqueId + "</unique_id>" +
                              "</notification_echo>";
            var expectedResponse = Encoding.UTF8.GetBytes(xmlResponse);

            var actualResponse = threeDNotification.GetEchoResponseBody();
            actualResponse.should_be(expectedResponse);
        }

        void it_should_render_correct_wpf_notification_response()
        {
            var wpfNotification = new WpfNotification() { WpfUniqueId = "26aa150ee68b1b2d6758a0e6c44fce4c" };

            var xmlResponse = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                              "<notification_echo xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"WpfNotification\">" +
                              "<wpf_unique_id>" + wpfNotification.WpfUniqueId + "</wpf_unique_id>" +
                              "</notification_echo>";
            var expectedResponse = Encoding.UTF8.GetBytes(xmlResponse);

            var actualResponse = wpfNotification.GetEchoResponseBody();
            actualResponse.should_be(expectedResponse);
        }
    }
}