using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Enums.Recurring
{
    /// <summary>
    /// Indicates the recurring type.
    /// </summary>
    public enum RecurringType
    {
        /// <remarks/>
        [XmlEnum("initial")]
        [Description("initial")]
        Initial,

        /// <remarks/>
        [XmlEnum("subsequent")]
        [Description("subsequent")]
        Subsequent,

        /// <remarks/>
        [XmlEnum("managed")]
        [Description("managed")]
        Managed
    }
}
