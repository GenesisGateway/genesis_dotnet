using System;
using System.Linq;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Responses
{
    class describe_applepay_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateApplePaySuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<ApplePaySuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateApplePayErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<ApplePayErrorResponse>(errorResponseMock.Xml);
        }
    }
}
