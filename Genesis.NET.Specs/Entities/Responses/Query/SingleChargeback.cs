using System;
using System.Linq;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Responses.Query
{
    class describe_single_chargeback_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateSingleChargebackSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<SingleChargebackSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateSingleChargebackErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<SingleChargebackErrorResponse>(errorResponseMock.Xml);
        }
    }
}