using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial.ThreeD
{
    [XmlRoot("payment_transaction", Namespace = "Sale3DSync")]
    public class Sale3dSync : Sale3d
    {
        [Required]
        [XmlElement(ElementName="mpi_params")]
        public MpiParams MpiParams { get; set; }

        public Sale3dSync() : base()
        {
        }
    }
}