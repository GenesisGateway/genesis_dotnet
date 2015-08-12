using System;
using System.Linq;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Entities.Requests.Initial.ThreeD;
using Genesis.Net.Entities.Requests.Query;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Specs.Mocks;
using NSpec;
using Genesis.Net.Entities.Requests.Referential;

namespace Genesis.Net.Specs
{
    class describe_genesis_client : nspec
    {
        protected IGenesisClient genesis;

        protected void before_each()
        {
            genesis = SpecHelper.CreateGenesisClient(mockHttpWebRequests: true);
        }

        void it_should_correctly_process_Authorize_requests()
        {
            var validAuthorize = RequestMocksFactory.CreateValidAuthorize().Instance;
            var invallidAuthorize = RequestMocksFactory.CreateValidAuthorize().Instance;
            invallidAuthorize.Amount = -1;

            var specsContainer = new describe_transaction_execution<Authorize, AuthorizeSuccessResponse, AuthorizeErrorResponse>(genesis, validAuthorize,
                ResponseMocksFactory.CreateAuthorizeSuccessResponse().Xml, ResponseMocksFactory.CreateAuthorizeErrorResponse().Xml, invallidAuthorize);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_AccountVerification_requests()
        {
            var validAccountVerification = RequestMocksFactory.CreateValidAccountVerification().Instance;
            var invalidAccountVerification = RequestMocksFactory.CreateValidAccountVerification().Instance;
            invalidAccountVerification.Amount = -1;

            var specsContainer = new describe_transaction_execution<AccountVerification, AccountVerificationSuccessResponse, AccountVerificationErrorResponse>(genesis, validAccountVerification,
                ResponseMocksFactory.CreateAccountVerificationSuccessResponse().Xml, ResponseMocksFactory.CreateAccountVerificationErrorResponse().Xml, invalidAccountVerification);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_Avs_requests()
        {
            var validAvs = RequestMocksFactory.CreateValidAvs().Instance;
            var invalidAvs = RequestMocksFactory.CreateValidAvs().Instance;
            invalidAvs.Amount = -1;

            var specsContainer = new describe_transaction_execution<Avs, AvsSuccessResponse, AvsErrorResponse>(genesis, validAvs,
                ResponseMocksFactory.CreateAvsSuccessResponse().Xml, ResponseMocksFactory.CreateAvsErrorResponse().Xml, invalidAvs);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_InitRecurringSale_requests()
        {
            var validInitRecurringSale = RequestMocksFactory.CreateValidInitRecurringSale().Instance;
            var invalidInitRecurringSale = RequestMocksFactory.CreateValidInitRecurringSale().Instance;
            invalidInitRecurringSale.Amount = -1;

            var specsContainer = new describe_transaction_execution<InitRecurringSale, InitRecurringSaleSuccessResponse, InitRecurringSaleErrorResponse>(genesis, validInitRecurringSale,
                ResponseMocksFactory.CreateInitRecurringSaleSuccessResponse().Xml, ResponseMocksFactory.CreateInitRecurringSaleErrorResponse().Xml, invalidInitRecurringSale);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_Payout_requests()
        {
            var validPayout = RequestMocksFactory.CreateValidPayout().Instance;
            var invalidPayout = RequestMocksFactory.CreateValidPayout().Instance;
            invalidPayout.Amount = -1;

            var specsContainer = new describe_transaction_execution<Payout, PayoutSuccessResponse, PayoutErrorResponse>(genesis, validPayout,
                ResponseMocksFactory.CreatePayoutSuccessResponse().Xml, ResponseMocksFactory.CreatePayoutErrorResponse().Xml, invalidPayout);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_Sale_requests()
        {
            var validPayout = RequestMocksFactory.CreateValidSale().Instance;
            var invalidPayout = RequestMocksFactory.CreateValidSale().Instance;
            invalidPayout.Amount = -1;

            var specsContainer = new describe_transaction_execution<Sale, SaleSuccessResponse, SaleErrorResponse>(genesis, validPayout,
                ResponseMocksFactory.CreateSaleSuccessResponse().Xml, ResponseMocksFactory.CreateSaleErrorResponse().Xml, invalidPayout);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_WpfCreate_requests()
        {
            var validWpfCreate = RequestMocksFactory.CreateValidWpfCreate().Instance;
            var invalidWpfCreate = RequestMocksFactory.CreateValidWpfCreate().Instance;
            invalidWpfCreate.Amount = -1;

            var specsContainer = new describe_transaction_execution<WpfCreate, WpfCreateSuccessResponse, WpfCreateErrorResponse>(genesis, validWpfCreate,
                ResponseMocksFactory.CreateWpfCreateSuccessResponse().Xml, ResponseMocksFactory.CreateWpfCreateErrorResponse().Xml, invalidWpfCreate);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_Authorize3dSync_requests()
        {
            var validAuthorize3dSync = RequestMocksFactory.CreateValidAuthorize3dSync().Instance;
            var invalidAuthorize3dSync = RequestMocksFactory.CreateValidAuthorize3dSync().Instance;
            invalidAuthorize3dSync.Amount = -1;

            var specsContainer = new describe_transaction_execution<Authorize3d, Authorize3dSuccessResponse, Authorize3dErrorResponse>(genesis, validAuthorize3dSync,
                ResponseMocksFactory.CreateAuthorize3dSyncSuccessResponse().Xml, ResponseMocksFactory.CreateAuthorize3dErrorResponse().Xml, invalidAuthorize3dSync);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_Authorize3dAsync_requests()
        {
            var validAuthorize3dAsync = RequestMocksFactory.CreateValidAuthorize3dAsync().Instance;
            var invalidAuthorize3dAsync = RequestMocksFactory.CreateValidAuthorize3dAsync().Instance;
            invalidAuthorize3dAsync.Amount = -1;

            var specsContainer = new describe_transaction_execution<Authorize3d, Authorize3dSuccessResponse, Authorize3dErrorResponse>(genesis, validAuthorize3dAsync,
                ResponseMocksFactory.CreateAuthorize3dAsyncSuccessResponse().Xml, ResponseMocksFactory.CreateAuthorize3dErrorResponse().Xml, invalidAuthorize3dAsync);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_InitRecurringSale3dSync_requests()
        {
            var validInitRecurringSale3dSync = RequestMocksFactory.CreateValidInitRecurringSale3dSync().Instance;
            var invalidInitRecurringSale3dSync = RequestMocksFactory.CreateValidInitRecurringSale3dSync().Instance;
            invalidInitRecurringSale3dSync.Amount = -1;

            var specsContainer = new describe_transaction_execution<InitRecurringSale3d, InitRecurringSale3dSuccessResponse, InitRecurringSale3dErrorResponse>(genesis, validInitRecurringSale3dSync,
                ResponseMocksFactory.CreateInitRecurringSale3dSyncSuccessResponse().Xml, ResponseMocksFactory.CreateInitRecurringSale3dErrorResponse().Xml, invalidInitRecurringSale3dSync);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_InitRecurringSale3dAsync_requests()
        {
            var validInitRecurringSale3dAsync = RequestMocksFactory.CreateValidInitRecurringSale3dAsync().Instance;
            var invalidInitRecurringSale3dAsync = RequestMocksFactory.CreateValidInitRecurringSale3dAsync().Instance;
            invalidInitRecurringSale3dAsync.Amount = -1;

            var specsContainer = new describe_transaction_execution<InitRecurringSale3d, InitRecurringSale3dSuccessResponse, InitRecurringSale3dErrorResponse>(genesis, validInitRecurringSale3dAsync,
                ResponseMocksFactory.CreateInitRecurringSale3dAsyncSuccessResponse().Xml, ResponseMocksFactory.CreateInitRecurringSale3dErrorResponse().Xml, invalidInitRecurringSale3dAsync);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_Sale3dSync_requests()
        {
            var validSale3dSync = RequestMocksFactory.CreateValidSale3dSync().Instance;
            var invalidSale3dSync = RequestMocksFactory.CreateValidSale3dSync().Instance;
            invalidSale3dSync.Amount = -1;

            var specsContainer = new describe_transaction_execution<Sale3d, Sale3dSuccessResponse, Sale3dErrorResponse>(genesis, validSale3dSync,
                ResponseMocksFactory.CreateSale3dSyncSuccessResponse().Xml, ResponseMocksFactory.CreateSale3dErrorResponse().Xml, invalidSale3dSync);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_Sale3dAsync_requests()
        {
            var validSale3dAsync = RequestMocksFactory.CreateValidSale3dAsync().Instance;
            var invalidSale3dAsync = RequestMocksFactory.CreateValidSale3dAsync().Instance;
            invalidSale3dAsync.Amount = -1;

            var specsContainer = new describe_transaction_execution<Sale3d, Sale3dSuccessResponse, Sale3dErrorResponse>(genesis, validSale3dAsync,
                ResponseMocksFactory.CreateSale3dAsyncSuccessResponse().Xml, ResponseMocksFactory.CreateSale3dErrorResponse().Xml, invalidSale3dAsync);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_Blacklist_requests()
        {
            var validBlacklist = RequestMocksFactory.CreateValidBlacklist().Instance;
            var invalidBlacklist = RequestMocksFactory.CreateValidBlacklist().Instance;
            invalidBlacklist.CardNumber = null;

            var specsContainer = new describe_transaction_execution<Blacklist, BlacklistSuccessResponse, BlacklistErrorResponse>(genesis, validBlacklist,
                ResponseMocksFactory.CreateBlacklistSuccessResponse().Xml, ResponseMocksFactory.CreateBlacklistErrorResponse().Xml, invalidBlacklist);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_SingleChargeback_requests()
        {
            var validBlacklist = RequestMocksFactory.CreateValidSingleChargeback("arn").Instance;

            var specsContainer = new describe_transaction_execution<SingleChargeback, SingleChargebackSuccessResponse, SingleChargebackErrorResponse>(genesis, validBlacklist,
                ResponseMocksFactory.CreateSingleChargebackSuccessResponse().Xml, ResponseMocksFactory.CreateSingleChargebackErrorResponse().Xml);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_MultiChargeback_requests()
        {
            var validMultiChargeback = RequestMocksFactory.CreateValidMultiChargeback().Instance;
            var invalidMultiChargeback = RequestMocksFactory.CreateValidMultiChargeback().Instance;
            invalidMultiChargeback.Page = -1;

            var specsContainer = new describe_transaction_execution<MultiChargeback, MultiChargebackSuccessResponse, MultiChargebackErrorResponse>(genesis, validMultiChargeback,
                ResponseMocksFactory.CreateMultiChargebackSuccessResponse().Xml, ResponseMocksFactory.CreateMultiChargebackErrorResponse().Xml, invalidMultiChargeback);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_SingleReconcile_requests()
        {
            var validSingleReconcile = RequestMocksFactory.CreateValidSingleReconcile().Instance;
            var invalidSingleReconcile = RequestMocksFactory.CreateValidSingleReconcile().Instance;
            invalidSingleReconcile.UniqueId = null;

            var specsContainer = new describe_transaction_execution<SingleReconcile, SingleReconcileSuccessResponse, SingleReconcileErrorResponse>(genesis, validSingleReconcile,
                ResponseMocksFactory.CreateSingleReconcileSuccessResponse().Xml, ResponseMocksFactory.CreateSingleReconcileErrorResponse().Xml, invalidSingleReconcile);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_MultiReconcile_requests()
        {
            var validMultiReconcile = RequestMocksFactory.CreateValidMultiReconcile().Instance;
            var invalidMultiReconcile = RequestMocksFactory.CreateValidMultiReconcile().Instance;
            invalidMultiReconcile.Page = -1;

            var specsContainer = new describe_transaction_execution<MultiReconcile, MultiReconcileSuccessResponse, MultiReconcileErrorResponse>(genesis, validMultiReconcile,
                ResponseMocksFactory.CreateMultiReconcileSuccessResponse().Xml, ResponseMocksFactory.CreateMultiReconcileErrorResponse().Xml, invalidMultiReconcile);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_SingleRetrievalRequest_requests()
        {
            var validSingleRetrievalRequest = RequestMocksFactory.CreateValidSingleRetrievalRequest("arn").Instance;

            var specsContainer = new describe_transaction_execution<SingleRetrievalRequest, SingleRetrievalRequestSuccessResponse, SingleRetrievalRequestErrorResponse>(genesis, validSingleRetrievalRequest,
                ResponseMocksFactory.CreateSingleRetrievalRequestSuccessResponse().Xml, ResponseMocksFactory.CreateSingleRetrievalRequestErrorResponse().Xml);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_MultiRetrievalRequest_requests()
        {
            var validMultiRetrievalRequest = RequestMocksFactory.CreateValidMultiRetrievalRequest().Instance;
            var invalidMultiRetrievalRequest = RequestMocksFactory.CreateValidMultiRetrievalRequest().Instance;
            invalidMultiRetrievalRequest.Page = -1;

            var specsContainer = new describe_transaction_execution<MultiRetrievalRequest, MultiRetrievalRequestSuccessResponse, MultiRetrievalRequestErrorResponse>(genesis, validMultiRetrievalRequest,
                ResponseMocksFactory.CreateMultiRetrievalRequestSuccessResponse().Xml, ResponseMocksFactory.CreateSingleRetrievalRequestErrorResponse().Xml);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_Capture_requests()
        {
            var validCapture = RequestMocksFactory.CreateValidCapture().Instance;
            var invalidCapture = RequestMocksFactory.CreateValidCapture().Instance;
            invalidCapture.Amount = -1;

            var specsContainer = new describe_transaction_execution<Capture, CaptureSuccessResponse, CaptureErrorResponse>(genesis, validCapture,
                ResponseMocksFactory.CreateCaptureSuccessResponse().Xml, ResponseMocksFactory.CreateCaptureErrorResponse().Xml);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_Credit_requests()
        {
            var validCredit = RequestMocksFactory.CreateValidCredit().Instance;
            var invalidCredit = RequestMocksFactory.CreateValidCredit().Instance;
            invalidCredit.Amount = -1;

            var specsContainer = new describe_transaction_execution<Credit, CreditSuccessResponse, CreditErrorResponse>(genesis, validCredit,
                ResponseMocksFactory.CreateCreditSuccessResponse().Xml, ResponseMocksFactory.CreateCreditErrorResponse().Xml);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_RecurringSale_requests()
        {
            var validRecurringSale = RequestMocksFactory.CreateValidRecurringSale().Instance;
            var invalidRecurringSale = RequestMocksFactory.CreateValidRecurringSale().Instance;
            invalidRecurringSale.Amount = -1;

            var specsContainer = new describe_transaction_execution<RecurringSale, RecurringSaleSuccessResponse, RecurringSaleErrorResponse>(genesis, validRecurringSale,
                ResponseMocksFactory.CreateRecurringSaleSuccessResponse().Xml, ResponseMocksFactory.CreateRecurringSaleErrorResponse().Xml);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_Refund_requests()
        {
            var validRefund = RequestMocksFactory.CreateValidRefund().Instance;
            var invalidRefund = RequestMocksFactory.CreateValidRefund().Instance;
            invalidRefund.Amount = -1;

            var specsContainer = new describe_transaction_execution<Refund, RefundSuccessResponse, RefundErrorResponse>(genesis, validRefund,
                ResponseMocksFactory.CreateRefundSuccessResponse().Xml, ResponseMocksFactory.CreateRefundErrorResponse().Xml);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_Void_requests()
        {
            var validVoid = RequestMocksFactory.CreateValidVoidRequest().Instance;
            var invalidVoid = RequestMocksFactory.CreateValidVoidRequest().Instance;
            invalidVoid.Id = null;

            var specsContainer = new describe_transaction_execution<VoidRequest, VoidSuccessResponse, VoidErrorResponse>(genesis, validVoid,
                ResponseMocksFactory.CreateVoidSuccessResponse().Xml, ResponseMocksFactory.CreateVoidErrorResponse().Xml);

            SpecHelper.RunSpecs(specsContainer);
        }

        void it_should_correctly_process_WpfReconcile_requests()
        {
            var validWpfReconcile = RequestMocksFactory.CreateValidWpfReconcile().Instance;
            var invalidWpfReconcile = RequestMocksFactory.CreateValidWpfReconcile().Instance;
            invalidWpfReconcile.UniqueId = null;

            var specsContainer = new describe_transaction_execution<WpfReconcile, WpfReconcileSuccessResponse, WpfReconcileErrorResponse>(genesis, validWpfReconcile,
                ResponseMocksFactory.CreateWpfReconcileSuccessResponseForSuccessfulPayment().Xml, ResponseMocksFactory.CreateWpfReconcileErrorResponse().Xml);

            SpecHelper.RunSpecs(specsContainer);
        }
    }
}
