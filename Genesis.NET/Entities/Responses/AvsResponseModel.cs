using System;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class AvsResponseModel
    {
        [XmlElement(ElementName = "avs_response_code")]
        public string AvsResponseCode { get; set; }

        [XmlElement(ElementName = "avs_response_text")]
        public string AvsResponseText { get; set; }
    }
}