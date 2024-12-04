using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class OnlineBankingTests
    {
        EntityMock<OnlineBanking> onlineBankingMock;

        [TestInitialize]
        public void before_each()
        {
            onlineBankingMock = RequestMocksFactory.CreateValidOnlineBanking();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            onlineBankingMock.Instance.should_serialize_and_deserialize<OnlineBanking>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            onlineBankingMock.Instance.on_validation_should_behave_like_required("Id", "ReturnSuccessUrl", "ReturnFailureUrl", "BankCode");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            onlineBankingMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        [TestMethod]
        public void it_should_validate_ipv4Address()
        {
            onlineBankingMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            onlineBankingMock.Instance.should_serialize_to(onlineBankingMock.Xml);
        }

        [TestMethod]
        public void it_should_validate_supported_currencies()
        {
            onlineBankingMock.Instance.on_validation_should_behave_like_supported_currencies();
        }
    }
}
