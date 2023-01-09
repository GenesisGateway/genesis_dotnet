using System;
using Genesis.NetCore.Common;
using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs
{
    /// <summary>
    /// These specs hit the staging environment.
    /// </summary>
#if DEBUG
    [TestClass]
#endif
    public class GatewayIntegrationSpecs
    {
        private IGenesisClient genesis;

        [TestInitialize]
        public void before_each()
        {
            genesis = SpecHelper.CreateGenesisClient(mockHttpWebRequests: false);
        }

        private Authorize init_authorize()
        {
            Authorize authorize = RequestMocksFactory.CreateValidAuthorize().Instance;
            authorize.Id = Guid.NewGuid().ToString();
            authorize.Currency = Iso4217CurrencyCodes.EUR;
            return authorize;
        }

        [TestMethod]
        public void when_requesting_authorize_transaction_synchronously_it_should_be_successful_and_return_correct_message()
        {
            var authorize = init_authorize();
            var result = genesis.Execute(authorize);
            Assert.IsNotNull(result.SuccessResponse, string.Concat(Environment.NewLine, result.ErrorResponse?.Message, Environment.NewLine, result.ErrorResponse?.TechnicalMessage));
            result.SuccessResponse.Message.should_be("TESTMODE: No real money will be transferred!");
        }

        [TestMethod]
        public void when_requesting_authorize_transaction_asynchronously_it_should_be_successful_and_return_correct_message()
        {
            var authorize = init_authorize();
            var response = genesis.ExecuteAsync(authorize);
            response.Wait();
            var result = response.Result;

            Assert.IsNotNull(result.SuccessResponse, string.Concat(Environment.NewLine, result.ErrorResponse?.Message, Environment.NewLine, result.ErrorResponse?.TechnicalMessage));
            result.SuccessResponse.Message.should_be("TESTMODE: No real money will be transferred!");
        }

        private WpfCreate init_wpfCreate()
        {
            WpfCreate wpfCreate = RequestMocksFactory.CreateValidWpfCreate().Instance;
            wpfCreate.TransactionId = Guid.NewGuid().ToString();
            wpfCreate.Currency = Iso4217CurrencyCodes.EUR;
            return wpfCreate;
        }

        [TestMethod]
        public void when_requesting_wpf_create_transaction_synchronously_should_return_the_correct_redirect_url()
        {
            var wpfCreate = init_wpfCreate();
            wpfCreate.Locale = WpfLocales.BG;

            var result = genesis.Execute(wpfCreate);
            Assert.IsNotNull(result.SuccessResponse, string.Concat(Environment.NewLine, result.ErrorResponse?.Message, Environment.NewLine, result.ErrorResponse?.TechnicalMessage));
            Assert.IsTrue(result.SuccessResponse.RedirectUrl.StartsWith("https://staging.wpf." + SpecHelper.ConfigStorage.getEndpointURL() + "/bg/payment/"));
        }

        [TestMethod]
        public void when_requesting_wpf_create_transaction_asynchronously_should_return_the_correct_redirect_url()
        {
            var wpfCreate = init_wpfCreate();
            wpfCreate.Locale = WpfLocales.DE;

            var response = genesis.ExecuteAsync(wpfCreate);
            response.Wait();
            var result = response.Result;

            Assert.IsNotNull(result.SuccessResponse, string.Concat(Environment.NewLine, result.ErrorResponse?.Message, Environment.NewLine, result.ErrorResponse?.TechnicalMessage));
            Assert.IsTrue(result.SuccessResponse.RedirectUrl.StartsWith("https://staging.wpf." + SpecHelper.ConfigStorage.getEndpointURL() + "/de/payment/"));
        }
    }
}
