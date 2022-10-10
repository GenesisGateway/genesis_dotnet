﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Attributes.Request.Financial.Cards.ThreedsV2.Enums
{
    /// <summary>
    /// UI type that the device of the consumer supports for displaying specific challenge interface.
    /// </summary>
    public enum UiTypes
    {
        /// <remarks/>
        [XmlEnum("text")]
        Text,

        /// <remarks/>
        [XmlEnum("single_select")]
        SingleSelect,

        /// <remarks/>
        [XmlEnum("multi_select")]
        MultiSelect,

        /// <remarks/>
        [XmlEnum("out_of_bag")]
        OutOfBag,

        /// <remarks/>
        [XmlEnum("other_html")]
        OtherHtml,
    }
}
