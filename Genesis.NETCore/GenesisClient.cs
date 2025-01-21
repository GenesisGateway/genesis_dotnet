using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Genesis.NetCore.Common;
using Genesis.NetCore.Contracts;
using Genesis.NetCore.Entities;
using Genesis.NetCore.Entities.Requests;
using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Entities.Requests.Initial.Threedsv2;
using Genesis.NetCore.Entities.Requests.Query;
using Genesis.NetCore.Entities.Requests.Referential;
using Genesis.NetCore.Entities.Responses;
using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;

namespace Genesis.NetCore
{
    internal class GenesisClient : IGenesisClient
    {
        private const string SmartRoutingApiPath = "transactions";
        private const string SmartRoutingSubDomain = "api";
        private readonly Configuration configuration;

        public GenesisClient(Configuration configuration)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            this.configuration = configuration;
        }

        public Result<CardTransactionSuccessResponse, CardTransactionErrorResponse> Execute(Authorize authorize)
        {
            return Execute<CardTransactionSuccessResponse, CardTransactionErrorResponse>(authorize);
        }

        public async Task<Result<CardTransactionSuccessResponse, CardTransactionErrorResponse>> ExecuteAsync(Authorize authorize)
        {
            return await ExecuteAsync<CardTransactionSuccessResponse, CardTransactionErrorResponse>(authorize);
        }

        public Result<CaptureSuccessResponse, CaptureErrorResponse> Execute(Capture capture)
        {
            return Execute<CaptureSuccessResponse, CaptureErrorResponse>(capture);
        }

        public async Task<Result<CaptureSuccessResponse, CaptureErrorResponse>> ExecuteAsync(Capture capture)
        {
            return await ExecuteAsync<CaptureSuccessResponse, CaptureErrorResponse>(capture);
        }

        public Result<CardTransactionSuccessResponse, CardTransactionErrorResponse> Execute(Sale sale)
        {
            return Execute<CardTransactionSuccessResponse, CardTransactionErrorResponse>(sale);
        }

        public async Task<Result<CardTransactionSuccessResponse, CardTransactionErrorResponse>> ExecuteAsync(Sale sale)
        {
            return await ExecuteAsync<CardTransactionSuccessResponse, CardTransactionErrorResponse>(sale);
        }

        public Result<RefundSuccessResponse, RefundErrorResponse> Execute(Refund refund)
        {
            return Execute<RefundSuccessResponse, RefundErrorResponse>(refund);
        }

        public async Task<Result<RefundSuccessResponse, RefundErrorResponse>> ExecuteAsync(Refund refund)
        {
            return await ExecuteAsync<RefundSuccessResponse, RefundErrorResponse>(refund);
        }

        public Result<VoidSuccessResponse, VoidErrorResponse> Execute(VoidRequest @void)
        {
            return Execute<VoidSuccessResponse, VoidErrorResponse>(@void);
        }

        public async Task<Result<VoidSuccessResponse, VoidErrorResponse>> ExecuteAsync(VoidRequest @void)
        {
            return await ExecuteAsync<VoidSuccessResponse, VoidErrorResponse>(@void);
        }

        public Result<CreditSuccessResponse, CreditErrorResponse> Execute(Credit credit)
        {
            return Execute<CreditSuccessResponse, CreditErrorResponse>(credit);
        }

        public async Task<Result<CreditSuccessResponse, CreditErrorResponse>> ExecuteAsync(Credit credit)
        {
            return await ExecuteAsync<CreditSuccessResponse, CreditErrorResponse>(credit);
        }

        public Result<PayoutSuccessResponse, PayoutErrorResponse> Execute(Payout payout)
        {
            return Execute<PayoutSuccessResponse, PayoutErrorResponse>(payout);
        }

        public async Task<Result<PayoutSuccessResponse, PayoutErrorResponse>> ExecuteAsync(Payout payout)
        {
            return await ExecuteAsync<PayoutSuccessResponse, PayoutErrorResponse>(payout);
        }

        public Result<AvsSuccessResponse, AvsErrorResponse> Execute(Avs avs)
        {
            return Execute<AvsSuccessResponse, AvsErrorResponse>(avs);
        }

        public async Task<Result<AvsSuccessResponse, AvsErrorResponse>> ExecuteAsync(Avs avs)
        {
            return await ExecuteAsync<AvsSuccessResponse, AvsErrorResponse>(avs);
        }

        public Result<CardTransactionSuccessResponse, CardTransactionErrorResponse> Execute(Authorize3d authorize3d)
        {
            return Execute<CardTransactionSuccessResponse, CardTransactionErrorResponse>(authorize3d);
        }

        public async Task<Result<CardTransactionSuccessResponse, CardTransactionErrorResponse>> ExecuteAsync(Authorize3d authorize3d)
        {
            return await ExecuteAsync<CardTransactionSuccessResponse, CardTransactionErrorResponse>(authorize3d);
        }

        public Result<CardTransactionSuccessResponse, CardTransactionErrorResponse> Execute(Sale3d sale3d)
        {
            return Execute<CardTransactionSuccessResponse, CardTransactionErrorResponse>(sale3d);
        }

        public async Task<Result<CardTransactionSuccessResponse, CardTransactionErrorResponse>> ExecuteAsync(Sale3d sale3d)
        {
            return await ExecuteAsync<CardTransactionSuccessResponse, CardTransactionErrorResponse>(sale3d);
        }

        public Result<CardTransactionSuccessResponse, CardTransactionErrorResponse> Execute(InitRecurringSale3d initRecurringSale3d)
        {
            return Execute<CardTransactionSuccessResponse, CardTransactionErrorResponse>(initRecurringSale3d);
        }

        public async Task<Result<CardTransactionSuccessResponse, CardTransactionErrorResponse>> ExecuteAsync(InitRecurringSale3d initRecurringSale3d)
        {
            return await ExecuteAsync<CardTransactionSuccessResponse, CardTransactionErrorResponse>(initRecurringSale3d);
        }

        public Result<CardTransactionSuccessResponse, CardTransactionErrorResponse> Execute(ContinueRequest initThreeDSv2ContinueRequest)
        {
            return Execute<CardTransactionSuccessResponse, CardTransactionErrorResponse>(initThreeDSv2ContinueRequest);
        }

        public async Task<Result<CardTransactionSuccessResponse, CardTransactionErrorResponse>> ExecuteAsync(ContinueRequest initThreeDSv2ContinueRequest)
        {
            return await ExecuteAsync<CardTransactionSuccessResponse, CardTransactionErrorResponse>(initThreeDSv2ContinueRequest);
        }

        public Result<CardTransactionSuccessResponse, CardTransactionErrorResponse> Execute(InitRecurringSale initRecurringSale)
        {
            return Execute<CardTransactionSuccessResponse, CardTransactionErrorResponse>(initRecurringSale);
        }

        public async Task<Result<CardTransactionSuccessResponse, CardTransactionErrorResponse>> ExecuteAsync(InitRecurringSale initRecurringSale)
        {
            return await ExecuteAsync<CardTransactionSuccessResponse, CardTransactionErrorResponse>(initRecurringSale);
        }

        public Result<RecurringSaleSuccessResponse, RecurringSaleErrorResponse> Execute(RecurringSale recurringSale)
        {
            return Execute<RecurringSaleSuccessResponse, RecurringSaleErrorResponse>(recurringSale);
        }

        public async Task<Result<RecurringSaleSuccessResponse, RecurringSaleErrorResponse>> ExecuteAsync(RecurringSale recurringSale)
        {
            return await ExecuteAsync<RecurringSaleSuccessResponse, RecurringSaleErrorResponse>(recurringSale);
        }

        public Result<BlacklistSuccessResponse, BlacklistErrorResponse> Execute(Blacklist blacklist)
        {
            return Execute<BlacklistSuccessResponse, BlacklistErrorResponse>(blacklist);
        }

        public async Task<Result<BlacklistSuccessResponse, BlacklistErrorResponse>> ExecuteAsync(Blacklist blacklist)
        {
            return await ExecuteAsync<BlacklistSuccessResponse, BlacklistErrorResponse>(blacklist);
        }

        public Result<SingleReconcileSuccessResponse, SingleReconcileErrorResponse> Execute(SingleReconcile singleReconcile)
        {
            return Execute<SingleReconcileSuccessResponse, SingleReconcileErrorResponse>(singleReconcile);
        }

        public async Task<Result<SingleReconcileSuccessResponse, SingleReconcileErrorResponse>> ExecuteAsync(SingleReconcile singleReconcile)
        {
            return await ExecuteAsync<SingleReconcileSuccessResponse, SingleReconcileErrorResponse>(singleReconcile);
        }

        public Result<MultiReconcileSuccessResponse, MultiReconcileErrorResponse> Execute(MultiReconcile multiReconcile)
        {
            return Execute<MultiReconcileSuccessResponse, MultiReconcileErrorResponse>(multiReconcile);
        }

        public async Task<Result<MultiReconcileSuccessResponse, MultiReconcileErrorResponse>> ExecuteAsync(MultiReconcile multiReconcile)
        {
            return await ExecuteAsync<MultiReconcileSuccessResponse, MultiReconcileErrorResponse>(multiReconcile);
        }

        public Result<SingleRetrievalRequestSuccessResponse, SingleRetrievalRequestErrorResponse> Execute(SingleRetrievalRequest singleRetrieval)
        {
            return Execute<SingleRetrievalRequestSuccessResponse, SingleRetrievalRequestErrorResponse>(singleRetrieval);
        }

        public async Task<Result<SingleRetrievalRequestSuccessResponse, SingleRetrievalRequestErrorResponse>> ExecuteAsync(SingleRetrievalRequest singleRetrieval)
        {
            return await ExecuteAsync<SingleRetrievalRequestSuccessResponse, SingleRetrievalRequestErrorResponse>(singleRetrieval);
        }

        public Result<MultiRetrievalRequestSuccessResponse, MultiRetrievalRequestErrorResponse> Execute(MultiRetrievalRequest multiRetrieval)
        {
            return Execute<MultiRetrievalRequestSuccessResponse, MultiRetrievalRequestErrorResponse>(multiRetrieval);
        }

        public async Task<Result<MultiRetrievalRequestSuccessResponse, MultiRetrievalRequestErrorResponse>> ExecuteAsync(MultiRetrievalRequest multiRetrieval)
        {
            return await ExecuteAsync<MultiRetrievalRequestSuccessResponse, MultiRetrievalRequestErrorResponse>(multiRetrieval);
        }

        public Result<SingleChargebackSuccessResponse, SingleChargebackErrorResponse> Execute(SingleChargeback singleChargeback)
        {
            return Execute<SingleChargebackSuccessResponse, SingleChargebackErrorResponse>(singleChargeback);
        }

        public async Task<Result<SingleChargebackSuccessResponse, SingleChargebackErrorResponse>> ExecuteAsync(SingleChargeback singleChargeback)
        {
            return await ExecuteAsync<SingleChargebackSuccessResponse, SingleChargebackErrorResponse>(singleChargeback);
        }

        public Result<MultiChargebackSuccessResponse, MultiChargebackErrorResponse> Execute(MultiChargeback multiChargeback)
        {
            return Execute<MultiChargebackSuccessResponse, MultiChargebackErrorResponse>(multiChargeback);
        }

        public async Task<Result<MultiChargebackSuccessResponse, MultiChargebackErrorResponse>> ExecuteAsync(MultiChargeback multiChargeback)
        {
            return await ExecuteAsync<MultiChargebackSuccessResponse, MultiChargebackErrorResponse>(multiChargeback);
        }

        public Result<WpfCreateSuccessResponse, WpfCreateErrorResponse> Execute(WpfCreate wpfCreate)
        {
            return Execute<WpfCreateSuccessResponse, WpfCreateErrorResponse>(wpfCreate);
        }

        public async Task<Result<WpfCreateSuccessResponse, WpfCreateErrorResponse>> ExecuteAsync(WpfCreate wpfCreate)
        {
            return await ExecuteAsync<WpfCreateSuccessResponse, WpfCreateErrorResponse>(wpfCreate);
        }

        public Result<WpfReconcileSuccessResponse, WpfReconcileErrorResponse> Execute(WpfReconcile wpfReconcile)
        {
            return Execute<WpfReconcileSuccessResponse, WpfReconcileErrorResponse>(wpfReconcile);
        }

        public async Task<Result<WpfReconcileSuccessResponse, WpfReconcileErrorResponse>> ExecuteAsync(WpfReconcile wpfReconcile)
        {
            return await ExecuteAsync<WpfReconcileSuccessResponse, WpfReconcileErrorResponse>(wpfReconcile);
        }

        public Result<ApplePaySuccessResponse, ApplePayErrorResponse> Execute(ApplePay applePay)
        {
            return Execute<ApplePaySuccessResponse, ApplePayErrorResponse>(applePay);
        }

        public async Task<Result<ApplePaySuccessResponse, ApplePayErrorResponse>> ExecuteAsync(ApplePay applePay)
        {
            return await ExecuteAsync<ApplePaySuccessResponse, ApplePayErrorResponse>(applePay);
        }

        public Result<GooglePaySuccessResponse, GooglePayErrorResponse> Execute(GooglePay googlePay)
        {
            return Execute<GooglePaySuccessResponse, GooglePayErrorResponse>(googlePay);
        }

        public async Task<Result<GooglePaySuccessResponse, GooglePayErrorResponse>> ExecuteAsync(GooglePay googlePay)
        {
            return await ExecuteAsync<GooglePaySuccessResponse, GooglePayErrorResponse>(googlePay);
        }

        public Result<PproSuccessResponse, PproErrorResponse> Execute(Ppro ppro)
        {
            return Execute<PproSuccessResponse, PproErrorResponse>(ppro);
        }

        public async Task<Result<PproSuccessResponse, PproErrorResponse>> ExecuteAsync(Ppro ppro)
        {
            return await ExecuteAsync<PproSuccessResponse, PproErrorResponse>(ppro);
        }

        public Result<OnlineBankingSuccessResponse, OnlineBankingErrorResponse> Execute(OnlineBanking onlineBanking)
        {
            return Execute<OnlineBankingSuccessResponse, OnlineBankingErrorResponse>(onlineBanking);
        }

        public async Task<Result<OnlineBankingSuccessResponse, OnlineBankingErrorResponse>> ExecuteAsync(OnlineBanking onlineBanking)
        {
            return await ExecuteAsync<OnlineBankingSuccessResponse, OnlineBankingErrorResponse>(onlineBanking);
        }

        public Result<BankPayoutSuccessResponse, BankPayoutErrorResponse> Execute(BankPayout bankPayout)
        {
            return Execute<BankPayoutSuccessResponse, BankPayoutErrorResponse>(bankPayout);
        }

        public async Task<Result<BankPayoutSuccessResponse, BankPayoutErrorResponse>> ExecuteAsync(BankPayout bankPayout)
        {
            return await ExecuteAsync<BankPayoutSuccessResponse, BankPayoutErrorResponse>(bankPayout);
        }

        private Result<S, E> Execute<S, E>(Request request)
            where S : IEntity
            where E : IEntity, IErrorResponse
        {
            using (var responseStream = ProcessRequest(request))
            {
                return ResultFactory.Parse<S, E>(responseStream);
            }
        }

        private async Task<Result<S, E>> ExecuteAsync<S, E>(Request request)
            where S : IEntity
            where E : IEntity, IErrorResponse
        {
            using (var responseStream = await ProcessRequestAsync(request))
            {
                return ResultFactory.Parse<S, E>(responseStream);
            }
        }

        private MemoryStream ProcessRequest(Request request)
        {
            var webRequest = CreateWebRequest(request);
            return GetResponseStream(webRequest);
        }

        private async Task<MemoryStream> ProcessRequestAsync(Request request)
        {
            var webRequest = CreateWebRequest(request);
            return await GetResponseStreamAsync(webRequest);
        }

        public WebRequest CreateWebRequest(Request request)
        {
            EntitiesValidator.Validate(request);
            var isSmartRoutingAvailable = request is ProcessRequest;
            var usingSmartRouting = configuration.UseSmartRouting && isSmartRoutingAvailable;

            var url = ComposeUrl(request.SubDomain, request.ApiPath, request.AppendTerminalToken, usingSmartRouting);
            var webRequest = WebRequest.Create(url);
            if (request is IPutRequest)
            {
                webRequest.Headers["Authorization"] = configuration.Authorization;
                webRequest.Method = "PUT";
            }
            else
            {
                webRequest.Headers["Authorization"] = configuration.Authorization;
                webRequest.Method = "POST";
            }

            byte[] data;
            if (request is IUrlEncodedSignature)
            {
                webRequest.ContentType = "application/x-www-form-urlencoded";
                var signature = (request as IUrlEncodedSignature).Signature;
                var signatureAsKeyValuePair = new KeyValuePair<string, string>("signature", signature);
                var signatureAsEnumerable = new List<KeyValuePair<string, string>>() { signatureAsKeyValuePair };
                var content = new FormUrlEncodedContent(signatureAsEnumerable);
                data = content.ReadAsByteArrayAsync().Result;
            }
            else
            {
                webRequest.ContentType = "text/xml";
                data = XmlSerializationHelpers.Serialize(request);
            }

            webRequest.ContentLength = data.Length;

            var httpWebRequest = webRequest as HttpWebRequest;
            if (httpWebRequest != null)
            {
                if (!(request is IUrlEncodedSignature) && usingSmartRouting)
                {
                    httpWebRequest.Accept = "text/xml";
                }
                httpWebRequest.UserAgent = string.Format("Genesis.Net {0}", typeof(GenesisClient).Assembly.GetName().Version.ToString());
                httpWebRequest.KeepAlive = false;
            }

            using (var requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(data, 0, data.Length);
            }

            return webRequest;
        }

        private string ComposeUrl(string subDomain, string apiPath, bool appendTerminalToken, bool usingSmartRouting)
        {
            string url;
            if (IsUrlWithEnvironment(usingSmartRouting))
            {
                url = GetUrlWithEnvironment(subDomain, apiPath, usingSmartRouting);
            }
            else
            {
                url = GetUrlWithoutEnvironment(subDomain, apiPath);
            }

            if (appendTerminalToken && !usingSmartRouting)
            {
                return string.Format("{0}{1}", url, configuration.TerminalToken);
            }

            return url;
        }

        private bool IsUrlWithEnvironment(bool useSmartRouting)
        {
            return !string.IsNullOrEmpty(configuration.Environment.ToUrlName(useSmartRouting));
        }

        private string GetUrlWithEnvironment(string subDomain, string apiPath, bool useSmartRouting)
        {
            if (useSmartRouting)
            {
                return string.Format("https://{0}.{1}.{2}/{3}/", configuration.Environment.ToUrlName(configuration.UseSmartRouting), configuration.UseSmartRouting ? SmartRoutingSubDomain : subDomain, configuration.getEndpointURL(), SmartRoutingApiPath);
            }
            else
            {
                return string.Format("https://{0}.{1}.{2}/{3}/", configuration.Environment.ToUrlName(configuration.UseSmartRouting), subDomain, configuration.getEndpointURL(), apiPath);
            }
        }

        private string GetUrlWithoutEnvironment(string subDomain, string apiPath)
        {
            return string.Format("https://{0}.{1}/{2}/", subDomain, configuration.getEndpointURL(), apiPath);
        }

        private MemoryStream GetResponseStream(WebRequest webRequest)
        {
            WebResponse webResponse = null;
            try
            {
                webResponse = webRequest.GetResponse();
                return Copy(webResponse.GetResponseStream());
            }
            catch (WebException ex)
            {
                Stream responseStream;
                if (TryGetResponseDataFromWebException(ex, out responseStream))
                {
                    return Copy(responseStream);
                }

                throw ex;
            }
            finally
            {
                if (webResponse != null)
                {
                    webResponse.Close();
                }
            }
        }

        private async Task<MemoryStream> GetResponseStreamAsync(WebRequest webRequest)
        {
            WebResponse webResponse = null;
            try
            {
                webResponse = await webRequest.GetResponseAsync();
                return Copy(webResponse.GetResponseStream());
            }
            catch (WebException ex)
            {
                Stream responseStream;
                if (TryGetResponseDataFromWebException(ex, out responseStream))
                {
                    return Copy(responseStream);
                }

                throw ex;
            }
            finally
            {
                if (webResponse != null)
                {
                    webResponse.Close();
                }
            }
        }

        private MemoryStream Copy(Stream stream)
        {
            var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);
            return memoryStream;
        }

        private bool TryGetResponseDataFromWebException(WebException webException, out Stream responseData)
        {
            responseData = null;

            var response = webException.Response as HttpWebResponse;
            if (response == null)
            {
                return false;
            }

            // Unprocessable Entity (The request was well-formed but was unable to be followed due to semantic errors.)
            if (response.StatusCode == (HttpStatusCode)422)
            {
                responseData = response.GetResponseStream();
                response.Close();
                return true;
            }

            return false;
        }
    }
}
