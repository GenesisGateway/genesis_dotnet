using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses.Referential
{
    [TestClass]
    public class describe_credit_responses
    {
        [TestMethod]
        public void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateCreditSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<CreditSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateCreditErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<CreditErrorResponse>(errorResponseMock.Xml);
        }
    }
}
