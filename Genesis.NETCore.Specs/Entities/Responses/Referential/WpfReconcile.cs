using Genesis.NetCore.Entities.Responses.Error;
using Genesis.NetCore.Entities.Responses.Successful;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Responses.Referential
{
    [TestClass]
    public class describe_wpf_reconcile_responses
    {
        [TestMethod]
        public void it_should_parse_success_response_for_successful_payment()
        {
            var successResponseMock = ResponseMocksFactory.CreateWpfReconcileSuccessResponseForSuccessfulPayment();
            successResponseMock.Instance.should_be_parsable_from<WpfReconcileSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_success_response_for_voided_payment()
        {
            var successResponseMock = ResponseMocksFactory.CreateWpfReconcileSuccessResponseForVoidedPayment();
            successResponseMock.Instance.should_be_parsable_from<WpfReconcileSuccessResponse>(successResponseMock.Xml);
        }

        [TestMethod]
        public void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateWpfReconcileErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<WpfReconcileErrorResponse>(errorResponseMock.Xml);
        }
    }
}