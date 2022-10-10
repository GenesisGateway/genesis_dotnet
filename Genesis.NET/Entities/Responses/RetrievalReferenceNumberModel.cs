using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    internal class RetrievalReferenceNumberModel
    {
        /// <summary>
        /// A reference number used for tracking all messages related to a given cardholder transaction returned by some acquirers.
        /// </summary>
        [MaxLength(255)]
        [XmlElement("retrieval_reference_number")]
        public string RetrievalReferenceNumber { get; set; }
    }
}
