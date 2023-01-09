using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities
{
    public class MpiParams : IEntity
    {
        [StringLength(255)]
        [Required]
        [XmlElement(ElementName = "cavv")]
        public string Cavv { get; set; }

        [StringLength(255)]
        [Required]
        [XmlElement(ElementName = "eci")]
        public string Eci { get; set; }

        [StringLength(255)]
        [Required]
        [XmlElement(ElementName = "xid")]
        public string Xid { get; set; }

        public MpiParams() { }
    }
}
