using Genesis.NetCore.Entities.Requests.Referential;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Referential
{
    [TestClass]
    public class describe_void
    {
        EntityMock<VoidRequest> voidRequestMock;

        [TestInitialize]
        public void before_each()
        {
            voidRequestMock = RequestMocksFactory.CreateValidVoidRequest();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            voidRequestMock.Instance.should_serialize_and_deserialize<VoidRequest>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            voidRequestMock.Instance.on_validation_should_behave_like_required("Id", "ReferenceId");
        }

        [TestMethod]
        public void it_should_validate_ipv4Address()
        {
            voidRequestMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            voidRequestMock.Instance.should_serialize_to(voidRequestMock.Xml);
        }
    }
}