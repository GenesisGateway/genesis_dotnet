using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses
{
    [TestClass]
    public class describe_wpf_create_responses
    {
        [TestMethod]
        public void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateWpfCreateSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<WpfCreateSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateWpfCreateErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<WpfCreateErrorResponse>(errorResponseMock.Xml);
        }
    }
}
