using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses.Initial
{
    [TestClass]
    public class describe_paybyvoucher_responses
    {
        [TestMethod]
        public void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreatePayByVoucherSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<PayByVoucherSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreatePayByVoucherErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<PayByVoucherErrorResponse>(errorResponseMock.Xml);
        }
    }
}
