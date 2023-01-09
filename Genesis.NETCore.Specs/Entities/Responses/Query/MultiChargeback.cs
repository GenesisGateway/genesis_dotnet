using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses.Query
{
    [TestClass]
    public class describe_multi_chargeback_responses
    {
        [TestMethod]
        public void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateMultiChargebackSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<MultiChargebackSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateMultiChargebackErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<MultiChargebackErrorResponse>(errorResponseMock.Xml);
        }
    }
}