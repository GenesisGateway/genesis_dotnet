using System.Xml.Serialization;
using CopaceticSoftware.pMixins.Attributes;
using Genesis.Net.Common;
using Genesis.Net.Common.ThreedsV2;

namespace Genesis.Net.Entities.Responses.Successful
{
    [pMixin(Mixin = typeof(AuthorizationModel))]
    [pMixin(Mixin = typeof(AcquirerModel))]
    [pMixin(Mixin = typeof(MotoModel))]
    [pMixin(Mixin = typeof(IssuerModel))]
    [pMixin(Mixin = typeof(TransactionTypeModel))]
    [pMixin(Mixin = typeof(TransactionStatusModel))]
    [pMixin(Mixin = typeof(TransactionModel))]
    [pMixin(Mixin = typeof(GamingModel))]
    [pMixin(Mixin = typeof(DynamicDescriptorModel))]
    [pMixin(Mixin = typeof(MoneyModel))]
    [pMixin(Mixin = typeof(RecurringAdviceModel))]
    [pMixin(Mixin = typeof(AsyncTransactionModel))]
    [pMixin(Mixin = typeof(AvsResponseModel))]
    [pMixin(Mixin = typeof(CvvResultCodeModel))]
    [pMixin(Mixin = typeof(RetrievalReferenceNumberModel))]
    [pMixin(Mixin = typeof(ThreeDSModel))]
    [pMixin(Mixin = typeof(ThreeDSMethodUrlsModel))]
    [pMixin(Mixin = typeof(RedirectUrlsModel))]
    [pMixin(Mixin = typeof(ErrorModel))]
    [XmlRoot("payment_response", Namespace = "CardTransactionSuccessResponse")]
    public partial class CardTransactionSuccessResponse : Entity
    {
        /// <remarks />
        public string GenerateSignature(Configuration configuration)
        {
            //var timeString = new DateTime(Time.Year, Time.Month, Time.Day, Time.Hour, Time.Minute, Time.Second, DateTimeKind.Utc).ToApiDate(Formatter.TIMESTAMP_FORMAT);
            var timeString = Time.ToApiDate(Formatter.TIMESTAMP_FORMAT);
            return Helpers.CreateSHA512Hash(UniqueId, ProxyAmount, timeString, configuration.ApiPassword);
        }
    }
}
