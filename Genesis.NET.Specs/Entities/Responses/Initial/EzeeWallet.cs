using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using Genesis.Net.Specs.Mocks;
using NSpec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Net.Specs.Entities.Responses.Initial
{
    class describe_ezeewallet_responses : nspec
    {
        void it_should_parse_success_response()
        {
            var successResponseMock = ResponseMocksFactory.CreateEzeeWalletSuccessResponse();
            successResponseMock.Instance.should_be_parsable_from<EzeeWalletSuccessResponse>(successResponseMock.Xml);
        }

        void it_should_parse_error_response()
        {
            var errorResponseMock = ResponseMocksFactory.CreateEzeeWalletErrorResponse();
            errorResponseMock.Instance.should_be_parsable_from<EzeeWalletErrorResponse>(errorResponseMock.Xml);
        }
    }
}
