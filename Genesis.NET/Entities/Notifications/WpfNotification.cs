using System.Collections.Specialized;
using Genesis.Net.Entities.Enums.ThreeDS;

namespace Genesis.Net.Entities.Notifications
{
    public class WpfNotification : Notification
    {
        public WpfNotification(NameValueCollection notificationParameters)
        {
            NotificationType = notificationParameters.Get("notification_type");
            WpfUniqueId = notificationParameters.Get("wpf_unique_id");
            FillStandardParameters(this, notificationParameters);
        }

        public string WpfUniqueId { get; set; }

        public string WpfTransactionId { get; set; }

        public string WpfStatus { get; set; }

        public string PaymentTransactionTerminalToken { get; set; }

        public string PaymentTransactionUniqueId { get; set; }

        public string PaymentTransactionTransactionType { get; set; }

        public string NotificationType { get; set; }

        public string PaymentTransactionAmount { get; set; }

        public string PaymentTransactionPartialApproval { get; set; }

        public string PaymentTransactionToken { get; set; }

        public string PaymentTransactionAvsResponseCode { get; set; }

        public string PaymentTransactionAvsResponseText { get; set; }

        public string PaymentTransactionCvvResultCode { get; set; }

        #region Common notification parameters
        public string ConsumerId { get; set; }

        public string Eci { get; set; }

        public string AuthorizationCode { get; set; }

        public string RetrievalReferenceNumber { get; set; }

        public string FundsStatus { get; set; }

        public string AccountHolder { get; set; }

        public string SchemeResponseCode { get; set; }

        public string RecurringAdviceCode { get; set; }

        public string RecurringAdviceText { get; set; }

        public string SchemeTransactionIdentifier { get; set; }

        public string SchemeSettlementDate { get; set; }

        public string CardBrand { get; set; }

        public string CardNumber { get; set; }

        public string CardType { get; set; }

        public string CardSubtype { get; set; }

        public string CardIssuingBank { get; set; }

        public string CardHolder { get; set; }

        public string ExpirationYear { get; set; }

        public string ExpirationMonth { get; set; }

        public string Status { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerPhone { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string AcquirerReferenceNumber { get; set; }

        public string BankAccountNumber { get; set; }

        public string BankIdentifierCode { get; set; }
        #endregion

        #region 3ds attributes
        /// <summary>
        /// Identifies the concrete 3DS authentication flow that the transaction has gone through.
        /// It will be available in the notification only if the consumer has finished the 3DS authentication with the issuer.
        /// The value for 3DSv1 will be payer_authentication. The available values for 3DSv2 are frictionless, challenge and fallback.
        /// </summary>
        public AuthenticationFlows? ThreedsAuthenticationFlow { get; set; }

        /// <summary>
        /// Identifies the status of the 3DS-Method in the scope of 3DSv2 authentication protocol. The possible values are: required, in_progress and completed.
        /// </summary>
        public MethodStatus? ThreedsMethodStatus { get; set; }

        /// <summary>
        /// Identifies the 3DS protocol that has been enforced. The possible values are 1, 2. In case it's 2, you are integrated with the 3DSv2 authentication protocol, otherwise with 3DSv1.
        /// </summary>
        public string ThreedsTargetProtocolVersion { get; set; }

        /// <summary>
        /// Identifies the concrete 3DS protocol version that the transaction has gone through. 
        /// The possible values are 1, 2. The value will be 1 in case of 3DSv1 authentication protocol used or a fallback from 3DSv2 to 3DSv1 has happened.
        /// </summary>
        public string ThreedsConcreteProtocolVersion { get; set; }

        /// <summary>
        /// The authentication status reason code is a predefined code as per the EMVCo specification and provides further information about the reason for the failed/declined 3DS authentication or the error that has occurred while trying to authenticate the cardholder.
        /// <code>01</code> Card authentication failed
        /// <code>02</code> Unknown Device
        /// <code>03</code> Unsupported Device
        /// <code>04</code> Exceeds authentication frequency limit
        /// <code>05</code> Expired card
        /// <code>06</code> Invalid card number
        /// <code>07</code> Invalid transaction
        /// <code>08</code> No Card record
        /// <code>09</code> Security failure
        /// <code>10</code> Stolen card
        /// <code>11</code> Suspected fraud
        /// <code>12</code> Transaction not permitted to cardholder
        /// <code>13</code> Cardholder not enrolled in service
        /// <code>14</code> Transaction timed out at the ACS
        /// <code>15</code> Low confidence
        /// <code>16</code> Medium confidence For 01-PA, required if the Transaction Status field = N, U, or R.For 02-NPA, Conditional asdefined by the DS.
        /// <code>17</code> High confidence
        /// <code>18</code> Very High confidence
        /// <code>19</code> Exceeds ACS maximum challenges
        /// <code>20</code> Non-Payment transaction not supported
        /// <code>21</code> 3RI transaction not supported
        /// <code>22</code> ACS technical issue
        /// <code>23</code> Decoupled Authentication required by ACS but not requested by 3DS Requestor
        /// <code>24</code> 3DS Requestor Decoupled Max Expiry Time exceeded
        /// <code>25</code> Decoupled Authentication was provided insufficient time to authenticate cardholder.ACS will not make attempt
        /// <code>26</code> Authentication attempted but not performed by the cardholder
        /// <code>27–79</code> Reserved for EMVCo future use(values invalid until defined by EMVCo)
        /// </summary>
        public string ThreedsAuthenticationStatusReasonCode { get; set; }
        #endregion

        protected override string GetUniqueId()
        {
            return WpfUniqueId;
        }
    }
}