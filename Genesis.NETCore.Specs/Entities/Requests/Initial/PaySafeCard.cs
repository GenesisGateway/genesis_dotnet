using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_paysafecard
    {
        EntityMock<PaySafeCard> paySafeCardMock;

        [TestInitialize]
        public void before_each()
        {
            paySafeCardMock = RequestMocksFactory.CreateValidPaySafeCard();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            paySafeCardMock.Instance.should_serialize_and_deserialize<PaySafeCard>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            paySafeCardMock.Instance.on_validation_should_behave_like_required("Id", "ReturnSuccessUrl", "ReturnFailureUrl");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            paySafeCardMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        [TestMethod]
        public void it_should_validate_ipv4Address()
        {
            paySafeCardMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            paySafeCardMock.Instance.should_serialize_to(paySafeCardMock.Xml);
        }
    }
}
