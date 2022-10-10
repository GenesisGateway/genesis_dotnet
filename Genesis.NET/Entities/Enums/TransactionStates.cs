using System.Xml.Serialization;

namespace Genesis.Net.Entities.Enums
{
    /// <summary>
    /// Transactions will have one of the following states.
    /// These will be returned by transaction responses, reconcile responses and will be shown in the browser interface
    /// </summary>
    public enum TransactionStates
    {
        /// <summary>
        /// Transaction was approved by the schemes and is successful.
        /// </summary>
        [XmlEnum("approved")]
        Approved,

        /// <summary>
        /// Transaction was declined by the schemes or risk management.
        /// </summary>
        [XmlEnum("declined")]
        Declined,

        /// <summary>
        /// An asynchronous transaction (3-D secure payment) has been initiated and is waiting for user input.
        /// Updates of this state will be sent to the notification url specified in request.
        /// </summary>
        [XmlEnum("pending_async")]
        PendingAsync,

        /// <summary>
        /// An asynchronous transaction has been finalized by user but is waiting final update from provider.
        /// </summary>
        [XmlEnum("pending_hold")]
        PendingHold,

        /// <summary>
        /// The outcome of the transaction could not be determined, e.g. at a timeout situation.
        /// Transaction state will eventually change, so make a reconcile after a certain time frame.
        /// </summary>
        [XmlEnum("pending")]
        Pending,

        /// <summary>
        /// The outcome of the transaction could not be determined, e.g. at a timeout situation. Transaction state will eventually change, so make a reconcile after a certain time frame.
        /// </summary>
        [XmlEnum("error")]
        Error,

        /// <summary>
        /// Once an approved transaction is refunded the state changes to refunded.
        /// </summary>
        [XmlEnum("refunded")]
        Refunded,

        /// <summary>
        /// Once an approved transaction is chargebacked - the state changes to changebacked.
        /// Chargeback is the state of rejecting an accepted transaction (with funds transferred) by the cardholder or the issuer
        /// </summary>
        [XmlEnum("chargebacked")]
        Chargebacked,

        /// <summary>
        /// Transaction was authorized, but later the merchant canceled it.
        /// </summary>
        [XmlEnum("voided")]
        Voided,

        /// <summary>
        /// Once a chargebacked transaction is charged, the state changes to chargeback reversed.
        /// Chargeback has been canceled.
        /// </summary>
        [XmlEnum("chargeback_reversed")]
        ChargebackReversed,

        /// <summary>
        /// Once a chargebacked transaction is charged, the state changes to represented.
        /// Chargeback has been canceled.
        /// </summary>
        [XmlEnum("represented")]
        Represented,

        /// <summary>
        /// Once a chargeback_reversed/represented transaction is chargebacked the state changes to second chargebacked.
        /// </summary>
        [XmlEnum("second_chargebacked")]
        SecondChargebacked,

        /// <summary>
        /// Transaction on hold, a manual review will be done
        /// </summary>
        [XmlEnum("pending_review")]
        PendingReview,

        /// <summary>
        /// Relevant only for preauthorization transactions.
        /// Once partial amount (less than the full preauthorized amount) is returned to the customer, the transaction becomes partially reversed.
        /// </summary>
        [XmlEnum("partially_reversed")]
        PartiallyReversed,


        /// <summary>
        /// WPF transaction initial status
        /// </summary>
        [XmlEnum("new")]
        New,

        /// <summary>
        /// WPF in-progress status
        /// </summary>
        [XmlEnum("user")]
        User,

        /// <summary>
        /// WPF timeout has occurred
        /// </summary>
        [XmlEnum("timeout")]
        Timeout,
    }
}
