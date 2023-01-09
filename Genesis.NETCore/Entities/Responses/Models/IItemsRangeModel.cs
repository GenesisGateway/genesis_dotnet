using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IItemsRangeModel
    {
        [XmlAttribute(AttributeName = "per_page")]
        int ItemsPerPage { get; set; }

        [XmlAttribute(AttributeName = "page")]
        int PageNumber { get; set; }

        [XmlAttribute(AttributeName = "total_count")]
        int TotalCount { get; set; }

        [XmlAttribute(AttributeName = "pages_count")]
        int PagesCount { get; set; }
    }
}