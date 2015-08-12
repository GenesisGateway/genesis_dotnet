using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial.ThreeD
{
    [XmlRoot("payment_transaction", Namespace = "InitRecurringSale3DSync")]
    public class InitRecurringSale3dSync : InitRecurringSale3d
    {
        [Required]
        [XmlElement(ElementName="mpi_params")]
        public MpiParams MpiParams { get; set; }

        public InitRecurringSale3dSync() : base()
        {
        }
    }
}