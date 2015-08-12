using System;
using System.Linq;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Errors;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Responses.Query
{
    class describe_multi_chargeback_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateMultiChargebackSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<MultiChargebackSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateMultiChargebackErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<MultiChargebackErrorResponse>(errorResponseMock.Xml);
        }
    }
}