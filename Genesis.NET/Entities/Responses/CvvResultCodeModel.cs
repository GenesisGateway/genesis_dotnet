using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class CvvResultCodeModel
    {
        /// <summary>
        /// Card Verification Value response code. Optional, returned only if acquirer supports it.
        /// </summary>
        [MaxLength(1)]
        [XmlElement("cvv_result_code")]
        public string CvvResultCode { get; set; }
    }
}
