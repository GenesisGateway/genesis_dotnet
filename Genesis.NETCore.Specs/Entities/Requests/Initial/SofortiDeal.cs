using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_sofort_ideal
    {
        EntityMock<SofortiDeal> sofortiDealMock;

        [TestInitialize]
        public void before_each()
        {
            sofortiDealMock = RequestMocksFactory.CreateValidSofortiDeal();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            sofortiDealMock.Instance.should_serialize_and_deserialize<SofortiDeal>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            sofortiDealMock.Instance.on_validation_should_behave_like_required("Id",
                "ReturnSuccessUrl", "ReturnFailureUrl", "CustomerBankId", "BankAccountNumber");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            sofortiDealMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        [TestMethod]
        public void it_should_validate_ipv4Address()
        {
            sofortiDealMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            sofortiDealMock.Instance.should_serialize_to(sofortiDealMock.Xml);
        }
    }
}
