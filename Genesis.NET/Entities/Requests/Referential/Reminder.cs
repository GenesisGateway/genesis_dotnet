using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Referential
{
    public class Reminder : Entity
    {
        [XmlElement(ElementName = "channel")]
        public string Channel { get; set; }

        private int? _After;
        [XmlElement(ElementName = "after")]
        public int? After
        {
            get { return _After; }
            set
            {
                _After = value > 0 ? value : null;
            }
        }
    }
}
