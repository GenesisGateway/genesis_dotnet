using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Enums.ManagedRecurring
{
    public enum PaymentType
    {
        /// <remarks/>
        [XmlEnum("initial")]
        Initial,

        /// <remarks/>
        [XmlEnum("subsequent")]
        Subsequent,

        /// <remarks/>
        [XmlEnum("modification")]
        Modification,

        /// <remarks/>
        [XmlEnum("cancellation")]
        Cancellation
    }
}
