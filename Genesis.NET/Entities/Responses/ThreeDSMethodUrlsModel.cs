using System.Xml.Serialization;

namespace Genesis.Net.Entities.Responses
{
    /// <remarks />
    public class ThreeDSMethodUrlsModel
    {
        /// <summary>
        /// The URL action where the 3DS-Method needs to be submitted using HTTP POST
        /// </summary>
        [XmlElement("threeds_method_url")]
        public string ThreedsMethodUrl { get; set; }

        /// <summary>
        /// API endpoint that accepts HTTP PUT requests with a signature and returns transaction API response identifying what the next step is (transaction completed or consumer interaction is needed)
        /// </summary>
        [XmlElement("threeds_method_continue_url")]
        public string ThreedsMethodContinueUrl { get; set; }
    }
}
