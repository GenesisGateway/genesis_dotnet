using System;
using System.Xml.Serialization;

namespace Genesis.Net.Entities
{
    [XmlRoot("notification_echo", Namespace = "ThreeDNotification")]
    public class ThreeDNotification : Notification
    {
        [XmlElement(ElementName="unique_id")]
        public string UniqueId { get; set; }

        public string TransactionId { get; set; }

        public string TransactionType { get; set; }

        public string TerminalToken { get; set; }

        public string Status { get; set; }

        protected override string GetUniqueId()
        {
            return UniqueId;
        }
    }
}