using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses.Referential
{
    [TestClass]
    public class describe_recurring_sale_responses
    {
        [TestMethod]
        public void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateRecurringSaleSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<RecurringSaleSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateRecurringSaleErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<RecurringSaleErrorResponse>(errorResponseMock.Xml);
        }
    }
}