using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genesis.Net.Entities
{
    public class FundsStatusModel
    {
        [XmlElement(ElementName = "funds_status")]
        public string FundsStatus { get; set; }
    }
}
