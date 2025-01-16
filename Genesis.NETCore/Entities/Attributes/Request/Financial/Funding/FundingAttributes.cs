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
        /// Type of Mastercard Funding Transaction
        /// </summary>
        [XmlElement(ElementName = "identifier_type")]
        public IdentifierType? IdentifierType { get; set; }

        public bool IdentifierTypeSpecified
        {
            get
            {
                return this.IdentifierType.HasValue;
            }
        }

        /// <summary>
        /// Type of VISA Funding Transaction.
        /// </summary>
        [XmlElement(ElementName = "business_application_identifier")]
        public BusinessApplicationIdentifier? BusinessApplicationIdentifier { get; set; }

        public bool BusinessApplicationIdentifierSpecified
        {
            get
            {
                return this.BusinessApplicationIdentifier.HasValue;
            }
        }

        /// <summary>
        /// Funding Transaction Receiver details
        /// </summary>
        [XmlElement(ElementName = "receiver")]
        public Receiver Receiver { get; set; }

        /// <summary>
        /// Funding Transaction Sender details
        /// </summary>
        [XmlElement(ElementName = "sender")]
        public Sender Sender { get; set; }
    }
}
