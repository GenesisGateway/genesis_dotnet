using Genesis.NetCore.Entities.Requests.Initial;
using Genesis.NetCore.Specs.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities.Requests.Initial
{
    [TestClass]
    public class describe_googlepay
    {
        EntityMock<GooglePay> googlePayMock;

        [TestInitialize]
        public void before_each()
        {
            googlePayMock = RequestMocksFactory.CreateValidGooglePay();
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            googlePayMock.Instance.should_serialize_and_deserialize<GooglePay>();
        }

        [TestMethod]
        public void it_should_serialize_to_the_correct_xml()
        {
            googlePayMock.Instance.should_serialize_to(googlePayMock.Xml);
        }

        [TestMethod]
        public void it_should_validate_required_properties()
        {
            googlePayMock.Instance.on_validation_should_behave_like_required("Id", "PaymentToken", "Subtype");
        }

        [TestMethod]
        public void it_should_validate_amount()
        {
            googlePayMock.Instance.on_validation_should_behave_like_amount("Amount");
        }
    }
}
