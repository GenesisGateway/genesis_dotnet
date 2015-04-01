using System.Xml.Serialization;

namespace Genesis.Net.Entities.Requests.Query
{
    [XmlRoot("reconcile", Namespace = "MultiReconcile")]
    public class MultiReconcile : QueryByDate
    {
        public override string ApiPath
        {
            get
            {
                return "reconcile/by_date";
            }
        }

        public MultiReconcile()
        {
        }
    }
}