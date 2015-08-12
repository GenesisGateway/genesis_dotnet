using System;
using System.Linq;
using Genesis.Net.Common;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Errors;
using NSpec;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Responses.Referential
{
    class describe_capture_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateCaptureSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<CaptureSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateCaptureErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<CaptureErrorResponse>(errorResponseMock.Xml);
        }
    }
}