using Genesis.NetCore.Entities.Requests.Referential;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Referential
{
    [TestClass]
    public class describe_credit
    {
        EntityMock<Credit> creditMock;

        [TestInitialize]
        public void before_each()
        {
            creditMock = RequestMocksFactory.CreateValidCredit();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            creditMock.Instance.should_serialize_and_deserialize<Credit>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            creditMock.Instance.on_validation_should_behave_like_required("Id", "ReferenceId");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            creditMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        [TestMethod]
        public void it_should_validate_ipv4Address()
        {
            creditMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            creditMock.Instance.should_serialize_to(creditMock.Xml);
        }
    }
}