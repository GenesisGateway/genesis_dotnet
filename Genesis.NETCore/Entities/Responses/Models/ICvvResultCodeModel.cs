using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface ICvvResultCodeModel
    {
        /// <summary>
        /// Card Verification Value response code. Optional, returned only if acquirer supports it.
        /// </summary>
        [MaxLength(1)]
        [XmlElement("cvv_result_code")]
        string CvvResultCode { get; set; }
    }
}
