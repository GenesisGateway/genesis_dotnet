using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Initial.ThreeD
{
    /// <summary>
    /// This class is deprecated. Please use: <see cref="Genesis.Net.Entities.Requests.Initial.Sale3d"/>
    /// </summary>
    [XmlRoot("payment_transaction", Namespace = "Sale3DSync")]
    [Obsolete("This class is deprecated. Please use Genesis.Net.Entities.Requests.Initial.Sale3d")]
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