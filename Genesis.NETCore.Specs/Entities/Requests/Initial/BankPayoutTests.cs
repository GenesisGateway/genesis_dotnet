using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class BankPayoutTests
    {
        EntityMock<BankPayout> bankPayoutMock;

        [TestInitialize]
        public void before_each()
        {
            bankPayoutMock = RequestMocksFactory.CreateValidBankPayout();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            bankPayoutMock.Instance.should_serialize_and_deserialize<BankPayout>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            bankPayoutMock.Instance.on_validation_should_behave_like_required("Id", "NotificationUrl", "ReturnSuccessUrl", "ReturnFailureUrl", "BankCode");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            bankPayoutMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        [TestMethod]
        public void it_should_validate_ipv4Address()
        {
            bankPayoutMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            bankPayoutMock.Instance.should_serialize_to(bankPayoutMock.Xml);
        }

        [TestMethod]
        public void it_should_validate_supported_currencies()
        {
            bankPayoutMock.Instance.on_validation_should_behave_like_supported_currencies();
        }
    }
}
