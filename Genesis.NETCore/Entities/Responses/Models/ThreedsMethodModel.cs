using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums.ThreeDS;

namespace Genesis.NetCore.Entities.Responses.Models
{
    /// <summary>
    /// Contains the current status of 3DSv2-Method.
    /// </summary>
    public class ThreedsMethodModel : IResponse
    {
        /// <summary>
        /// Identifies the current status of 3DSv2-Method.
        /// </summary>
        [XmlElement("status")]
        public MethodStatus Status { get; set; }
    }
}