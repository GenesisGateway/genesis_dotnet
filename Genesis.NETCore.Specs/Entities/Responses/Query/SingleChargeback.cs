using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses.Query
{
    [TestClass]
    public class describe_single_chargeback_responses
    {
        [TestMethod]
        public void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateSingleChargebackSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<SingleChargebackSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateSingleChargebackErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<SingleChargebackErrorResponse>(errorResponseMock.Xml);
        }
    }
}