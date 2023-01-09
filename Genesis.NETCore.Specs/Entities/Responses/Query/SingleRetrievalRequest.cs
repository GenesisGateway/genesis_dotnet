using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses.Query
{
    [TestClass]
    public class describe_single_retrieval_request_responses
    {
        [TestMethod]
        public void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateSingleRetrievalRequestSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<SingleRetrievalRequestSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateSingleRetrievalRequestErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<SingleRetrievalRequestErrorResponse>(errorResponseMock.Xml);
        }
    }
}