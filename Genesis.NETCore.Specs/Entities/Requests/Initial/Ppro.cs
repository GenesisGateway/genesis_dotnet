using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_ppro
    {
        EntityMock<Ppro> pproMock;

        [TestInitialize]
        public void before_each()
        {
            pproMock = RequestMocksFactory.CreateValidPpro();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            pproMock.Instance.should_serialize_and_deserialize<Ppro>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            pproMock.Instance.on_validation_should_behave_like_required("Id", "ReturnSuccessUrl", "ReturnFailureUrl");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            pproMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        [TestMethod]
        public void it_should_validate_ipv4Address()
        {
            pproMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            pproMock.Instance.should_serialize_to(pproMock.Xml);
        }
    }
}
