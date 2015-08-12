using System;
using System.Linq;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Responses.Referential
{
    class describe_void_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateVoidSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<VoidSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateVoidErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<VoidErrorResponse>(errorResponseMock.Xml);
        }
    }
}
