using Genesis.NetCore.Entities.Requests.Referential;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Referential
{
    [TestClass]
    public class describe_refund
    {
        EntityMock<Refund> refundMock;

        [TestInitialize]
        public void before_each()
        {
            refundMock = RequestMocksFactory.CreateValidRefund();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            refundMock.Instance.should_serialize_and_deserialize<Refund>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            refundMock.Instance.on_validation_should_behave_like_required("Id", "ReferenceId");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            refundMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        [TestMethod]
        public void it_should_validate_ipv4Address()
        {
            refundMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            refundMock.Instance.should_serialize_to(refundMock.Xml);
        }
    }
}