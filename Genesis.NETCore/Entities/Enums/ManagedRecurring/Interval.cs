using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Enums.ManagedRecurring
{
    public enum Interval
    {
        /// <remarks/>
        [XmlEnum("days")]
        Days,

        /// <remarks/>
        [XmlEnum("months")]
        Months
    }
}
