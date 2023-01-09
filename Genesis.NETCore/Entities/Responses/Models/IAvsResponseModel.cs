using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IAvsResponseModel
    {
        [XmlElement(ElementName = "avs_response_code")]
        string AvsResponseCode { get; set; }

        [XmlElement(ElementName = "avs_response_text")]
        string AvsResponseText { get; set; }
    }
}