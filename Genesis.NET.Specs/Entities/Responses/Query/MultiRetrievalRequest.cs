using System;
using System.Linq;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Responses.Query
{
    class describe_multi_retrieval_request_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateMultiRetrievalRequestSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<MultiRetrievalRequestSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateMultiRetrievalRequestErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<MultiRetrievalRequestErrorResponse>(errorResponseMock.Xml);
        }
    }
}