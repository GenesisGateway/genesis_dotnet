using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Serialization;
using Genesis.Net.Validations;

namespace Genesis.Net.Entities.Requests.Referential
{
    public abstract class ReferentialRequest : Request
    {
        public override string ApiPath
        {
            get { return "process"; }
        }

        [XmlIgnore]
        public TransactionTypes Type { get; set; }

        [XmlElement(ElementName = "transaction_type")]
#if GenerateXmlSerializers
        public string ProxyType
#else
        internal string ProxyType
#endif
        {
            get
            {
                if (Type == null)
                    return string.Empty;
                else
                    return Type.ToString();
            }
            set
            {
                Type = TransactionTypes.TransactionTypesByName.Value[value];
            }
        }

        [StringLength(255)]
        [Required]
        [XmlElement(ElementName="transaction_id")]
        public string Id { get; set; }

        [StringLength(255)]
        [XmlElement(ElementName="usage")]
        public string Usage { get; set; }

        [IPv4Address]
        [Required]
        [XmlElement(ElementName="remote_ip")]
        public string RemoteIp { get; set; }

        [StringLength(32)]
        [Required]
        [XmlElement(ElementName="reference_id")]
        public string ReferenceId { get; set; }
    }
}
