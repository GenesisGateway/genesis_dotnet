using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities
{
    public class MpiParams : Entity
    {
        [StringLength(255)]
        [Required]
        [XmlElement(ElementName="cavv")]
        public string Cavv { get; set; }

        [StringLength(255)]
        [Required]
        [XmlElement(ElementName="eci")]
        public string Eci { get; set; }

        [StringLength(255)]
        [Required]
        [XmlElement(ElementName="xid")]
        public string Xid { get; set; }

        public MpiParams() { }
    }
}
