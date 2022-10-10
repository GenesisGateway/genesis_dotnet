using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial.ThreeD
{
    /// <summary>
    /// This class is deprecated. Please use: <see cref="Genesis.Net.Entities.Requests.Initial.InitRecurringSale3d"/>
    /// </summary>
    [XmlRoot("payment_transaction", Namespace = "InitRecurringSale3DSync")]
    [Obsolete("This class is deprecated. Please use Genesis.Net.Entities.Requests.Initial.InitRecurringSale3d")]
    public class InitRecurringSale3dSync : InitRecurringSale3d
    {
        public InitRecurringSale3dSync() : base()
        {
        }

        [Required]
        [XmlElement(ElementName = "mpi_params")]
        public MpiParams MpiParams { get; set; }
    }
}