using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_ezeewallet
    {
        EntityMock<EzeeWallet> ezeeWalletMock;

        [TestInitialize]
        public void before_each()
        {
            ezeeWalletMock = RequestMocksFactory.CreateValidEzeeWallet();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            ezeeWalletMock.Instance.should_serialize_and_deserialize<EzeeWallet>();
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            ezeeWalletMock.Instance.should_serialize_to(ezeeWalletMock.Xml);
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            ezeeWalletMock.Instance.on_validation_should_behave_like_required("Id", "SourceWalletId", "SourceWalletPassword",
                "ReturnSuccessUrl", "ReturnFailureUrl");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            ezeeWalletMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        [TestMethod]
        public void it_should_validate_success_url()
        {
            ezeeWalletMock.Instance.on_validation_should_behave_like_url("ReturnSuccessUrl");
        }

        [TestMethod]
        public void it_should_validate_failure_url()
        {
            ezeeWalletMock.Instance.on_validation_should_behave_like_url("ReturnFailureUrl");
        }
    }
}
