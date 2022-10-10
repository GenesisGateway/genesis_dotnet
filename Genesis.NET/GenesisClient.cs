using Genesis.Net.Common;
using Genesis.Net.Contracts;
using Genesis.Net.Entities;
using Genesis.Net.Entities.Requests;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Entities.Requests.Initial.Threedsv2;
using Genesis.Net.Entities.Requests.Query;
using Genesis.Net.Entities.Requests.Referential;
using Genesis.Net.Entities.Responses;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Net
{
    internal class GenesisClient : IGenesisClient
    {
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

        public Result<AccountVerificationSuccessResponse, AccountVerificationErrorResponse> Execute(AccountVerification accountVerification)
        {
            return Execute<AccountVerificationSuccessResponse, AccountVerificationErrorResponse>(accountVerification);
        }

        public async Task<Result<AccountVerificationSuccessResponse, AccountVerificationErrorResponse>> ExecuteAsync(AccountVerification accountVerification)
        {
            return await ExecuteAsync<AccountVerificationSuccessResponse, AccountVerificationErrorResponse>(accountVerification);
        }

        public Result<AvsSuccessResponse, AvsErrorResponse> Execute(Avs avs)
        {
            return Execute<AvsSuccessResponse, AvsErrorResponse>(avs);
        }

        public async Task<Result<AvsSuccessResponse, AvsErrorResponse>> ExecuteAsync(Avs avs)
        {
            return await ExecuteAsync<AvsSuccessResponse, AvsErrorResponse>(avs);
        }

        #region deprecated
        public Result<Authorize3dSuccessResponse, Authorize3dErrorResponse> Execute(Entities.Requests.Initial.ThreeD.Authorize3d authorize3d)
        {
            return Execute<Authorize3dSuccessResponse, Authorize3dErrorResponse>(authorize3d);
        }

        public async Task<Result<Authorize3dSuccessResponse, Authorize3dErrorResponse>> ExecuteAsync(Entities.Requests.Initial.ThreeD.Authorize3d authorize3d)
        {
            return await ExecuteAsync<Authorize3dSuccessResponse, Authorize3dErrorResponse>(authorize3d);
        }

        public Result<Sale3dSuccessResponse, Sale3dErrorResponse> Execute(Entities.Requests.Initial.ThreeD.Sale3d sale3d)
        {
            return Execute<Sale3dSuccessResponse, Sale3dErrorResponse>(sale3d);
        }

        public async Task<Result<Sale3dSuccessResponse, Sale3dErrorResponse>> ExecuteAsync(Entities.Requests.Initial.ThreeD.Sale3d sale3d)
        {
            return await ExecuteAsync<Sale3dSuccessResponse, Sale3dErrorResponse>(sale3d);
        }

        public Result<InitRecurringSale3dSuccessResponse, InitRecurringSale3dErrorResponse> Execute(Entities.Requests.Initial.ThreeD.InitRecurringSale3d initRecurringSale3d)
        {
            return Execute<InitRecurringSale3dSuccessResponse, InitRecurringSale3dErrorResponse>(initRecurringSale3d);
        }

        public async Task<Result<InitRecurringSale3dSuccessResponse, InitRecurringSale3dErrorResponse>> ExecuteAsync(Entities.Requests.Initial.ThreeD.InitRecurringSale3d initRecurringSale3d)
        {
            return await ExecuteAsync<InitRecurringSale3dSuccessResponse, InitRecurringSale3dErrorResponse>(initRecurringSale3d);
        }
        #endregion

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

        private Result<S, E> Execute<S, E>(Request request)
            where S : Entity
            where E : Entity, IErrorResponse
        {
            using (var responseStream = ProcessRequest(request))
            {
                return ResultFactory.Parse<S, E>(responseStream);
            }
        }

        private async Task<Result<S, E>> ExecuteAsync<S, E>(Request request)
            where S : Entity
            where E : Entity, IErrorResponse
        {
            using (var responseStream = await ProcessRequestAsync(request))
            {
                return ResultFactory.Parse<S, E>(responseStream);
            }
        }

        private MemoryStream ProcessRequest(Request request)
        {
            EntitiesValidator.Validate(request);

            var webRequest = CreateWebRequest(request);
            return GetResponseStream(webRequest);
        }

        public async Task<MemoryStream> ProcessRequestAsync(Request request)
        {
            EntitiesValidator.Validate(request);

            var webRequest = CreateWebRequest(request);
            return await GetResponseStreamAsync(webRequest);
        }

        private WebRequest CreateWebRequest(Request request)
        {
            var url = ComposeUrl(request.SubDomain, request.ApiPath, request.AppendTerminalToken);
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
                httpWebRequest.UserAgent = string.Format("Genesis.Net {0}", typeof(GenesisClient).Assembly.GetName().Version.ToString());
                httpWebRequest.KeepAlive = false;
            }

            using (var requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(data, 0, data.Length);
            }

            return webRequest;
        }

        private string ComposeUrl(string subDomain, string apiPath, bool appendTerminalToken)
        {
            var url = IsUrlWithEnvironment() ?
                GetUrlWithEnvironment(subDomain, apiPath) : GetUrlWithoutEnvironment(subDomain, apiPath);

            if (appendTerminalToken)
            {
                return string.Format("{0}{1}", url, configuration.TerminalToken);
            }

            return url;
        }

        private bool IsUrlWithEnvironment()
        {
            return !string.IsNullOrEmpty(configuration.Environment.ToUrlName());
        }

        private string GetUrlWithEnvironment(string subDomain, string apiPath)
        {
            return string.Format("https://{0}.{1}.{2}/{3}/", configuration.Environment.ToUrlName(), subDomain, configuration.getEndpointURL(), apiPath);
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
                if (TryGetResponseDataFromWebException(ex, out var responseStream))
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
                if (TryGetResponseDataFromWebException(ex, out var responseStream))
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
