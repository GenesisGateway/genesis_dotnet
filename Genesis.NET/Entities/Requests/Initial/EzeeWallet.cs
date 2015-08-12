using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DataAnnotations = DataAnnotationsExtensions;

namespace Genesis.Net.Entities.Requests.Initial
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

        [DataAnnotations.Url(DataAnnotations.UrlOptions.OptionalProtocol)]
        [Required]
        [XmlElement(ElementName="return_success_url")]
        public string ReturnSuccessUrl { get; set; }

        [DataAnnotations.Url(DataAnnotations.UrlOptions.OptionalProtocol)]
        [Required]
        [XmlElement(ElementName="return_failure_url")]
        public string ReturnFailureUrl { get; set; }

        public EzeeWallet()
        {
            Type = TransactionTypes.EzeeWallet;
        }
    }
}
