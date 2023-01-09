using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_sofort
    {
        EntityMock<Sofort> sofortMock;

        [TestInitialize]
        public void before_each()
        {
            sofortMock = RequestMocksFactory.CreateValidSofort();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            sofortMock.Instance.should_serialize_and_deserialize<Sofort>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            sofortMock.Instance.on_validation_should_behave_like_required("Id", "ReturnSuccessUrl", "ReturnFailureUrl");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            sofortMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        [TestMethod]
        public void it_should_validate_ipv4Address()
        {
            sofortMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            sofortMock.Instance.should_serialize_to(sofortMock.Xml);
        }
    }
}
