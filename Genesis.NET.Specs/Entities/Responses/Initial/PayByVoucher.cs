using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Specs.Mocks;
using NSpec;
using System;

namespace Genesis.Net.Specs.Entities.Responses.Initial
{
    class describe_paybyvoucher_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreatePayByVoucherSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<PayByVoucherSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreatePayByVoucherErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<PayByVoucherErrorResponse>(errorResponseMock.Xml);
        }
    }
}
