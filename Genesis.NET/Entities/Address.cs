using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Serialization;
using Genesis.Net.Common;
using Genesis.Net.Validations;

namespace Genesis.Net.Entities
{
    public class Address : Entity
    {
        [StringLength(255)]
        [Required]
        [XmlElement(ElementName="first_name")]
        public string FirstName { get; set; }

        [StringLength(255)]
        [Required]
        [XmlElement(ElementName="last_name")]
        public string LastName { get; set; }

        [StringLength(255)]
        [Required]
        [XmlElement(ElementName="address1")]
        public string Address1 { get; set; }

        [StringLength(255)]
        [XmlElement(ElementName="address2")]
        public string Address2 { get; set; }

        [Required]
        [XmlElement(ElementName="zip_code")]
        public string ZipCode { get; set; }

        [Required]
        [XmlElement(ElementName="city")]
        public string City { get; set; }

        [StateCode]
        [XmlElement(ElementName="state")]
        public string State { get; set; }

        [Required]
        [XmlElement(ElementName="country")]
        public Iso3166CountryCodes Country { get; set; }

        public Address()
        {
        }
    }
}