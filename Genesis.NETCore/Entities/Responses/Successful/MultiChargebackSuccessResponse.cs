using System.Xml.Serialization;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("chargeback_responses", Namespace = "MultiChargebackSuccessResponse")]
    public class MultiChargebackSuccessResponse :
        IResponse,
        IChargebackModel,
        IItemsRangeModel
    {
        public ChargebackResponse[] Chargebacks { get; set; }
        public int ItemsPerPage { get; set; }
        public int PageNumber { get; set; }
        public int TotalCount { get; set; }
        public int PagesCount { get; set; }
    }
}