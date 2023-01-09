using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Entities.Requests.Referential
{
    public abstract class ReferentialRequest : Request
    {
        public override string ApiPath
        {
            get { return "process"; }
        }

        [XmlElement(ElementName = "transaction_type")]
        public TransactionTypes TransactionType { get; set; }

        [StringLength(255)]
        [Required]
        [XmlElement(ElementName = "transaction_id")]
        public string Id { get; set; }

        [StringLength(255)]
        [XmlElement(ElementName = "usage")]
        public string Usage { get; set; }

        [IPv4Address]
        [XmlElement(ElementName = "remote_ip")]
        public string RemoteIp { get; set; }

        [StringLength(32)]
        [Required]
        [XmlElement(ElementName = "reference_id")]
        public string ReferenceId { get; set; }
    }
}
