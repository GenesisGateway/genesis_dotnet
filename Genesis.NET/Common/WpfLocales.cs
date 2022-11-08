using System;
using System.Linq;
using System.Xml.Serialization;

namespace Genesis.Net.Common
{
    public enum WpfLocales
    {
        /// <summary>
        /// English locale and language settings (this is the default)
        /// </summary>
        [XmlEnum("en")]
        EN = 0,

        /// <summary>
        /// Italian locale and language settings
        /// </summary>
        [XmlEnum("it")]
        IT,

        /// <summary>
        /// Spanish locale and language settings
        /// </summary>
        [XmlEnum("es")]
        ES,

        /// <summary>
        /// French locale and language settings
        /// </summary>
        [XmlEnum("fr")]
        FR,

        /// <summary>
        /// German locale and language
        /// </summary>
        [XmlEnum("de")]
        DE,

        /// <summary>
        /// Japanese locale and language
        /// </summary>
        [XmlEnum("ja")]
        JA,

        /// <summary>
        /// Mandarin Chinese locale and language
        /// </summary>
        [XmlEnum("zh")]
        ZH,

        /// <summary>
        /// Arabic locale and language
        /// </summary>
        [XmlEnum("ar")]
        AR,

        /// <summary>
        /// Polish locale and language
        /// </summary>
        [XmlEnum("pl")]
        PL,

        /// <summary>
        /// Portuguese locale and language
        /// </summary>
        [XmlEnum("pt")]
        PT,

        /// <summary>
        /// Turkish locale and language
        /// </summary>
        [XmlEnum("tr")]
        TR,

        /// <summary>
        /// Russian locale and language
        /// </summary>
        [XmlEnum("ru")]
        RU,

        /// <summary>
        /// Hindu locale and language
        /// </summary>
        [XmlEnum("hi")]
        HI,

        /// <summary>
        /// Bulgarian locale and language
        /// </summary>
        [XmlEnum("bg")]
        BG
    }
}
