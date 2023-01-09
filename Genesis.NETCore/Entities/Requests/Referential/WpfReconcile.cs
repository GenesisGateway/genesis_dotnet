using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Referential
{
    [XmlRoot("wpf_reconcile", Namespace = "WpfReconcile")]
    public class WpfReconcile : Wpf
    {
        public override string ApiPath
        {
            get
            {
                return "wpf/reconcile";
            }
        }

        [Required]
        [XmlElement(ElementName = "unique_id")]
        public string UniqueId { get; set; }
    }
}
