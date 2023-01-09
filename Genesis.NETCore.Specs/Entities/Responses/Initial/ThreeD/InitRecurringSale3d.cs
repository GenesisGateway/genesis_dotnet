using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses
{
    [TestClass]
    public class describe_init_recurring_sale_3d_responses
    {
        [TestMethod]
        public void it_should_deserialize_success_sync_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateInitRecurringSale3dSyncSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<CardTransactionSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_deserialize_success_async_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateInitRecurringSale3dAsyncSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<CardTransactionSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateInitRecurringSale3dErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<CardTransactionErrorResponse>(errorResponseMock.Xml);
        }
    }
}