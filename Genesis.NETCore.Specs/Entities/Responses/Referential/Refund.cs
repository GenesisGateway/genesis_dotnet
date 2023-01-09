using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses.Referential
{
    [TestClass]
    public class describe_refund_responses
    {
        [TestMethod]
        public void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateRefundSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<RefundSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateRefundErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<RefundErrorResponse>(errorResponseMock.Xml);
        }
    }
}