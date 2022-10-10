using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using DataAnnotations = DataAnnotationsExtensions;

namespace Genesis.Net.Entities.Requests.Initial.ThreeD
{
    /// <summary>
    /// This class is deprecated. Please use: <see cref="Genesis.Net.Entities.Requests.Initial.Sale3d"/>
    /// </summary>
    [XmlRoot("payment_transaction", Namespace = "Sale3DAsync")]
    [Obsolete("This class is deprecated. Please use Genesis.Net.Entities.Requests.Initial.Sale3d")]
    public class Sale3dAsync : Sale3d
    {
        public Sale3dAsync() : base()
        {
        }

        [DataAnnotations.Url(DataAnnotations.UrlOptions.OptionalProtocol)]
        [Required]
        [XmlElement(ElementName="notification_url")]
        public string NotificationUrl { get; set; }

        [DataAnnotations.Url(DataAnnotations.UrlOptions.OptionalProtocol)]
        [Required]
        [XmlElement(ElementName="return_success_url")]
        public string ReturnSuccessUrl { get; set; }

        [DataAnnotations.Url(DataAnnotations.UrlOptions.OptionalProtocol)]
        [Required]
        [XmlElement(ElementName="return_failure_url")]
        public string ReturnFailureUrl { get; set; }
    }
}