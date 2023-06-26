using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Enums.ManagedRecurring
{
    /// <summary>
    /// Indicates the frequency of the subsequent transactions.
    /// </summary>
    public enum Frequency
    {
        /// <remarks/>
        [XmlEnum("daily")]
        Daily,

        /// <remarks/>
        [XmlEnum("twice_weekly")]
        TwiceWeekly,

        /// <remarks/>
        [XmlEnum("weekly")]
        Weekly,

        /// <remarks/>
        [XmlEnum("ten_days")]
        TenDays,

        /// <remarks/>
        [XmlEnum("fortnightly")]
        Fortnightly,

        /// <remarks/>
        [XmlEnum("monthly")]
        Monthly,

        /// <remarks/>
        [XmlEnum("every_two_months")]
        EveryTwoMonths,

        /// <remarks/>
        [XmlEnum("trimester")]
        Trimester,

        /// <remarks/>
        [XmlEnum("quarterly")]
        Quarterly,

        /// <remarks/>
        [XmlEnum("twice_yearly")]
        TwiceYearly,

        /// <remarks/>
        [XmlEnum("annually")]
        Annually,

        /// <remarks/>
        [XmlEnum("unscheduled")]
        Unscheduled
    }
}
