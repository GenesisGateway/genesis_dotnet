using System.Collections.Specialized;

namespace Genesis.NetCore.Entities.Notifications
{
    public class APMExternalEventNotification : Notification
    {
        public APMExternalEventNotification(NameValueCollection notificationParameters)
        {
            PaymentTransactionUniqueId = notificationParameters.Get("payment_transaction_unique_id");
            FillStandardParameters(this, notificationParameters);
        }

        public string PaymentTransactionUniqueId { get; set; }

        public string NotificationType { get; set; }

        public string Category { get; set; }

        public string Priority { get; set; }

        public string Code { get; set; }

        public string Info { get; set; }

        public string Message { get; set; }

        public string Payload { get; set; }

        protected override string GetUniqueId()
        {
            return PaymentTransactionUniqueId;
        }
    }
}
