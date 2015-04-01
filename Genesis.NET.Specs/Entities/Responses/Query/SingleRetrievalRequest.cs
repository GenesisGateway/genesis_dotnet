using System;
using System.Linq;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Errors;
using NSpec;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Responses.Query
{
    class describe_single_retrieval_request_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateSingleRetrievalRequestSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<SingleRetrievalRequestSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateSingleRetrievalRequestErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<SingleRetrievalRequestErrorResponse>(errorResponseMock.Xml);
        }
    }
}