using System;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Attributes.Request.Financial.Funding
{
    /// <summary>
    /// Funding Transaction Receiver details. Required for Visa transactions.
    /// </summary>
    [Serializable]
    public class Sender : IEntity
    {
        /// <summary>
        /// Sender name
        /// </summary>
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Sender Reference Number
        /// </summary>
        [XmlElement(ElementName = "reference_number")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Sender country
        /// </summary>
        [XmlElement(ElementName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Sender address
        /// </summary>
        [XmlElement(ElementName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Sender state
        /// </summary>
        [XmlElement(ElementName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Sender city
        /// </summary>
        [XmlElement(ElementName = "city")]
        public string City { get; set; }
    }
}
