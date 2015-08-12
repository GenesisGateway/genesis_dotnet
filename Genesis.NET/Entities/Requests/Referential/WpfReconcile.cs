using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Referential
{
    [XmlRoot("wpf_reconcile", Namespace = "WpfReconcile")]
    public class WpfReconcile : Wpf
    {
        [Required]
        [XmlElement(ElementName="unique_id")]
        public string UniqueId { get;  set; }
    }
}
