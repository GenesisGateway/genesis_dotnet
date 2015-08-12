using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Genesis.Net.Common;

namespace Genesis.Net.Entities
{
    public abstract class Notification : Entity
    {
        public string Signature { get; set; }

        public static Notification Parse(Stream requestData)
        {
            using (var reader = new StreamReader(requestData))
            {
                return Parse(reader.ReadToEnd());
            }
        }

        public static Notification Parse(string requestData)
        {
            var parameters = HttpUtility.ParseQueryString(requestData);
            var notificationType = parameters.Get("notification_type");
            if (string.IsNullOrEmpty(notificationType))
            {
                return CreateThreeDNotification(parameters);
            }
            else if (notificationType == "wpf")
            {
                return CreateWpfNotification(parameters);
            }

            return null;
        }

        private static ThreeDNotification CreateThreeDNotification(NameValueCollection parameters)
        {
            var threeDNotification = new ThreeDNotification()
            {
                Signature = parameters.Get("signature"),
                Status = parameters.Get("status"),
                TerminalToken = parameters.Get("terminal_token"),
                TransactionId = parameters.Get("transaction_id"),
                TransactionType = parameters.Get("transaction_type"),
                UniqueId = parameters.Get("unique_id")
            };

            return threeDNotification;
        }

        private static WpfNotification CreateWpfNotification(NameValueCollection parameters)
        {
            var wpfNotification = new WpfNotification()
            {
                NotificationType = parameters.Get("notification_type"),
                PaymentTransactionTerminalToken = parameters.Get("payment_transaction_terminal_token"),
                PaymentTransactionTransactionType = parameters.Get("payment_transaction_transaction_type"),
                PaymentTransactionUniqueId = parameters.Get("payment_transaction_unique_id"),
                Signature = parameters.Get("signature"),
                WpfStatus = parameters.Get("wpf_status"),
                WpfTransactionId = parameters.Get("wpf_transaction_id"),
                WpfUniqueId = parameters.Get("wpf_unique_id")
            };

            return wpfNotification;
        }

        public bool IsAuthentic(Configuration configuration)
        {
            var hashAlgorithm = GetHashAlgorithm();
            if (hashAlgorithm == null)
            {
                return false;
            }

            var uniqueId = GetUniqueId();
            var apiPassword = configuration.ApiPassword;
            var hash = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(uniqueId + apiPassword));
            var expectedSignature = BitConverter.ToString(hash).Replace("-", string.Empty);

            return string.Equals(expectedSignature, Signature, StringComparison.InvariantCultureIgnoreCase);
        }

        private HashAlgorithm GetHashAlgorithm()
        {
            HashAlgorithm hashAlgorithm = null;
            if (Signature.Length == 40)
            {
                hashAlgorithm = SHA1.Create();
            }
            else if (Signature.Length == 128)
            {
                hashAlgorithm = SHA512.Create();
            }
            return hashAlgorithm;
        }

        protected abstract string GetUniqueId();

        public byte[] GetEchoResponseBody()
        {
            var echoResponseBody = XmlSerializationHelpers.Serialize(this);
            return echoResponseBody;
        }
    }
}
