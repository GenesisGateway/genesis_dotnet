using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.NetCore.Entities
{
    public class DynamicDescriptor : IEntity
    {
        public DynamicDescriptor() { }

        /// <summary>
        /// Allows to dynamically override the charge descriptor
        /// </summary>
        [StringLength(25)]
        [XmlElement(ElementName = "merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// Allows to dynamically override the merchant phone number
        /// </summary>
        [StringLength(13)]
        [XmlElement(ElementName = "merchant_city")]
        public string MerchantCity { get; set; }

        /// <summary>
        /// Allows to dynamically override the sub-merchant ID.
        /// </summary>
        [StringLength(15)]
        [XmlElement(ElementName = "sub_merchant_id")]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// Allows to dynamically override the merchant country.
        /// </summary>
        [StringLength(3)]
        [XmlElement(ElementName = "merchant_country")]
        public string MerchantCountry { get; set; }

        /// <summary>
        /// Allows to dynamically override the merchant subdivision code.
        /// </summary>
        [StringLength(3)]
        [XmlElement(ElementName = "merchant_state")]
        public string MerchantState { get; set; }

        /// <summary>
        /// Allows to dynamically override the merchant zip/postal code. Required for VISA OCT transactions with Australian and Canadian card bins.
        /// </summary>
        [StringLength(10)]
        [XmlElement(ElementName = "merchant_zip_code")]
        public string MerchantZipCode { get; set; }

        /// <summary>
        /// Allows to dynamically override the merchant address.
        /// </summary>
        [StringLength(48)]
        [XmlElement(ElementName = "merchant_address")]
        public string MerchantAddress { get; set; }

        /// <summary>
        /// Allows to dynamically override the merchant URL
        /// </summary>
        [StringLength(60)]
        [XmlElement(ElementName = "merchant_url")]
        public string MerchantUrl { get; set; }

        /// <summary>
        /// Allows to dynamically override the merchant phone number.
        /// </summary>
        [StringLength(16)]
        [XmlElement(ElementName = "merchant_phone")]
        public string MerchantPhone { get; set; }

        /// <summary>
        /// Allows to dynamically override the merchant service city.
        /// </summary>
        [StringLength(13)]
        [XmlElement(ElementName = "merchant_service_city")]
        public string MerchantServiceCity { get; set; }

        /// <summary>
        /// Allows to dynamically override the merchant service country.
        /// </summary>
        [StringLength(3)]
        [XmlElement(ElementName = "merchant_service_country")]
        public string MerchantServiceCountry { get; set; }

        /// <summary>
        /// Allows to dynamically override the merchant service subdivision code.
        /// </summary>
        [StringLength(3)]
        [XmlElement(ElementName = "merchant_service_state")]
        public string MerchantServiceState { get; set; }

        /// <summary>
        /// Allows to dynamically override the merchant service zip/postal code.
        /// </summary>
        [StringLength(10)]
        [XmlElement(ElementName = "merchant_service_zip_code")]
        public string MerchantServiceZipCode { get; set; }

        /// <summary>
        /// Allows to dynamically override the merchant service phone number.
        /// </summary>
        [StringLength(16)]
        [XmlElement(ElementName = "merchant_service_phone")]
        public string MerchantServicePhone { get; set; }

        /// <summary>
        /// Allows to dynamically override the merchant geographic coordinates.
        /// </summary>
        [StringLength(20)]
        [XmlElement(ElementName = "merchant_geo_coordinates")]
        public string MerchantGeoCoordinates { get; set; }

        /// <summary>
        /// Allows to dynamically override the merchant service geographic coordinates.
        /// </summary>
        [StringLength(20)]
        [XmlElement(ElementName = "merchant_service_geo_coordinates")]
        public string MerchantServiceGeoCoordinates { get; set; }
    }
}
