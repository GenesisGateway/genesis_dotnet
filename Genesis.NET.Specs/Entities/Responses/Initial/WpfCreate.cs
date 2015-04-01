using System;
using System.Linq;
using Genesis.Net.Common;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Errors;
using NSpec;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Responses
{
    class describe_wpf_create_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateWpfCreateSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<WpfCreateSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateWpfCreateErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<WpfCreateErrorResponse>(errorResponseMock.Xml);
        }
    }
}
