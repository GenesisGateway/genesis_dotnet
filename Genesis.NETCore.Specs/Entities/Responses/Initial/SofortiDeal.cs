using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses
{
    [TestClass]
    public class describe_sofort_ideal_responses
    {
        [TestMethod]
        public void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateSofortiDealSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<SofortiDealSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateSofortiDealErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<SofortiDealErrorResponse>(errorResponseMock.Xml);
        }
    }
}