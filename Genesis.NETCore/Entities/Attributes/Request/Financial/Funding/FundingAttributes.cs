using Genesis.NetCore.Entities.Enums.Funding;
using System;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Attributes.Request.Financial.Funding
{
    /// <summary>
    /// Funding Transaction Params
    /// </summary>
    [Serializable]
    public class FundingAttributes : IEntity
    {
        /// <summary>
        /// Type of Funding Transaction
        /// </summary>
        [XmlElement(ElementName = "identifier_type")]
        public IdentifierType IdentifierType { get; set; }

        /// <summary>
        /// Funding Transaction Receiver details
        /// </summary>
        [XmlElement(ElementName = "receiver")]
        public Receiver Receiver { get; set; }
    }
}
