using System.Xml.Serialization;
using Genesis.NetCore.Common;
using Genesis.NetCore.Common.ThreedsV2;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Enums.ThreeDS;
using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Models;
using Genesis.NetCore.Errors;

namespace Genesis.NetCore.Entities.Responses.Successful
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "CardTransactionSuccessResponse")]
    public class CardTransactionSuccessResponse :
        MoneyAndTransactionAndMotoModel,
        IMoneyModel,
        ITransactionModel,
        IMotoModel,
        IAcquirerModel,
        IAsyncTransactionModel,
        IAuthorizationModel,
        IAvsResponseModel,
        ICvvResultCodeModel,
        IDynamicDescriptorModel,
        IErrorResponse,
        IGamingModel,
        IIssuerModel,
        IRecurringAdviceModel,
        IRedirectUrlsModel,
        IRetrievalReferenceNumberModel,
        IThreeDSMethodUrlsModel,
        IThreeDSModel,
        ITransactionTypeModel,
        ITransactionStatusModel
    {
        public bool SentToAcquirer { get; set; }
        public string RedirectUrl { get; set; }
        public string AuthorizationCode { get; set; }
        public string AvsResponseCode { get; set; }
        public string AvsResponseText { get; set; }
        public string CvvResultCode { get; set; }
        public DynamicDescriptor DynamicDescriptorParams { get; set; }
        public ErrorCodes Code { get; set; }
        public string TechnicalMessage { get; set; }
        public string Message { get; set; }
        public bool? Gaming { get; set; }
        public string ResponseCode { get; set; }
        public string RecurringAdviceCode { get; set; }
        public string RecurringAdviceText { get; set; }
        public RedirectUrlTypes RedirectUrlType { get; set; }
        public string RetrievalReferenceNumber { get; set; }
        public string ThreedsMethodUrl { get; set; }
        public string ThreedsMethodContinueUrl { get; set; }
        public ThreeDSElementModel ThreeDS { get; set; }
        public TransactionTypes TransactionType { get; set; }
        public TransactionStates? Status { get; set; }

        /// <remarks />
        public string GenerateSignature(Configuration configuration)
        {
            //var timeString = new DateTime(Time.Year, Time.Month, Time.Day, Time.Hour, Time.Minute, Time.Second, DateTimeKind.Utc).ToApiDate(Formatter.TIMESTAMP_FORMAT);
            var timeString = Time.ToApiDate(Formatter.TIMESTAMP_FORMAT);
            return Helpers.CreateSHA512Hash(UniqueId, ProxyAmount, timeString, configuration.ApiPassword);
        }
    }
}
