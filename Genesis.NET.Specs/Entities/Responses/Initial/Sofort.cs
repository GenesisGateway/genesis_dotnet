using System;
using System.Linq;
using Genesis.Net.Common;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Errors;
using NSpec;
using Genesis.Net.Specs.Mocks;
using Genesis.Net.Specs.Entities.Responses.Initial;

namespace Genesis.Net.Specs.Entities.Responses
{
    class describe_sofort_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateSofortSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<SofortSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateSofortErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<SofortErrorResponse>(errorResponseMock.Xml);
        }
    }
}