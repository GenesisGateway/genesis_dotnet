using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Responses.Models
{
    internal interface IRetrievalReferenceNumberModel
    {
        /// <summary>
        /// A reference number used for tracking all messages related to a given cardholder transaction returned by some acquirers.
        /// </summary>
        [MaxLength(255)]
        [XmlElement("retrieval_reference_number")]
        string RetrievalReferenceNumber { get; set; }
    }
}
