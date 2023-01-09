using System;
using System.Collections.Specialized;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Genesis.NetCore.Common;
using Genesis.NetCore.Entities.Notifications;

namespace Genesis.NetCore.Entities
{
    public abstract class Notification : IEntity
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

            if (string.IsNullOrEmpty(notificationType) || !string.IsNullOrEmpty(parameters.Get("unique_id")))
            {
                return new ThreeDNotification(parameters);
            }
            else if (notificationType == "wpf" || !string.IsNullOrEmpty(parameters.Get("wpf_unique_id")))
            {
                return new WpfNotification(parameters);
            }
            else if (notificationType == "kyc_service_execution" || !string.IsNullOrEmpty(parameters.Get("reference_id")))
            {
                return new KYCNotification(parameters);
            }
            else if (notificationType == "apm_external_event" || !string.IsNullOrEmpty(parameters.Get("payment_transaction_unique_id")))
            {
                return new APMExternalEventNotification(parameters);
            }

            return null;
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

        /// <summary>
        /// Using reflection fills the properties of the instance from the passed notification parameter names.
        /// It makes standard parameter guess of the parameter names.
        /// <list type="">
        /// <item>"UniqueId" property is searched inside "unique_id" parameter.</item>
        /// <item>"MyPropertyName" will be searched inside "my_property_name" parameter.</item>
        /// </list>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="self"></param>
        /// <param name="notificationParameters"></param>
        protected static void FillStandardParameters<T>(T self, NameValueCollection notificationParameters)
            where T : Notification
        {
            foreach (var propertyInfo in self.GetType().GetProperties())
            {
                var parameterNameGuess = propertyInfo.Name.GuessParamaterNameByPropertyName();
                if (!string.IsNullOrEmpty(parameterNameGuess))
                {
                    var value = notificationParameters.Get(parameterNameGuess);
                    // if property is nullable enum type
                    if (value != null &&
                        propertyInfo.PropertyType.IsGenericType &&
                        propertyInfo.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) &&
                        Nullable.GetUnderlyingType(propertyInfo.PropertyType).IsEnum)
                    {
                        var enumValue = value.ParseEnumByTheNameInXMLEnumAttribute(Nullable.GetUnderlyingType(propertyInfo.PropertyType));
                        propertyInfo.SetValue(self, enumValue);
                    }
                    else if (value != null && propertyInfo.PropertyType.IsEnum)
                    {
                        propertyInfo.SetValue(self, (int?)value.ParseEnumByTheNameInXMLEnumAttribute(propertyInfo.PropertyType));
                    }
                    else
                    {
                        propertyInfo.SetValue(self, value);
                    }
                }
            }
        }

        public byte[] GetEchoResponseBody()
        {
            var echoResponse = new NotificationEcho(this);
            var echoResponseBody = XmlSerializationHelpers.Serialize(echoResponse);
            return echoResponseBody;
        }
    }
}
