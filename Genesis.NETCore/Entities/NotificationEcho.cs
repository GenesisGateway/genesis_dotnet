using System.Xml.Serialization;
using Genesis.NetCore.Entities.Notifications;

namespace Genesis.NetCore.Entities
{
    /// <summary>
    /// When receiving the notification, you are required to render an xml page containing the transaction’s unique id so that the gateway knows that you have accepted the notification.
    /// If the XML is not delivered, the notification is sent periodically until the XML is received.
    /// </summary>
    [XmlRoot("notification_echo")]
    public class NotificationEcho : IEntity
    {
        private NotificationEcho()
        {
            // empty constructor for serialization purposes 
        }

        /// <summary>
        /// Create NotificationEcho by parsed notification.
        /// </summary>
        /// <param name="notification"></param>
        public NotificationEcho(Notification notification)
        {
            if (notification is ThreeDNotification)
            {
                UniqueId = (notification as ThreeDNotification).UniqueId;
            }
            else if (notification is WpfNotification)
            {
                WpfUniqueId = (notification as WpfNotification).WpfUniqueId;
            }
            else if (notification is KYCNotification)
            {
                ReferenceId = (notification as KYCNotification).ReferenceId;
            }
            else if (notification is APMExternalEventNotification)
            {
                PaymentTransactionUniqueId = (notification as APMExternalEventNotification).PaymentTransactionUniqueId;
            }
        }

        /// <summary>
        /// Used in 3ds notifications
        /// </summary>
        [XmlElement(ElementName = "unique_id")]
        public string UniqueId { get; set; }

        /// <summary>
        /// Used in WPF notifications
        /// </summary>
        [XmlElement(ElementName = "wpf_unique_id")]
        public string WpfUniqueId { get; set; }

        /// <summary>
        /// Used in KYC notifications
        /// </summary>
        [XmlElement(ElementName = "reference_id")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Used in Alternative Payment Method External Events
        /// </summary>
        [XmlElement(ElementName = "payment_transaction_unique_id")]
        public string PaymentTransactionUniqueId { get; set; }
    }
}
