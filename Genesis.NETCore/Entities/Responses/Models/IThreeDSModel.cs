using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    /// <remarks />
    internal interface IThreeDSModel
    {
        /// <summary>
        /// 3DS Response model
        /// </summary>
        [XmlElement("threeds")]
        ThreeDSElementModel ThreeDS { get; set; }
    }
}
