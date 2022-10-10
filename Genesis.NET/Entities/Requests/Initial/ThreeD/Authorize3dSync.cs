using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial.ThreeD
{
    /// <summary>
    /// This class is deprecated. Please use: <see cref="Genesis.Net.Entities.Requests.Initial.Authorize3d"/>
    /// </summary>
    [XmlRoot("payment_transaction", Namespace = "Authorize3DSync")]
    [Obsolete("This class is deprecated. Please use Genesis.Net.Entities.Requests.Initial.Authorize3d")]
    public class Authorize3dSync : Authorize3d
    {
        public Authorize3dSync() : base()
        {
        }

        [Required]
        [XmlElement(ElementName="mpi_params")]
        public MpiParams MpiParams { get; set; }
    }
}