using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses.Initial
{
    [TestClass]
    public class describe_ezeewallet_responses
    {
        [TestMethod]
        public void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateEzeeWalletSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<EzeeWalletSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateEzeeWalletErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<EzeeWalletErrorResponse>(errorResponseMock.Xml);
        }
    }
}
