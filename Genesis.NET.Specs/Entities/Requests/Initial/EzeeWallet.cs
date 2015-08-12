using Genesis.Net.Entities.Requests.Initial;
using Genesis.Net.Specs.Mocks;
using NSpec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Net.Specs.Entities.Requests.Initial
{
    class describe_ezeewallet : nspec
    {
        EntityMock<EzeeWallet> ezeeWalletMock;

        void before_each()
        {
            ezeeWalletMock = RequestMocksFactory.CreateValidEzeeWallet();
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            ezeeWalletMock.Instance.should_serialize_and_deserialize<EzeeWallet>();
        }

        void it_should_serialize_to_the_correct_xml()
        {
            ezeeWalletMock.Instance.should_serialize_to(ezeeWalletMock.Xml);
        }

        void it_should_validate_required_properties()
        {
            ezeeWalletMock.Instance.on_validation_should_behave_like_required("Id", "RemoteIp", "SourceWalletId", "SourceWalletPassword",
                "ReturnSuccessUrl", "ReturnFailureUrl");
        }

        void it_should_validate_amount()
        {
            ezeeWalletMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        void it_should_validate_success_url()
        {
            ezeeWalletMock.Instance.on_validation_should_behave_like_url("ReturnSuccessUrl");
        }

        void it_should_validate_failure_url()
        {
            ezeeWalletMock.Instance.on_validation_should_behave_like_url("ReturnFailureUrl");
        }
    }
}
