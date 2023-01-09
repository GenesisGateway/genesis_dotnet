using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses.Query
{
    [TestClass]
    public class describe_multi_reconcile_responses
    {
        [TestMethod]
        public void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateMultiReconcileSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<MultiReconcileSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateMultiReconcileErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<MultiReconcileErrorResponse>(errorResponseMock.Xml);
        }
    }
}
