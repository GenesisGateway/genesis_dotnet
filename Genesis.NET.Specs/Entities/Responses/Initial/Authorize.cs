using System;
using System.Linq;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Responses
{
    class describe_authorize_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateAuthorizeSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<CardTransactionSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateAuthorizeErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<CardTransactionErrorResponse>(errorResponseMock.Xml);
        }
    }
}
