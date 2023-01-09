using Genesis.NetCore.Entities.Requests.Referential;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Referential
{
    [TestClass]
    public class describe_capture
    {
        EntityMock<Capture> captureMock;

        [TestInitialize]
        public void before_each()
        {
            captureMock = RequestMocksFactory.CreateValidCapture();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            captureMock.Instance.should_serialize_and_deserialize<Capture>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            captureMock.Instance.on_validation_should_behave_like_required("Id", "ReferenceId");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            captureMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        [TestMethod]
        public void it_should_validate_ipv4Address()
        {
            captureMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            captureMock.Instance.should_serialize_to(captureMock.Xml);
        }
    }
}