using System;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    public interface IRetrievalResponseModel
    {
        [XmlElement(ElementName = "type")]
        string Type { get; set; }

        [XmlElement(ElementName = "arn")]
        string Arn { get; set; }

        [XmlIgnore]
        DateTime PostDate { get; set; }

        [XmlElement(ElementName = "post_date")]
        string ProxyPostDate { get; set; }

        [XmlElement(ElementName = "reason_code")]
        string ReasonCode { get; set; }

        [XmlElement(ElementName = "reason_description")]
        string ReasonDescription { get; set; }

        [XmlElement(ElementName = "card_number")]
        string CardNumber { get; set; }

        [XmlElement(ElementName = "card_brand")]
        string CardBrand { get; set; }

        [XmlElement(ElementName = "original_transaction_unique_id")]
        string OriginalTransactionUniqueId { get; set; }
    }
}