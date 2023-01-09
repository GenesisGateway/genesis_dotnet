using System.Xml.Serialization;

namespace Genesis.NetCore.Entities.Requests.Referential
{
    public class Reminder : IEntity
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
