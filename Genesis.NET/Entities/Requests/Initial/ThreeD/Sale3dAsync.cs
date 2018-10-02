using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using DataAnnotations = DataAnnotationsExtensions;

namespace Genesis.Net.Entities.Requests.Initial.ThreeD
{
    [XmlRoot("payment_transaction", Namespace = "Sale3DAsync")]
    public class Sale3dAsync : Sale3d
    {
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

        public Sale3dAsync() : base()
        {
        }
    }
}