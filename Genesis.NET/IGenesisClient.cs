using System.Threading.Tasks;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Entities.Requests.Initial.ThreeD;
using Genesis.Net.Entities.Requests.Referential;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Entities.Requests.Query;

namespace Genesis.Net
{
    public interface IGenesisClient
    {
        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<AuthorizeSuccessResponse, AuthorizeErrorResponse> Execute(Authorize authorize);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<AuthorizeSuccessResponse, AuthorizeErrorResponse>> ExecuteAsync(Authorize authorize);

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
        Result<SaleSuccessResponse, SaleErrorResponse> Execute(Sale sale);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<SaleSuccessResponse, SaleErrorResponse>> ExecuteAsync(Sale sale);

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

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<Authorize3dSuccessResponse, Authorize3dErrorResponse> Execute(Authorize3d authorize3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<Authorize3dSuccessResponse, Authorize3dErrorResponse>> ExecuteAsync(Authorize3d authorize3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<Sale3dSuccessResponse, Sale3dErrorResponse> Execute(Sale3d sale3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<Sale3dSuccessResponse, Sale3dErrorResponse>> ExecuteAsync(Sale3d sale3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<InitRecurringSale3dSuccessResponse, InitRecurringSale3dErrorResponse> Execute(InitRecurringSale3d initRecurringSale3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<InitRecurringSale3dSuccessResponse, InitRecurringSale3dErrorResponse>> ExecuteAsync(InitRecurringSale3d initRecurringSale3d);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Result<InitRecurringSaleSuccessResponse, InitRecurringSaleErrorResponse> Execute(InitRecurringSale initRecurringSale);

        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException"/>
        /// <exception cref="T:System.Net.WebException"/>
        /// <exception cref="T:System.IO.InvalidDataException"/>
        Task<Result<InitRecurringSaleSuccessResponse, InitRecurringSaleErrorResponse>> ExecuteAsync(InitRecurringSale initRecurringSale);

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
    }
}
