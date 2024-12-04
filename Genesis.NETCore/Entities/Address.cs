using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Genesis.NetCore.Common;
using Genesis.NetCore.Validations;

namespace Genesis.NetCore.Entities
{
    public class Address : IEntity
    {
        [StringLength(255)]
        [XmlElement(ElementName = "first_name")]
        public string FirstName { get; set; }

        [StringLength(255)]
        [XmlElement(ElementName = "last_name")]
        public string LastName { get; set; }

        [StringLength(255)]
        [XmlElement(ElementName = "address1")]
        public string Address1 { get; set; }

        [StringLength(255)]
        [XmlElement(ElementName = "address2")]
        public string Address2 { get; set; }

        [XmlElement(ElementName = "zip_code")]
        public string ZipCode { get; set; }

        [XmlElement(ElementName = "city")]
        public string City { get; set; }

        [StateCode]
        [XmlElement(ElementName = "state")]
        public string State { get; set; }

        [XmlElement(ElementName = "country")]
        public Iso3166CountryCodes? Country { get; set; }

        [StringLength(255)]
        [XmlElement(ElementName = "neighborhood")]
        public string Neighborhood { get; set; }
    }
}