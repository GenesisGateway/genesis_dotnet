using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses.Query
{
    [TestClass]
    public class describe_single_reconcile_responses
    {
        [TestMethod]
        public void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateSingleReconcileSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<SingleReconcileSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateSingleReconcileErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<SingleReconcileErrorResponse>(errorResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_response_with_empty_country()
        {
            var successResponseMock = ResponseMocksFactory.CreateSingleReconcileSuccessResponseWithUndefinedCountry();
            successResponseMock.Instance.should_be_parsable_from<SingleReconcileSuccessResponse>(successResponseMock.Xml);
        }
    }
}