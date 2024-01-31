using System.Xml.Serialization;

namespace Genesis.NetCore.Common
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
        BG,

        /// <summary>
        /// Dutch locale and language
        /// </summary>
        [XmlEnum("nl")]
        NL,

        /// <summary>
        /// Icelandic locale and language
        /// </summary>
        [XmlEnum("is")]
        IS,

        /// <summary>
        /// Indonesian locale and language
        /// </summary>
        [XmlEnum("id")]
        ID,

        /// <summary>
        /// Malay locale and language
        /// </summary>
        [XmlEnum("ms")]
        MS,

        /// <summary>
        /// Thai locale and language
        /// </summary>
        [XmlEnum("th")]
        TH,

        /// <summary>
        /// Czech locale and language
        /// </summary>
        [XmlEnum("cs")]
        CS,

        /// <summary>
        /// Croatian locale and language
        /// </summary>
        [XmlEnum("hr")]
        HR,

        /// <summary>
        /// Slovenian locale and language
        /// </summary>
        [XmlEnum("sl")]
        SL,

        /// <summary>
        /// Finnish locale and language
        /// </summary>
        [XmlEnum("fi")]
        FI,

        /// <summary>
        /// Norwegian locale and language
        /// </summary>
        [XmlEnum("no")]
        NO,

        /// <summary>
        /// Danish locale and language
        /// </summary>
        [XmlEnum("da")]
        DA,

        /// <summary>
        /// Swedish locale and language
        /// </summary>
        [XmlEnum("sv")]
        SV
    }
}
