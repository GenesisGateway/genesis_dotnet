using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Enums.ThreeDS
{
    /// <summary>
    /// Identifies the current status of 3DS(v2)-Method.
    /// </summary>
    public enum MethodStatus
    {
        /// <remarks />
        [XmlEnum("required")]
        Required,

        /// <remarks />
        [XmlEnum("in_progress")]
        InProgress,

        /// <remarks />
        [XmlEnum("completed")]
        Completed
    }
}
