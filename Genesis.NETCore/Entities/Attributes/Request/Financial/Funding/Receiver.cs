using Genesis.NetCore.Common;
using Genesis.NetCore.Entities.Enums.Funding;
using System;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Attributes.Request.Financial.Funding
{
    /// <summary>
    /// Funding Transaction Receiver details
    /// </summary>
    [Serializable]
    public class Receiver : IEntity
    {
        /// <summary>
        /// First name of the receiver
        /// </summary>
        [XmlElement(ElementName = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the receiver
        /// </summary>
        [XmlElement(ElementName = "last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Country code in ISO 3166
        /// </summary>
        [XmlElement(ElementName = "country")]
        public Iso3166CountryCodes? Country { get; set; }

        /// <summary>
        /// Receiver account number
        /// </summary>
        [XmlElement(ElementName = "account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Receiver account number type.
        /// </summary>
        [XmlElement(ElementName = "account_number_type")]
        public ReceiverAccountNumberType? AccountNumberType { get; set; }
    }
}
