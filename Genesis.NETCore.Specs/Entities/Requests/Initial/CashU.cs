using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_cashu
    {
        EntityMock<CashU> cashUMock;

        [TestInitialize]
        public void before_each()
        {
            cashUMock = RequestMocksFactory.CreateValidCashU();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            cashUMock.Instance.should_serialize_and_deserialize<CashU>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            cashUMock.Instance.on_validation_should_behave_like_required("Id", "ReturnSuccessUrl", "ReturnFailureUrl");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            cashUMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        [TestMethod]
        public void it_should_validate_ipv4Address()
        {
            cashUMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            cashUMock.Instance.should_serialize_to(cashUMock.Xml);
        }
    }
}