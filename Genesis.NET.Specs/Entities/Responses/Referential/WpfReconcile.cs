using System;
using System.Linq;
using Genesis.Net.Common;
using Genesis.Net.Entities;
using Genesis.Net.Entities.Responses;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Errors;
using NSpec;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Responses.Referential
{
    class describe_wpf_reconcile_responses : nspec
    {
        void it_should_parse_success_response_for_successful_payment()
        {
            var successResponseMock = ResponseMocksFactory.CreateWpfReconcileSuccessResponseForSuccessfulPayment();
            successResponseMock.Instance.should_be_parsable_from<WpfReconcileSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_success_response_for_voided_payment()
        {
            var successResponseMock = ResponseMocksFactory.CreateWpfReconcileSuccessResponseForVoidedPayment();
            successResponseMock.Instance.should_be_parsable_from<WpfReconcileSuccessResponse>(successResponseMock.Xml);
        }
        
        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateWpfReconcileErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<WpfReconcileErrorResponse>(errorResponseMock.Xml);
        }
    }
}