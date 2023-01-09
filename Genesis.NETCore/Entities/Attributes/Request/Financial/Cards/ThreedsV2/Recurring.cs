using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Genesis.NetCore.Common;

namespace Genesis.NetCore.Entities.Attributes.Request.Financial.Cards.ThreedsV2
{
    /// <summary>
    /// Additional recurring details. Optional.
    /// </summary>
    [XmlRoot(ElementName = "recurring")]
    public partial class Recurring : IEntity
    {
        /// <summary>
        /// Used for serialization. To set value use field <see cref="ExpirationDate"/>.
        /// </summary>
        [XmlElement(ElementName = "expiration_date")]
        public string ExpirationDateMetadata
        {
            get
            {
                return ExpirationDate.Date.ToApiDate();
            }

            set
            {
                ExpirationDate = value.ParseApiDate();
            }
        }

        /// <summary>
        /// A future date indicating the end date for any further subsequent transactions.
        /// As a best practice, merchants should have a recurring expiry associated with all recurring transactions,
        /// but in cases like subscriptions where there is no established expiry or end date of recurring transactions, the param should be omitted. 
        /// </summary>
        [XmlIgnore]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Indicates the minimum number of days between subsequent transactions.
        /// An empty value indicates the payment frequency is not set.
        /// Examples:
        /// <example><code>14</code> Indicates a minimum number of 14 days between subsequent recurring transactions.</example>
        /// <example><code>30</code> Indicates a minimum number of 30 days (monthly subscription) between subsequent recurring transactions.</example>
        /// </summary>
        [Range(1, 9999)]
        [XmlElement(ElementName = "frequency")]
        public int Frequency { get; set; }
    }
}
