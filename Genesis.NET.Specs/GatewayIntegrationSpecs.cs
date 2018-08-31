using System;
using System.Linq;
using Genesis.Net.Common;
using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs
{
    /// <summary>
    /// These specs hit the staging environment.
    /// </summary>
#if DEBUG
    class GatewayIntegrationSpecs : nspec
    {
        private IGenesisClient genesis;

        protected void before_each()
        {
            genesis = SpecHelper.CreateGenesisClient(mockHttpWebRequests: false);
        }

        void describe_authorize_request_execution()
        {
            Authorize authorize = null;

            before = () =>
            {
                authorize = RequestMocksFactory.CreateValidAuthorize().Instance;
                authorize.Id = Guid.NewGuid().ToString();
            };

            context["when requesting authorize transaction synchronously"] = () =>
            {
                it["should be successful and return correct message"] = () =>
                {
                    var result = genesis.Execute(authorize);
                    result.SuccessResponse.should_not_be_null();
                    result.SuccessResponse.Message.should_be("TESTMODE: No real money will be transferred!");
                };
            };

            context["when requesting authorize transaction asynchronously"] = () =>
            {
                it["should be successful and return correct message"] = () =>
                {
                    var response = genesis.ExecuteAsync(authorize);
                    response.Wait();
                    var result = response.Result;

                    result.SuccessResponse.should_not_be_null();
                    result.SuccessResponse.Message.should_be("TESTMODE: No real money will be transferred!");
                };
            };
        }

        void describe_wpf_create_request_execution()
        {
            WpfCreate wpfCreate = null;

            before = () =>
            {
                wpfCreate = RequestMocksFactory.CreateValidWpfCreate().Instance;
                wpfCreate.TransactionId = Guid.NewGuid().ToString();
            };

            context["when requesting wpf create transaction synchronously"] = () =>
            {
                it["should return the correct redirect url"] = () =>
                {
                    wpfCreate.Locale = WpfLocales.BG;

                    var result = genesis.Execute(wpfCreate);
                    result.SuccessResponse.should_not_be_null();
                    result.SuccessResponse.RedirectUrl.should_start_with("https://staging.wpf." + SpecHelper.ConfigStorage.getEndpointURL() + "/bg/payment/");
                };
            };

            context["when requesting wpf create transaction asynchronously"] = () =>
            {
                it["should return the correct redirect url"] = () =>
                {
                    wpfCreate.Locale = WpfLocales.DE;

                    var response = genesis.ExecuteAsync(wpfCreate);
                    response.Wait();
                    var result = response.Result;

                    result.SuccessResponse.should_not_be_null();
                    result.SuccessResponse.RedirectUrl.should_start_with("https://staging.wpf." + SpecHelper.ConfigStorage.getEndpointURL() + "/de/payment/");
                };
            };
        }
    }
#endif
}
