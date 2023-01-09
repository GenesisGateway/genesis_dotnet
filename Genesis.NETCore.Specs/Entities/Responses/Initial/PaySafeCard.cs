using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses
{
    [TestClass]
    public class describe_paysafecard_responses
    {
        [TestMethod]
        public void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreatePaySafeCardSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<PaySafeCardSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreatePaySafeCardErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<PaySafeCardErrorResponse>(errorResponseMock.Xml);
        }
    }
}