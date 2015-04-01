using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Serialization;
using Genesis.Net.Validations;

namespace Genesis.Net.Entities
{
    public class RiskParams : Entity
    {
        [StringLength(128)]
        [XmlElement(ElementName="ssn")]
        public string Ssn { get; set; }

        [StringLength(128)]
        [XmlElement(ElementName="mac_address")]
        public string MacAddress { get; set; }

        [StringLength(128)]
        [XmlElement(ElementName="session_id")]
        public string SessionId { get; set; }

        [StringLength(128)]
        [XmlElement(ElementName="user_id")]
        public string UserId { get; set; }

        [StringLength(128)]
        [XmlElement(ElementName="user_level")]
        public string UserLevel { get; set; }

        [EmailAddress]
        [StringLength(128)]
        [XmlElement(ElementName="email")]
        public string Email { get; set; }

        [StringLength(128)]
        [XmlElement(ElementName="phone")]
        public string Phone { get; set; }

        [IPv4Address]
        [XmlElement(ElementName="remote_ip")]
        public string RemoteIp { get; set; }

        [StringLength(128)]
        [XmlElement(ElementName="serial_number")]
        public string SerialNumber { get; set; }

        public RiskParams() { }
    }
}
