using System;
using System.Linq;
using Genesis.Net.Common;
using Genesis.Net.Entities.Responses;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Errors;
using NSpec;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Responses.Query
{
    class describe_multi_reconcile_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateMultiReconcileSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<MultiReconcileSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateMultiReconcileErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<MultiReconcileErrorResponse>(errorResponseMock.Xml);
        }
    }
}
