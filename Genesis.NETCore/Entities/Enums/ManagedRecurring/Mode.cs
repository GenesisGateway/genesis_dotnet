using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Enums.ManagedRecurring
{
    public enum Mode
    {
        /// <remarks/>
        [XmlEnum("automatic")]
        Automatic,

        /// <remarks/>
        [XmlEnum("manual")]
        Manual
    }
}
