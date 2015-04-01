using System;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class RetrievalResponseModel
    {
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "arn")]
        public string Arn { get; set; }

        [XmlIgnore]
        public DateTime PostDate { get; set; }

        [XmlElement(ElementName = "post_date")]
        public string ProxyPostDate
        {
            get
            {
                return Formatter.FormatToString(PostDate);
            }
            set
            {
                PostDate = Formatter.FormatFromString(value);
            }
        }

        [XmlElement(ElementName = "reason_code")]
        public string ReasonCode { get; set; }

        [XmlElement(ElementName = "reason_description")]
        public string ReasonDescription { get; set; }

        [XmlElement(ElementName = "card_number")]
        public string CardNumber { get; set; }

        [XmlElement(ElementName = "card_brand")]
        public string CardBrand { get; set; }

        [XmlElement(ElementName = "original_transaction_unique_id")]
        public string OriginalTransactionUniqueId { get; set; }
    }
}
