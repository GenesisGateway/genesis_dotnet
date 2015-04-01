using System;
using System.Linq;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Responses.Query
{
    class describe_single_reconcile_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateSingleReconcileSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<SingleReconcileSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateSingleReconcileErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<SingleReconcileErrorResponse>(errorResponseMock.Xml);
        }
    }
}