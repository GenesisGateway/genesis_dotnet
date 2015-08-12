using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class ItemsRangeModel
    {
        [XmlAttribute(AttributeName = "per_page")]
        public int ItemsPerPage { get; set; }

        [XmlAttribute(AttributeName = "page")]
        public int PageNumber { get; set; }

        [XmlAttribute(AttributeName = "total_count")]
        public int TotalCount { get; set; }

        [XmlAttribute(AttributeName = "pages_count")]
        public int PagesCount { get; set; }
    }
}