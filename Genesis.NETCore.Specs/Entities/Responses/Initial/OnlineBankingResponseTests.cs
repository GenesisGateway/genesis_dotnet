using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses.Initial
{
    [TestClass]
    public class OnlineBankingResponseTests
    {
        [TestMethod]
        public void it_ShouldParseSuccessResponse1()
        {
            var successResponseMock = ResponseMocksFactory.CreateOnlineBankingSuccessResponse1();
            successResponseMock.Instance.should_be_parsable_from<OnlineBankingSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_ShouldParseSuccessResponse2()
        {
            var successResponseMock = ResponseMocksFactory.CreateOnlineBankingSuccessResponse2();
            successResponseMock.Instance.should_be_parsable_from<OnlineBankingSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_ShouldParseErrorResponse()
        {
            var errorResponseMock = ResponseMocksFactory.CreateOnlineBankingErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<OnlineBankingErrorResponse>(errorResponseMock.Xml);
        }
    }
}
