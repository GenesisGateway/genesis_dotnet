using System.Xml.Serialization;
using Genesis.NetCore.Entities.Enums;
using Genesis.NetCore.Entities.Responses.Models;
using Genesis.NetCore.Errors;

namespace Genesis.NetCore.Entities.Responses.Error
{
    /// <remarks />
    [XmlRoot("payment_response", Namespace = "CardTransactionErrorResponse")]
    public class CardTransactionErrorResponse :
        MoneyAndTransactionAndMotoModel,
        IMoneyModel,
        ITransactionModel,
        IMotoModel,
        IAcquirerModel,
        IAuthorizationModel,
        IAvsResponseModel,
        ICvvResultCodeModel,
        IDynamicDescriptorModel,
        IErrorResponse,
        IGamingModel,
        IIssuerModel,
        IRetrievalReferenceNumberModel,
        IThreeDSModel,
        ITransactionStatusModel,
        ITransactionTypeModel
    {
        public bool SentToAcquirer { get; set; }
        public string AuthorizationCode { get; set; }
        public string AvsResponseCode { get; set; }
        public string AvsResponseText { get; set; }
        public string CvvResultCode { get; set; }
        public DynamicDescriptor DynamicDescriptorParams { get; set; }
        [XmlElement(ElementName = "code")]
        public ErrorCodes Code { get; set; }

        [XmlElement(ElementName = "technical_message")]
        public string TechnicalMessage { get; set; }

        [XmlElement(ElementName = "message")]
        public string Message { get; set; }
        public bool? Gaming { get; set; }
        public string ResponseCode { get; set; }
        public string RetrievalReferenceNumber { get; set; }
        public ThreeDSElementModel ThreeDS { get; set; }
        public TransactionStates? Status { get; set; }
        public TransactionTypes TransactionType { get; set; }
    }
}
