using Genesis.NetCore.Entities.Requests.Referential;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Referential
{
    [TestClass]
    public class describe_recurring_sale
    {
        EntityMock<RecurringSale> recurringSaleMock;

        [TestInitialize]
        public void before_each()
        {
            recurringSaleMock = RequestMocksFactory.CreateValidRecurringSale();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            recurringSaleMock.Instance.should_serialize_and_deserialize<RecurringSale>();
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            recurringSaleMock.Instance.on_validation_should_behave_like_required("Id", "ReferenceId");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            recurringSaleMock.Instance.on_validation_should_behave_like_amount("Amount");
        }

        [TestMethod]
        public void it_should_validate_ipv4Address()
        {
            recurringSaleMock.Instance.on_validation_should_behave_like_ipv4_address("RemoteIp");
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            recurringSaleMock.Instance.should_serialize_to(recurringSaleMock.Xml);
        }
    }
}