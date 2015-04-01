using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Query
{
    [XmlRoot("reconcile", Namespace = "SingleReconcile")]
    public class SingleReconcile : Request
    {
        public override string SubDomain
        {
            get
            {
                return "gate";
            }
        }

        public override string ApiPath
        {
            get
            {
                return "reconcile";
            }
        }

        [Required]
        [XmlElement(ElementName="unique_id")]
        public string UniqueId { get; set; }

        public SingleReconcile()
        {
        }
    }
}