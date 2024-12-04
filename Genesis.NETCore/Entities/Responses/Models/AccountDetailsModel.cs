using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    /// <remarks />
    [XmlRoot("account_details")]
    public class AccountDetailsModel : IResponse
    {
        /// <summary>
        /// The reference number of the transaction to be used for the payment.
        /// </summary>
        [XmlElement("reference_number")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The account number that the payment is expected to be transferred/done to.
        /// </summary>
        [XmlElement("account_number")]
        public string AccountNumber { get; set; }
    }
}
