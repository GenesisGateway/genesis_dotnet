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
    class describe_recurring_sale_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateRecurringSaleSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<RecurringSaleSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateRecurringSaleErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<RecurringSaleErrorResponse>(errorResponseMock.Xml);
        }
    }
}