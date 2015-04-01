using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial.ThreeD
{
    [XmlRoot("payment_transaction", Namespace = "Authorize3DSync")]
    public class Authorize3dSync : Authorize3d
    {
        [Required]
        [XmlElement(ElementName="mpi_params")]
        public MpiParams MpiParams { get; set; }

        public Authorize3dSync() : base()
        {
        }
    }
}