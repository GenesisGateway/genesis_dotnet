using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    /// <remarks />
    internal class ThreeDSModel
    {
        /// <summary>
        /// 3DS Response model
        /// </summary>
        [XmlElement("threeds")]
        public ThreeDSElementModel ThreeDS { get; set; }
    }
}
