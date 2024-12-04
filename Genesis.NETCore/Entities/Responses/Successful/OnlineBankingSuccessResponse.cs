using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "OnlineBankingSuccessResponse")]
    public class OnlineBankingSuccessResponse : AlternativePaymentMethodSuccessResponse
    {
        /// <summary>
        /// The payment type describes the type of online banking used to process the transaction.
        /// </summary>
        [XmlElement(ElementName = "payment_type")]
        public OnlineBankingPaymentType PaymentType { get; set; }

        /// <summary>
        /// The bank code used to process the transaction.
        /// </summary>
        [XmlElement(ElementName = "bank_code")]
        public string BankCode { get; set; }

        [XmlElement(ElementName = "account_details")]
        public AccountDetailsModel AccountDetails { get; set; }
    }
}
