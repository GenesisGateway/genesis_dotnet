using System.Xml.Serialization;
using Genesis.NetCore.Entities.Responses.Models;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_responses", Namespace = "MultiReconcileSuccessResponse")]
    public class MultiReconcileSuccessResponse :
        IResponse,
        IItemsRangeModel,
        IPaymentResponseModel
    {
        public int ItemsPerPage { get; set; }
        public int PageNumber { get; set; }
        public int TotalCount { get; set; }
        public int PagesCount { get; set; }
        public PaymentResponse[] Payments { get; set; }
    }
}