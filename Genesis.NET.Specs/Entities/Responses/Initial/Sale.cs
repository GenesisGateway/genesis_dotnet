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
    class describe_sale_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateSaleSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<SaleSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateSaleErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<SaleErrorResponse>(errorResponseMock.Xml);
        }
    }
}