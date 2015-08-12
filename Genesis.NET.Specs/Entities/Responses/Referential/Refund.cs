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
    class describe_refund_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateRefundSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<RefundSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateRefundErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<RefundErrorResponse>(errorResponseMock.Xml);
        }
    }
}