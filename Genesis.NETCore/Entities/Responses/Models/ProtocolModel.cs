using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    /// <summary>
    /// Identifies the requested version and concrete version of the 3DS authentication protocol.
    /// </summary>
    [XmlRoot("protocol")]
    public class ProtocolModel : IResponse
    {
        /// <summary>
        /// Identifies the requested version of the 3DS authentication protocol to be used. The possible values are 1, 2.
        /// </summary>
        [XmlElement("target_version")]
        public int TargetVersion { get; set; }

        /// <summary>
        /// Identifies the concrete version of the 3DS authentication protocol that the transaction has been processed through. The possible values are 1, 2.
        /// </summary>
        [XmlElement("concrete_version")]
        public int ConcreteVersion { get; set; }
    }
}