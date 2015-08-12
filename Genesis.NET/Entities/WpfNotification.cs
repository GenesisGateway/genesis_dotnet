using System.Xml.Serialization;

namespace Genesis.Net.Entities
{
    [XmlRoot("notification_echo", Namespace = "WpfNotification")]
    public class WpfNotification : Notification
    {
        [XmlElement(ElementName="wpf_unique_id")]
        public string WpfUniqueId { get; set; }

        public string WpfTransactionId { get; set; }

        public string WpfStatus { get; set; }

        public string PaymentTransactionTerminalToken { get; set; }

        public string PaymentTransactionUniqueId { get; set; }

        public string PaymentTransactionTransactionType { get; set; }

        public string NotificationType { get; set; }

        protected override string GetUniqueId()
        {
            return WpfUniqueId;
        }
    }
}