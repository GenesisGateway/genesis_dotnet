using System;
using System.Linq;
using Genesis.Net.Common;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Errors;
using NSpec;
using Genesis.Net.Specs.Mocks;

namespace Genesis.Net.Specs.Entities.Responses
{
    class describe_authorize_3d_responses : nspec
    {
        void it_should_deserialize_success_sync_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateAuthorize3dSyncSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<Authorize3dSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_deserialize_success_async_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateAuthorize3dAsyncSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<Authorize3dSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateAuthorize3dErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<Authorize3dErrorResponse>(errorResponseMock.Xml);
        }
    }
}