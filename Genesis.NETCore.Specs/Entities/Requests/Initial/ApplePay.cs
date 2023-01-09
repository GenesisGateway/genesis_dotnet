using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_applepay
    {
        EntityMock<ApplePay> applePayMock;

        [TestInitialize]
        public void before_each()
        {
            applePayMock = RequestMocksFactory.CreateValidApplePay();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            applePayMock.Instance.should_serialize_and_deserialize<ApplePay>();
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            applePayMock.Instance.should_serialize_to(applePayMock.Xml);
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            applePayMock.Instance.on_validation_should_behave_like_required("Id", "PaymentToken", "Subtype");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            applePayMock.Instance.on_validation_should_behave_like_amount("Amount");
        }
    }
}
