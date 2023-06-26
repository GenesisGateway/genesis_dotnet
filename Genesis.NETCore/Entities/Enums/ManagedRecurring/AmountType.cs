using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Enums.ManagedRecurring
{
    [Serializable]
    /// <summary>
    /// Indicates the type of the amount.
    /// </summary>
    public enum AmountType
    {
        /// <remarks/>
        [XmlEnum("fixed")]
        Fixed,

        /// <remarks/>
        [XmlEnum("max")]
        Max
    }
}
