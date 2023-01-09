using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Entities.Requests.Initial
{
    [XmlRoot("payment_transaction", Namespace = "EzeeWallet")]
    public class EzeeWallet : ProcessRequest
    {
        [Required]
        [XmlElement(ElementName = "source_wallet_id")]
        public string SourceWalletId { get; set; }

        [Required]
        [XmlElement(ElementName = "source_wallet_pwd")]
        public string SourceWalletPassword { get; set; }

        [UrlAddress]
        [Required]
        [XmlElement(ElementName = "return_success_url")]
        public string ReturnSuccessUrl { get; set; }

        [UrlAddress]
        [Required]
        [XmlElement(ElementName = "return_failure_url")]
        public string ReturnFailureUrl { get; set; }

        public EzeeWallet()
        {
            TransactionType = TransactionTypes.EzeeWallet;
        }
    }
}
