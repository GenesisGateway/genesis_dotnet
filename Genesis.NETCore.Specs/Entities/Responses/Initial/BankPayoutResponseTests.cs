using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses.Initial
{
    [TestClass]
    public class BankPayoutResponseTests
    {
        [TestMethod]
        public void it_ShouldParseSuccessResponse()
        {
            var successResponseMock = ResponseMocksFactory.CreateBankPayoutSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<BankPayoutSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_ShouldParseErrorResponse()
        {
            var errorResponseMock = ResponseMocksFactory.CreateBankPayoutErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<BankPayoutErrorResponse>(errorResponseMock.Xml);
        }
    }
}
