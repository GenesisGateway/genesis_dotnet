using System;
using System.Linq;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Specs.Mocks;
using NSpec;

namespace Genesis.Net.Specs.Entities.Responses
{
    class describe_sale_3d_responses : nspec
    {
        void it_should_deserialize_success_sync_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateSale3dSyncSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<Sale3dSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_deserialize_success_async_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateSale3dAsyncSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<Sale3dSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateSale3dErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<Sale3dErrorResponse>(errorResponseMock.Xml);
        }
    }
}