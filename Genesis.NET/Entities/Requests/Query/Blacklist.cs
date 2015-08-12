using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Query
{
    [XmlRoot("blacklist_request", Namespace = "Blacklist")]
    public class Blacklist : Request
    {
        public override string ApiPath
        {
            get
            {
                return "blacklists";
            }
        }

        [CreditCard]
        [Required]
        [XmlElement(ElementName="card_number")]
        public string CardNumber { get; set; }

        [XmlElement(ElementName="terminal_token")]
        public string TerminalToken { get; set; }
    }
}