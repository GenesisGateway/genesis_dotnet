using System.Xml.Serialization;
using Genesis.Net.Entities.Enums.ThreeDS;

namespace Genesis.Net.Entities.Responses
{
    /// <summary>
    /// Contains the current status of 3DSv2-Method.
    /// </summary>
    public class ThreedsMethodModel : Entity
    {
        /// <summary>
        /// Identifies the current status of 3DSv2-Method.
        /// </summary>
        [XmlElement("status")]
        public MethodStatus Status { get; set; }
    }
}