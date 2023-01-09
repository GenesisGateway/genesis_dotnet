using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Query
{
    public abstract class QueryByDate : Request
    {
        [Required]
        [XmlIgnore]
        public DateTime StartDate { get; set; }

        [XmlElement(ElementName = "start_date")]
        public string ProxyStartDate
        {
            get { return Formatter.FormatToString(StartDate); }
            set { StartDate = DateTime.Parse(value); }
        }

        [XmlIgnore]
        public DateTime EndDate { get; set; }

        [XmlElement(ElementName = "end_date")]
        public string ProxyEndDate
        {
            get { return Formatter.FormatToString(EndDate); }
            set { EndDate = DateTime.Parse(value); }
        }

        [Range(1, Int32.MaxValue)]
        [XmlElement(ElementName = "page")]
        public int Page { get; set; }
    }
}