using System.Threading.Tasks;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Entities.Requests.Referential;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Entities.Requests.Query;
using Genesis.Net.Entities.Requests.Initial.Threedsv2;

namespace Genesis.Net
{
    public interface IGenesisClient
    {
        #region deprecated
        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<CardTransactionSuccessResponse, CardTransactionErrorResponse> Execute(Authorize authorize);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<CardTransactionSuccessResponse, CardTransactionErrorResponse>> ExecuteAsync(Authorize authorize);
        #endregion

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<CaptureSuccessResponse, CaptureErrorResponse> Execute(Capture capture);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<CaptureSuccessResponse, CaptureErrorResponse>> ExecuteAsync(Capture capture);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<CardTransactionSuccessResponse, CardTransactionErrorResponse> Execute(Sale sale);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<CardTransactionSuccessResponse, CardTransactionErrorResponse>> ExecuteAsync(Sale sale);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<RefundSuccessResponse, RefundErrorResponse> Execute(Refund refund);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<RefundSuccessResponse, RefundErrorResponse>> ExecuteAsync(Refund refund);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<VoidSuccessResponse, VoidErrorResponse> Execute(VoidRequest @void);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<VoidSuccessResponse, VoidErrorResponse>> ExecuteAsync(VoidRequest @void);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<CreditSuccessResponse, CreditErrorResponse> Execute(Credit credit);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<CreditSuccessResponse, CreditErrorResponse>> ExecuteAsync(Credit credit);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<PayoutSuccessResponse, PayoutErrorResponse> Execute(Payout payout);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<PayoutSuccessResponse, PayoutErrorResponse>> ExecuteAsync(Payout payout);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<AccountVerificationSuccessResponse, AccountVerificationErrorResponse> Execute(AccountVerification accountVerification);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<AccountVerificationSuccessResponse, AccountVerificationErrorResponse>> ExecuteAsync(AccountVerification accountVerification);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<AvsSuccessResponse, AvsErrorResponse> Execute(Avs avs);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<AvsSuccessResponse, AvsErrorResponse>> ExecuteAsync(Avs avs);

        #region deprecated
        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<Authorize3dSuccessResponse, Authorize3dErrorResponse> Execute(Entities.Requests.Initial.ThreeD.Authorize3d authorize3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<Authorize3dSuccessResponse, Authorize3dErrorResponse>> ExecuteAsync(Entities.Requests.Initial.ThreeD.Authorize3d authorize3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<Sale3dSuccessResponse, Sale3dErrorResponse> Execute(Entities.Requests.Initial.ThreeD.Sale3d sale3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<Sale3dSuccessResponse, Sale3dErrorResponse>> ExecuteAsync(Entities.Requests.Initial.ThreeD.Sale3d sale3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<InitRecurringSale3dSuccessResponse, InitRecurringSale3dErrorResponse> Execute(Entities.Requests.Initial.ThreeD.InitRecurringSale3d initRecurringSale3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<InitRecurringSale3dSuccessResponse, InitRecurringSale3dErrorResponse>> ExecuteAsync(Entities.Requests.Initial.ThreeD.InitRecurringSale3d initRecurringSale3d);
        #endregion

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<CardTransactionSuccessResponse, CardTransactionErrorResponse> Execute(Authorize3d authorize3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<CardTransactionSuccessResponse, CardTransactionErrorResponse>> ExecuteAsync(Authorize3d authorize3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<CardTransactionSuccessResponse, CardTransactionErrorResponse> Execute(Sale3d sale3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<CardTransactionSuccessResponse, CardTransactionErrorResponse>> ExecuteAsync(Sale3d sale3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<CardTransactionSuccessResponse, CardTransactionErrorResponse> Execute(InitRecurringSale3d initRecurringSale3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<CardTransactionSuccessResponse, CardTransactionErrorResponse>> ExecuteAsync(InitRecurringSale3d initRecurringSale3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<CardTransactionSuccessResponse, CardTransactionErrorResponse> Execute(InitRecurringSale initRecurringSale);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<CardTransactionSuccessResponse, CardTransactionErrorResponse>> ExecuteAsync(InitRecurringSale initRecurringSale);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<RecurringSaleSuccessResponse, RecurringSaleErrorResponse> Execute(RecurringSale recurringSale);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<RecurringSaleSuccessResponse, RecurringSaleErrorResponse>> ExecuteAsync(RecurringSale recurringSale);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<SingleReconcileSuccessResponse, SingleReconcileErrorResponse> Execute(SingleReconcile singleReconcile);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<SingleReconcileSuccessResponse, SingleReconcileErrorResponse>> ExecuteAsync(SingleReconcile singleReconcile);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<MultiReconcileSuccessResponse, MultiReconcileErrorResponse> Execute(MultiReconcile singleReconcile);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<MultiReconcileSuccessResponse, MultiReconcileErrorResponse>> ExecuteAsync(MultiReconcile singleReconcile);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<SingleRetrievalRequestSuccessResponse, SingleRetrievalRequestErrorResponse> Execute(SingleRetrievalRequest singleRetrieval);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<SingleRetrievalRequestSuccessResponse, SingleRetrievalRequestErrorResponse>> ExecuteAsync(SingleRetrievalRequest singleRetrieval);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<MultiRetrievalRequestSuccessResponse, MultiRetrievalRequestErrorResponse> Execute(MultiRetrievalRequest multiRetrieval);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<MultiRetrievalRequestSuccessResponse, MultiRetrievalRequestErrorResponse>> ExecuteAsync(MultiRetrievalRequest multiRetrieval);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<SingleChargebackSuccessResponse, SingleChargebackErrorResponse> Execute(SingleChargeback singleChargeback);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<SingleChargebackSuccessResponse, SingleChargebackErrorResponse>> ExecuteAsync(SingleChargeback singleChargeback);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<MultiChargebackSuccessResponse, MultiChargebackErrorResponse> Execute(MultiChargeback multiChargeback);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<MultiChargebackSuccessResponse, MultiChargebackErrorResponse>> ExecuteAsync(MultiChargeback multiChargeback);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<BlacklistSuccessResponse, BlacklistErrorResponse> Execute(Blacklist blacklist);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<BlacklistSuccessResponse, BlacklistErrorResponse>> ExecuteAsync(Blacklist blacklist);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<WpfCreateSuccessResponse, WpfCreateErrorResponse> Execute(WpfCreate wpfCreate);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<WpfCreateSuccessResponse, WpfCreateErrorResponse>> ExecuteAsync(WpfCreate wpfCreate);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<WpfReconcileSuccessResponse, WpfReconcileErrorResponse> Execute(WpfReconcile wpfReconcile);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<WpfReconcileSuccessResponse, WpfReconcileErrorResponse>> ExecuteAsync(WpfReconcile wpfReconcile);
                
        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<GooglePaySuccessResponse, GooglePayErrorResponse> Execute(GooglePay googlePay);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<GooglePaySuccessResponse, GooglePayErrorResponse>> ExecuteAsync(GooglePay googlePay);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<ApplePaySuccessResponse, ApplePayErrorResponse> Execute(ApplePay applePay);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<ApplePaySuccessResponse, ApplePayErrorResponse>> ExecuteAsync(ApplePay applePay);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<CardTransactionSuccessResponse, CardTransactionErrorResponse> Execute(ContinueRequest initThreeDSv2ContinueRequest);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<CardTransactionSuccessResponse, CardTransactionErrorResponse>> ExecuteAsync(ContinueRequest initThreeDSv2ContinueRequest);
    }
}
