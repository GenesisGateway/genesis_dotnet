using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Genesis.Net.Common;
using Genesis.Net.Entities;
using Genesis.Net.Entities.Requests;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Entities.Requests.Initial.ThreeD;
using Genesis.Net.Entities.Requests.Query;
using Genesis.Net.Entities.Requests.Referential;
using Genesis.Net.Entities.Responses;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;

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

        public Result<AuthorizeSuccessResponse, AuthorizeErrorResponse> Execute(Authorize authorize)
        {
            return Execute<AuthorizeSuccessResponse, AuthorizeErrorResponse>(authorize);
        }

        public async Task<Result<AuthorizeSuccessResponse, AuthorizeErrorResponse>> ExecuteAsync(Authorize authorize)
        {
            return await ExecuteAsync<AuthorizeSuccessResponse, AuthorizeErrorResponse>(authorize);
        }

        public Result<CaptureSuccessResponse, CaptureErrorResponse> Execute(Capture capture)
        {
            return Execute<CaptureSuccessResponse, CaptureErrorResponse>(capture);
        }

        public async Task<Result<CaptureSuccessResponse, CaptureErrorResponse>> ExecuteAsync(Capture capture)
        {
            return await ExecuteAsync<CaptureSuccessResponse, CaptureErrorResponse>(capture);
        }

        public Result<SaleSuccessResponse, SaleErrorResponse> Execute(Sale sale)
        {
            return Execute<SaleSuccessResponse, SaleErrorResponse>(sale);
        }

        public async Task<Result<SaleSuccessResponse, SaleErrorResponse>> ExecuteAsync(Sale sale)
        {
            return await ExecuteAsync<SaleSuccessResponse, SaleErrorResponse>(sale);
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

        public Result<Authorize3dSuccessResponse, Authorize3dErrorResponse> Execute(Authorize3d authorize3d)
        {
            return Execute<Authorize3dSuccessResponse, Authorize3dErrorResponse>(authorize3d);
        }

        public async Task<Result<Authorize3dSuccessResponse, Authorize3dErrorResponse>> ExecuteAsync(Authorize3d authorize3d)
        {
            return await ExecuteAsync<Authorize3dSuccessResponse, Authorize3dErrorResponse>(authorize3d);
        }

        public Result<Sale3dSuccessResponse, Sale3dErrorResponse> Execute(Sale3d sale3d)
        {
            return Execute<Sale3dSuccessResponse, Sale3dErrorResponse>(sale3d);
        }

        public async Task<Result<Sale3dSuccessResponse, Sale3dErrorResponse>> ExecuteAsync(Sale3d sale3d)
        {
            return await ExecuteAsync<Sale3dSuccessResponse, Sale3dErrorResponse>(sale3d);
        }

        public Result<InitRecurringSale3dSuccessResponse, InitRecurringSale3dErrorResponse> Execute(InitRecurringSale3d initRecurringSale3d)
        {
            return Execute<InitRecurringSale3dSuccessResponse, InitRecurringSale3dErrorResponse>(initRecurringSale3d);
        }

        public async Task<Result<InitRecurringSale3dSuccessResponse, InitRecurringSale3dErrorResponse>> ExecuteAsync(InitRecurringSale3d initRecurringSale3d)
        {
            return await ExecuteAsync<InitRecurringSale3dSuccessResponse, InitRecurringSale3dErrorResponse>(initRecurringSale3d);
        }

        public Result<InitRecurringSaleSuccessResponse, InitRecurringSaleErrorResponse> Execute(InitRecurringSale initRecurringSale)
        {
            return Execute<InitRecurringSaleSuccessResponse, InitRecurringSaleErrorResponse>(initRecurringSale);
        }

        public async Task<Result<InitRecurringSaleSuccessResponse, InitRecurringSaleErrorResponse>> ExecuteAsync(InitRecurringSale initRecurringSale)
        {
            return await ExecuteAsync<InitRecurringSaleSuccessResponse, InitRecurringSaleErrorResponse>(initRecurringSale);
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
            string url = ComposeUrl(request.SubDomain, request.ApiPath, request.AppendTerminalToken);
            var webRequest = WebRequest.Create(url);
            webRequest.Headers["Authorization"] = configuration.Authorization;
            webRequest.Method = "POST";
            webRequest.ContentType = "text/xml";

            byte[] data = XmlSerializationHelpers.Serialize(request);
            webRequest.ContentLength = data.Length;

            var httpWebRequest = webRequest as HttpWebRequest;
            if (httpWebRequest != null)
            {
                httpWebRequest.UserAgent = String.Format("Genesis.Net {0}", typeof(GenesisClient).Assembly.GetName().Version.ToString());
                httpWebRequest.KeepAlive = false;
                httpWebRequest.ClientCertificates.Add(configuration.Certificate);
            }

            using (var requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(data, 0, data.Length);
            }

            return webRequest;
        }

        private string ComposeUrl(string subDomain, string apiPath, bool appendTerminalToken)
        {
            var url = this.IsUrlWithEnvironment() ?
                this.GetUrlWithEnvironment(subDomain, apiPath) : this.GetUrlWithoutEnvironment(subDomain, apiPath);

            if (appendTerminalToken)
            {
                return String.Format("{0}/{1}/", url, configuration.TerminalToken);
            }

            return url;
        }

        private bool IsUrlWithEnvironment()
        {
            return !String.IsNullOrEmpty(configuration.Environment.ToUrlName());
        }

        private string GetUrlWithEnvironment(string subDomain, string apiPath)
        {
            return String.Format("https://{0}.{1}.{2}/{3}/", configuration.Environment.ToUrlName(), subDomain, configuration.getEndpointURL(), apiPath);
        }

        private string GetUrlWithoutEnvironment(string subDomain, string apiPath)
        {
            return String.Format("https://{0}.{1}/{2}/", subDomain, configuration.getEndpointURL(), apiPath);
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
